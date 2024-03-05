using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingSystem
{
    internal class ParkingSpace
    {
        private List<Vehicle> parkIn;
        private List<Vehicle> parkOut;

        public ParkingSpace()
        {
            this.parkIn = new List<Vehicle>();
            this.parkOut = new List<Vehicle>();
        }

        public List<Vehicle> ParkIn {
            get { return this.parkIn; }
            set { this.parkIn = value; }
        }

        public List<Vehicle> ParkOut
        {
            get { return this.parkOut; }
            set { this.parkOut = value; }
        }


    }
}
