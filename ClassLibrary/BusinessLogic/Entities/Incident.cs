using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//business logic
namespace EcoScooter.Entities
{
    public partial class Incident
    {
        public Incident()
        {

        }
        public Incident(String Description, DateTime TimeStamp)
        {
            this.Description = Description;
            this.TimeStamp = TimeStamp;


        }

    
    }
}
