using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCassignment1
{
    public class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Nickname { get; set; }
        public string Gender { get; set; }
        public int DOB { get; set; }
        public string Email { get; set; }


        public Person(string firstname, string lastname, string nickname, string gender, int dob, string email)
        {
            FirstName = firstname;
            LastName = lastname;
            Nickname = nickname;
            Gender = gender;
            DOB = dob;
            Email = email;
        }

    }
}