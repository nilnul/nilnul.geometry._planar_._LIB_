


using System;
using nilnul.geometry.length.meter;
using nilnul.geometry.length.meter.foot;
using F = nilnul.num._quotient.fraction.be.Noneg.Asserted;

namespace nilnul.geometry.length
{
    public class Foot_InchFrac:LengthI, _length.InMetersDI
    {
		public int foot { get; set; }
		public nilnul.num._quotient.fraction.be.Noneg.Asserted inch { get; set; }
		public Foot_InchFrac(int f,F i)
		{
			this.foot = f;
			inch = i;

		}

		public Foot_InchFrac(int foot, int inchNum, int inchDen)
			:this(
				foot
				 ,
				new F(inchNum,inchDen)	 
			 )
		{

		}
	

		public override string ToString()
		{
			return foot+"\'"+inch+"\'\'";
		}

	 

		public double InMeters()
		{
			return foot * _length.unit.Foot.MsPerFoot+ nilnul.num.quotient.to.Doubl.ToDouble_castNumDen( 
				new nilnul.num._quotient.fraction.op.Simplify.Ed1(
				inch.val
				))*_length.unit.foot.Inch.Meters_per_Inch;

			throw new NotImplementedException();
		}
	}
}
