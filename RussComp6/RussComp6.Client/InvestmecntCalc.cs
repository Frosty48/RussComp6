namespace RussComp6.Client
{
    public class InvestmecntCalc
    {
        private int cmpPerYr = 0;//compound per year
        private double interest = 0.0;
        private double principal = 0.0;
        private int years = 0;
        private double futureValue = 0.0;



        public int CmpPerYr
        {
            get { return cmpPerYr; }//could use => to point to the return value instead of get
            set { cmpPerYr = value; Calc(); }
        }


        public double Interest
        {
            get { return interest; }
            set { interest = value; Calc(); }
        }


        public double Principal
        {
            get { return principal; }
            set { principal = value; Calc(); }

        }


        public int Years
        {
            get { return years; }
            set { years = value; Calc(); }
        }


        public double FutureValue
        {
            get { return futureValue; }
            set { futureValue = value; Calc(); }
        }


        private void Calc()
        {

            double newInterest = 0.0;
            newInterest = interest / 100;

            futureValue = principal * Math.Pow((1 + newInterest / cmpPerYr), (cmpPerYr * years));

        }

        private void InvestmentCalc() { }//empty parameter
        public static void InvestmentCalc(double principal, int years, double interest, int numTime) { }

    }
}