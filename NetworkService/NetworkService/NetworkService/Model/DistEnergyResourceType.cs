using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace NetworkService.Model
{
    public class DistEnergyResourceType
    {
        public static DistEnergyResourceType SOLAR = new DistEnergyResourceType("Solar", "");
        public static DistEnergyResourceType WIND = new DistEnergyResourceType("Wind", "");

        private String name = "";
        private String image = "";

        private DistEnergyResourceType(string name, string image)
        {
            this.name = name;
            this.image = image;
        }

        public String Name
        {
            get { return this.name; }
            set { this.name = value; }  
        }

        public String Image
        {
            get { return this.image; }
            set { this.image = value; }
        }
    } 
}
