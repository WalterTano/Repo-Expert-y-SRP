using System;
using Library;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            //string appointmentResult = AppointmentService.CreateAppointment("Steven Jhonson", "986782342", "5555-555-555", DateTime.Now, "Wall Street", "Armand");
            Patient patient1 = new Patient("Steven", "Jhonson", "5555-555-555");
            Doctor doctor1 = new Doctor("Armand");
            string appointmentResult1 = AppointmentService.CreateAppointment(patient1, "986782342", DateTime.Now, "Wall Street", doctor1);
            Console.WriteLine(appointmentResult1);

            //string appointmentResult2 = AppointmentService.CreateAppointment("Ralf Manson", "", "5555-555-555", DateTime.Now, "Queen Street", "");
            Patient patient2 = new Patient("Ralf", "Manson", "5555-555-555");
            Doctor doctor2 = new Doctor("");
            string appointmentResult2 = AppointmentService.CreateAppointment(patient2, "", DateTime.Now, "Queen Street", doctor2);
            Console.WriteLine(appointmentResult2);

            string appointmentResult3 = AppointmentService.CreateAppointment(patient2, "986782342", DateTime.Now, "Queen Street", doctor1);
            Console.WriteLine(appointmentResult3);
        }
    }
}
