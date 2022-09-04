using nilnul.num;
using nilnul.num.real_;

namespace nilnul.geometry.linear_._measured
{
	public abstract class UnitA :
		nilnul.obj._measure.UnitA
		,
		UnitI
	{

		protected UnitA(PositiveI val) : base(val)
		{
		}

		public UnitA(RealI x) : this(new nilnul.num.real_.Positive(x))
		{

		}

		public UnitA(nilnul.num.real_.Quotient x) : this((RealI)(x))
		{

		}

		protected UnitA(Quotient1 quotient1) : this(
			new nilnul.num.real_.Quotient(quotient1)
		)
		{
		}

		protected UnitA(int quotient1) : this(
			new nilnul.num.Quotient1(quotient1)
		)
		{
		}

	}





}
