using nilnul.num.real_.nonneg;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.geometry.planar.rect._size
{
	public class WidthHeightDbl
		:
		nilnul.obj.Box<nilnul.num.real_.nonneg.CoDbl>
	{
		

		public WidthHeightDbl(nilnul.num.real_.NonnegOfDouble x, nilnul.num.real_.NonnegOfDouble y ):base(new num.real_.nonneg.CoDbl( x,y))
		{
			
		}

		public WidthHeightDbl(double x, double y)
			:this(
				new nilnul.num.real_.NonnegOfDouble(x)
				,
				new nilnul.num.real_.NonnegOfDouble(y)
			)
		{

		}

		public WidthHeightDbl(LengthD lengthD1, LengthD lengthD2) : this(
			lengthD1.abs*lengthD1.unit.AsMeters
			,
			lengthD2.abs*lengthD2.unit.AsMeters

		)
		{
		}

		public WidthHeightDbl(CoDbl val) : base(val)
		{
		}

		public override string ToString()
		{
			return string.Format("{0}*{1}", boxed.Item1.ToString() ,boxed.Item2.ToString());
		}

		static public WidthHeightDbl A4_inMeters = new WidthHeightDbl(0.210, 0.297);

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

		public static WidthHeightDbl CreateFromInches(double x, double y)
		{

			return new WidthHeightDbl(
				nilnul.geometry.LengthD.CreateFroInch(x)
				,
				nilnul.geometry.LengthD.CreateFroInch(y)

			);

		}
		public static WidthHeightDbl CreateByAbs(double x, double y)
		{

			return new WidthHeightDbl( CoDbl.CreateByAbs(x,y) );

		}


	}
}

