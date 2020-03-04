using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//persistence
namespace EcoScooter.Entities
{
    public partial class Incident
    {
        public String Description
        {
            get;
            set;
        }

        public int Id
        {
            get;
            set;
        }

        public DateTime TimeStamp
        {
            get;
            set;
        }


       
    }
}
