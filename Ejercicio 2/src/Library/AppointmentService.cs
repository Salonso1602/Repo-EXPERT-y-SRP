using System;
using System.Text;
using System.Collections;

namespace Library
{
    public class AppointmentService
    {
        private static ArrayList scheduledAppointments = new ArrayList(); 
        //para controlar que no se repitan ids

        public static string CreateAppointment(Pacient name, string id, DateTime date, string appoinmentPlace, Doctor doctorName)
        {
            StringBuilder stringBuilder = new StringBuilder("Scheduling appointment...\n");
            Boolean isValid = true;

            if (name.pacientIsValid == false)
            {
                stringBuilder.Append("Unable to schedule appointment, problems with pacients register\n");
                isValid = false;
            }

            if (doctorName.doctorIsValid == false)
            {
                stringBuilder.Append("Unable to schedule appointment, problems with doctor´s register\n");
                isValid = false;
            }

            if (string.IsNullOrEmpty(id))
            {
                stringBuilder.Append("Unable to schedule appointment, id is required\n");
                isValid = false;
            }

            if (string.IsNullOrEmpty(appoinmentPlace))
            {
                stringBuilder.Append("Unable to schedule appointment, Appoinment place is required\n");
                isValid = false;
            }

            if (scheduledAppointments.Contains(id))
            {
                stringBuilder.Append("Unable to schedule appointment, id already taken\n");
                isValid = false;
            }   

            if (isValid)
            {
                stringBuilder.Append("Appoinment Scheduled");
                scheduledAppointments.Add(id);
            }

            return stringBuilder.ToString();
        }
    }

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
