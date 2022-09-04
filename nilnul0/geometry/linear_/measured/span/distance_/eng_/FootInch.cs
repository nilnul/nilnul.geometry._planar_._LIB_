


using nilnul.geometry.length.meter;
using nilnul.geometry.length.meter.foot;

namespace nilnul.geometry.length
{
    public class FootInch
    {
		public int foot { get; set; }
		public double inch { get; set; }
		public FootInch(int f,double i)
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
		    return foot*Foot.Meters_Per_This+ inch*Inch.Inch2MeterAsDouble;
	    }



    }
}
