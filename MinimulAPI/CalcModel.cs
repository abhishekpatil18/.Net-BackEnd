namespace MinimulAPI
{
    public class CalcModel
    {
        int n1;
        int n2;
        string? op;

        public int Num1
        {
            get { return n1; }
            set { n1 = value; }
        }

        public int Num2
        {
            get { return n2; }
            set { n2 = value; }
        }

        public string Op
        {
            get { return op; }
            set { op = value; }
        }
    }
}
