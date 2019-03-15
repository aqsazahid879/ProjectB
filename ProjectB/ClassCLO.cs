using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectB
{
    class ClassCLO
    {
        /// <summary>
        /// Name is the name of the CLO.
        /// </summary>
        private string Name;
        /// <summary>
        /// Id is the Id of the CLO.
        /// </summary>
        private string Id;
        /// <summary>
        /// This is the date of the record on which CLO is created.
        /// </summary>
        private DateTime DateCreated;
        /// <summary>
        /// This is the date on which the date is updated.
        /// </summary>
        private DateTime DateUpdated;

        public string Name1
        {
            get
            {
                return Name;
            }

            set
            {
                Name = value;
            }
        }

        public string Id1
        {
            get
            {
                return Id;
            }

            set
            {
                Id = value;
            }
        }

        public DateTime DateCreated1
        {
            get
            {
                return DateCreated;
            }

            set
            {
                DateCreated = value;
            }
        }

        public DateTime DateUpdated1
        {
            get
            {
                return DateUpdated;
            }

            set
            {
                DateUpdated = value;
            }
        }
    }
}
