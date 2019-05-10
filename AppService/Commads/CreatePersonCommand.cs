using Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppService.Commads
{
    public class CreatePersonCommand:ICommand
    {
        public CreatePersonCommand(string firstName, string lastName, short age)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
        }

        public string FirstName { get; }
        public string LastName { get;}
        public short Age { get;}
    }
}
