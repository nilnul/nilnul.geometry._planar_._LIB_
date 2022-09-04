using nilnul.num;
using nilnul.num.real_;
using System;

namespace nilnul.geometry._linear._length.unit_.meter
{
	/// <summary>
	/// 
	/// </summary>
	public  class Mm : UnitA
	{
		public Mm(PositiveI val) : base(nilnul.num.Quotient1.CreateUnit(1000) )
		{
		}

		public Mm(RealI x) : base(x)
		{
		}

		public Mm(num.real_.Quotient x) : base(x)
		{
		}

		public Mm(Quotient1 quotient1) : base(quotient1)
		{
		}

		public Mm(int quotient1) : base(quotient1)
		{
		}

		public double AsMeters
		{
			get
			{
				return 1.0 / 1000;

			}
		}
	}
}
