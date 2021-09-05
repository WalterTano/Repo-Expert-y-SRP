using System;
using System.Text;

namespace Library
{
    public class Doctor
    {
        public string LastName { get; set; }

        public Doctor(string lastName){
            this.LastName = lastName;
        }

        public Boolean ValidateDoctor(StringBuilder stringBuilder){
            Boolean isValid = true;

            if(String.IsNullOrEmpty(this.LastName)){
                stringBuilder.Append("Unable to schedule appointment, Doctor name is required\n");
                isValid = false;
            }

            return isValid;
        }
    }
}
