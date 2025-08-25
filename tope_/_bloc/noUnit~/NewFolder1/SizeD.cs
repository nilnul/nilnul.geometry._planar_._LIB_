using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.geometry.planar
{
	[Obsolete()]
	public struct SizeDbl
	{
		public nilnul.num.real.double_.NonNegativeX2.Asserted x;
		public nilnul.num.real.double_.NonNegativeX2.Asserted y;

		public SizeDbl(nilnul.num.real.double_.NonNegativeX2.Asserted x, nilnul.num.real.double_.NonNegativeX2.Asserted y )
		{
			this.x = x;
			this.y = y;

		}

		public SizeDbl(double x, double y)
			:this(
				new nilnul.num.real.double_.NonNegativeX2.Asserted(x)
				,
				new nilnul.num.real.double_.NonNegativeX2.Asserted(y)
			)
		{

		}

		public SizeDbl(LengthD lengthD1, LengthD lengthD2) : this(
			lengthD1.abs*lengthD1.unit.AsMeters
			,
			lengthD2.abs*lengthD2.unit.AsMeters

		)
		{
		}

		public override string ToString()
		{
			return string.Format("{0}*{1}", x.ToString() ,y.ToString());
		}

		static public SizeDbl A4_inMeters = new SizeDbl(0.210, 0.297);

		public LengthI width
		{
			get
			{
				return new nilnul.geometry.length.Meters(x.val);
				throw new NotImplementedException();
			}
		}

		public LengthI height
		{
			get
			{
				return new nilnul.geometry.length.Meters(y.val);
				
				throw new NotImplementedException();
			}
		}

		public static SizeDbl CreateFromInches(double x, double y)
		{

			return new SizeDbl(
				nilnul.geometry.LengthD.CreateFroInch(x)
				,
				nilnul.geometry.LengthD.CreateFroInch(y)

			);

		}
	}
}

