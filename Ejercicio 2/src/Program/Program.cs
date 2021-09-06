using System;
using Library;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Pacient paciente1 = new Pacient("Messi", "34", "18001337");
            Doctor doctor1 = new Doctor("House", "Diagnósticos Médicos");
            Pacient paciente2 = new Pacient("", "34", "18001337");
            Doctor doctor2 = new Doctor("", "Diagnósticos Médicos");
            
            string appointmentResult = AppointmentService.CreateAppointment(paciente1, "5555-555-555", DateTime.Now, "Wall Street", doctor1);
            Console.WriteLine(appointmentResult);

            string appointmentResult2 = AppointmentService.CreateAppointment(paciente2, "5555-555-555", DateTime.Now, "Queen Street", doctor2);
            Console.WriteLine(appointmentResult2);
        }
    }
}
