using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetworkService.Model
{
    public class DistEnergyResource
    {
        int id = -1;
        private String name = "";
        private DistEnergyResourceType type;
        private double value = 0.0;

        public DistEnergyResource(int id, string name, DistEnergyResourceType type, double value)
        {
            this.id = id;
            this.name = name;
            this.type = type;
            this.value = value;
        }

        public String Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public double Value
        {
            get { return this.value; }
            set { this.value = value; }
        }

        public DistEnergyResourceType Type
        {
            get { return this.type; }
            set { this.type = value; }
        }

        public int ID
        {
            get { return this.id; }
        }
    }
}
