using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sesion4.clases
{
    //calcular el salario neto de el empleado
    internal class Empleado
    {
        public Empleado() { }

        object x = new object();


        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public double Salary { get; set; }

        public Empleado(int id, string firstName, string lastName, string email, string phone, double salary)
        {
            ID = id;
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Phone = phone;
            Salary = salary;
        }
    }
}