using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectB
{
    class ClassRubric
    {
        /// <summary>
        /// This is the id of the Rubric.
        /// </summary>
        private int Id;

        public int Id1
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

        public string Details1
        {
            get
            {
                return Details;
            }

            set
            {
                Details = value;
            }
        }

        public int CloId1
        {
            get
            {
                return CloId;
            }

            set
            {
                CloId = value;
            }
        }

        /// <summary>
        /// This is the Detail of the Rubric that is added here.
        /// </summary>
        private string Details;
        /// <summary>
        /// This is the CloId of the related rubric that is added.
        /// </summary>
        private int CloId;

    }
}
