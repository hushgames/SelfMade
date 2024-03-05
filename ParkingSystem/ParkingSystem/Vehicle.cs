using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingSystem
{
    internal class Vehicle
    {
        public string plateNo;
        public string type;
        public string brand;
        public DateTime dateTime;
        public DateTime timeOut;

        public Vehicle(string plateNo, string type, string brand)
        {
            this.plateNo = plateNo;
            this.type = type;
            this.brand = brand;
            this.dateTime = DateTime.Now;
        }

        public string PlateNo {
            get { return plateNo; }
            set { plateNo = value; }
        }
        public string Type
        {
            get { return type; }
            set { type = value; }
        }
        public string Brand
        {
            get { return plateNo; }
            set { plateNo = value; }
        }

        public DateTime TimeOut
        {
            get { return timeOut; }
            set { this.timeOut = value; }
        }
    }
}
