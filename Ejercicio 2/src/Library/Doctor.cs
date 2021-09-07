using System;

namespace Library
{
    public class Doctor
    {
        public string Name {get; set;}
        public string Specialty {get; set;}
        public Boolean doctorIsValid {get; set;}

        public Doctor (string name, string specialty)
        {
            this.doctorIsValid = true;

            if (string.IsNullOrEmpty(name))
            {
                Console.WriteLine("Unable to register Doctor, Name is required\n");
                this.doctorIsValid = false;
            }
            else
            {
                this.Name = name;
            }
            
            if (string.IsNullOrEmpty(specialty))
            {
                Console.WriteLine("Unable to register doctor, Specialty is required\n");
                this.doctorIsValid = false;
            }
            else
            {
                this.Specialty = specialty;
            }
        }
    }
}