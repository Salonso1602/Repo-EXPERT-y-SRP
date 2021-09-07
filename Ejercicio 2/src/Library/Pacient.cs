using System;

namespace Library
{
    
    public class Pacient
    {
        public string Name {get; set;}
        public string Age {get; set;}
        public string PhoneNumber {get; set;}
        public Boolean pacientIsValid {get; set;}

        public Pacient (string name, string age, string phonenumber)
        {
            this.pacientIsValid = true;

            if (string.IsNullOrEmpty(name))
            {
                Console.WriteLine("Unable to register pacient, Name is required\n");
                this.pacientIsValid = false;
            }
            else
            {
                this.Name = name;
            }
                
            if (string.IsNullOrEmpty(age))
            {
                Console.WriteLine("Unable to register pacient, Age is required\n");
                this.pacientIsValid = false;            
            }
            else
            {
                this.Age = age;
            }

            if (string.IsNullOrEmpty(phonenumber))
            {
                Console.WriteLine("Unable to register pacient, Phone Number is required\n");
                this.pacientIsValid = false;
            }
            else
            {
                this.PhoneNumber = phonenumber;
            }
        }
    }
}