using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace CustomExceptions
{
    class PersonalNotFoundExceptions : Exception
    {
        public PersonalNotFoundExceptions()
        {
        }

        public PersonalNotFoundExceptions(string message) : base(message)
        {
        }

        public PersonalNotFoundExceptions(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
