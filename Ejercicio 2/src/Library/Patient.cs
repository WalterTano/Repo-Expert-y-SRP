using System;
using System.Text;

namespace Library
{
    public class Patient
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string FullName {
            get{
                if(String.IsNullOrEmpty(this.FirstName) || String.IsNullOrEmpty(this.LastName)){
                    return null;
                }
                return $"{this.FirstName} {this.LastName}";
            }
        }

        public string PhoneNumber { get; set; }

        public Patient(string firstName, string lastName, string phoneNumber){
            this.FirstName = firstName;
            this.LastName = lastName;
            this.PhoneNumber = phoneNumber;
        }

        public Boolean ValidatePatient(StringBuilder stringBuilder){
            Boolean isValid = true;

            if(String.IsNullOrEmpty(this.FirstName) || String.IsNullOrEmpty(this.LastName)){
                stringBuilder.Append("Unable to schedule appointment, Name is required\n");
                isValid = false;
            }

            if(String.IsNullOrEmpty(this.PhoneNumber)){
                stringBuilder.Append("Unable to schedule appointment, Phone number is required\n");
                isValid = false;
            }

            return isValid;
        }
    }
}
