using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectB
{
    class ClassStudent
    {
        /// <summary>
        /// This is the first name of the student.
        /// </summary>
        public string FirstName;
        /// <summary>
        /// This is the last name of the student. It can be null.
        /// </summary>
        public string LastName;
        /// <summary>
        /// This is the Contact Number of the Student which can be empty.
        /// </summary>
        public string Contact;
        /// <summary>
        /// This is the Email of the student.
        /// </summary>
        public string Email;
        /// <summary>
        /// This is the Registration Number.
        /// </summary>
        public string RegistrationNumber;

        /// <summary>
        /// Status of Student i.e. either he is active or not. ITS value is between 1 and 6.
        /// </summary>
        public int Status;
    }
}
