using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp36
{
    internal class GroupsMeeting : Meeting
    {
        private double p;

        public GroupsMeeting(int n1, int n2, double p) : base(n1, n2)
        {
            this.p = p;
        }

        public double P 
        { 
            get { return p; } 
            set { if (value > 0) p = value; }
        }

        public override double GetQ()
        {
            return base.GetQ() + P / N2;
        }
    }
}
