using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TW_2
{
    public enum Gender { Male, Female, Other }
    class Person
    {
        //properties

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string MiddleName { get; set; }

        public string Address { get; set; }

        public string City { get; set; }

        public string Province { get; set; }

        public string Country { get; set; }

        public string PostalCode { get; set; }

        public string PhoneNumber { get; set; }

        public string Email { get; set; }

        public string CellPhone { get; set; }

        public Gender Gender { get; set; }

        public DateTime DateOfBirth { get; set; }




    }
}
