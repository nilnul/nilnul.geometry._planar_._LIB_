


using nilnul.geometry.linear_._measured.unit_.eng_;

namespace nilnul.geometry.linear_.measured.span.distance_.eng_
{
    public class FootsInches
    {
		public int foot { get; set; }
		public double inch { get; set; }
		public FootsInches(int f,double i)
		{
			this.foot = f;
			inch = i;

		}
		public Meters4dbl toMeter() {
			return new Meters4dbl(.3048*foot + .00254*inch);
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
