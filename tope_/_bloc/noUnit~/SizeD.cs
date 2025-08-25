using nilnul.num.real_.nonneg;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.geometry.planar._area
{
	[Obsolete(nameof(tope_._bloc.SpreadDbl))]
	public class SizeDbl
		:
		nilnul.obj.Box<nilnul.num.real_.nonneg.CoDbl>
	{
		

		public SizeDbl(nilnul.num.real_.NonnegOfDouble x, nilnul.num.real_.NonnegOfDouble y ):base(new num.real_.nonneg.CoDbl( x,y))
		{
			
		}

		public SizeDbl(double x, double y)
			:this(
				new nilnul.num.real_.NonnegOfDouble(x)
				,
				new nilnul.num.real_.NonnegOfDouble(y)
			)
		{

		}

		//public SizeDbl(nilnul.geometry.linear.span.DistanceDbl lengthD1, LengthD lengthD2) : this(
		//	lengthD1.magnitude*lengthD1.unit..AsMeters
		//	,
		//	lengthD2.abs*lengthD2.unit.AsMeters

		//)
		//{
		//}

		public System.Drawing.Size toSizeInt() {
			return new System.Drawing.Size(
				(int)this.width.realee.ee
				,
				(int)this.height.realee.ee

			);
		}

		public SizeDbl(CoDbl val) : base(val)
		{
		}

		public override string ToString()
		{
			return string.Format("{0}*{1}", boxed.Item1.ToString() ,boxed.Item2.ToString());
		}

		static public SizeDbl A4_inMeters = new SizeDbl(0.210, 0.297);

		public nilnul.num.real_.NonnegOfDoubleI width
		{
			get
			{
				return boxed.Item1;

			}
		}

		public nilnul.num.real_.NonnegOfDoubleI height
		{
			get
			{
				return boxed.Item2;
				
			}
		}

		//public static SizeDbl CreateFromInches(double x, double y)
		//{

		//	return new SizeDbl(
		//		nilnul.geometry.LengthD.CreateFroInch(x)
		//		,
		//		nilnul.geometry.LengthD.CreateFroInch(y)

		//	);

		//}
		public static SizeDbl CreateByAbs(double x, double y)
		{

			return new SizeDbl( CoDbl.CreateByAbs(x,y) );

		}


	}
}

