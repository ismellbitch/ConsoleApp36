namespace ConsoleApp36
{
    internal class Meeting
    {
        private int n1;
        private int n2;

        public Meeting(int n1, int n2)
        {
            this.n1 = n1;
            this.n2 = n2;
        }

        public int N1 
        { 
            get { return n1; } 
            set { if (n1 > 0) n1 = value; }
        }
        public int N2 
        { 
            get { return n2; } 
            set { if (n2 > 0) n2 = value; }
        }

        public virtual double GetQ()
        {
            return N1 / N2;
        }

        public override string? ToString()
        {
            return $"Число ораторов - {N1}, число участников - {N2}, Q - {GetQ()}";
        }
    }
}
