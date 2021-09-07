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
}
