using System;
using System.Collections.Generic;
using System.Text;

namespace Frequency_Var_2.Models
{
    public class Person
    {
        private string Firstname;
        private string Lastname;
        private DateTime BirthDate;
        public string firstname { get { return this.Firstname; } set { this.Firstname = value; } }
        public string lastname { get { return this.Lastname; } set { this.Lastname = value; } }
        public DateTime birthDate { get { return this.BirthDate; } set { this.BirthDate = value; } }

        public int BirthYear
        {
            get { return this.BirthDate.Year; }
            set { this.BirthDate = new DateTime(value, this.BirthDate.Month, this.BirthDate.Day); }
        }

        public Person(string firstname, string lastname, DateTime birthDate)
        {
            Firstname = firstname;
            Lastname = lastname;
            BirthDate = birthDate;
        }
        public Person() 
        {
            Firstname = "Inna";
            Lastname = "Shapovalova";
            BirthDate = new DateTime(2005, 7, 20);
        }

        public override string ToString()
        {
            return "\n\tlastname: " + Lastname + "\n\tfirstname: " + Firstname + "\n\tbirthdate: " + BirthDate.ToString() + "\n";
        }
        public virtual string ToShortString()
        {
            return "Person: " + Lastname + " " + Firstname;
        }
    }
}
