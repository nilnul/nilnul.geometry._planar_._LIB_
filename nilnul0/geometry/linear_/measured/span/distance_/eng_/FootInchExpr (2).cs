


namespace nilnul.length
{
    public class FootInchExpr
    {
		public int foot { get; set; }
		public double inch { get; set; }
		public FootInchExpr(int f,double i)
		{
			this.foot = f;
			inch = i;

		}
		public MeterExpr toMeter() {
			return new MeterExpr(.3048*foot + .00254*inch);
		}


		public override string ToString()
		{
			return foot+"\'"+inch+"\'\'";
		}

	    public static double ToMeters(int foot, double inch)
	    {
		    return foot*Foot.MsPerFoot + inch*Inch.Inch2MeterAsDouble;
	    }



    }
}
