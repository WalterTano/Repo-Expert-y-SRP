using System;
using System.Text;
using System.Collections;

namespace Library
{
    public class AppointmentService
    {
        private static ArrayList appointmentIds = new ArrayList();
        public static ArrayList AppointmentIds { get => appointmentIds; }

        /*
        En lugar de validar todos los datos en el mismo método con el que creamos la consulta, deberíamos
        verificar los datos de los pacientes y los doctores al registrarlos en el sistema del hospital.
        Si la información de los pacientes o los doctores que se requiere para crear una consulta cambiara,
        sería necesario continuar modificando este método.
        */
        public static string CreateAppointment(Patient patient, string id, DateTime date, string appointmentPlace, Doctor doctor)
        {
            StringBuilder stringBuilder = new StringBuilder("Scheduling appointment...\n");
            Boolean isValid = true;

            isValid = patient.ValidatePatient(stringBuilder);

            if (string.IsNullOrEmpty(id))
            {
                stringBuilder.Append("Unable to schedule appointment, id is required\n");
                isValid = false;
            } else if(AppointmentService.AppointmentIds.Contains(id)){
                stringBuilder.Append("Unable to schedule appointment, id already exsits\n");
                isValid = false;
            }

            if (string.IsNullOrEmpty(appointmentPlace))
            {
                stringBuilder.Append("Unable to schedule appointment, Appoinment place is required\n");
                isValid = false;
            }

            isValid = doctor.ValidateDoctor(stringBuilder) && isValid;

            if (isValid)
            {
                stringBuilder.Append("Appoinment Scheduled");
                AppointmentService.AppointmentIds.Add(id);
            }

            return stringBuilder.ToString();
        }

    }
}
