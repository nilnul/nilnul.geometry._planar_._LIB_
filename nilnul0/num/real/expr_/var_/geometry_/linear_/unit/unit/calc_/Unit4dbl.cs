using nilnul.geometry.linear_._measured.unit.calc.amount_;
using nilnul.geometry.linear_._measured.unit.calc_.indic;

namespace nilnul.geometry.linear_._measured.unit.calc_
{
	public class Unit4dbl
		: nilnul.obj.Box1<_measured.Unit4dblI>
		,
		unit.Calc4dblI
	{
		public Unit4dbl(Unit4dblI val) : base(val)
		{
		}

		public Reduced4dbl reduce()
		{
			return new Reduced4dbl(
				this.boxed
			);
		}

		public Prod4dbl toIndics()
		{
			return toIndic().toIndics();
		}
		public Indic4dbl toIndic()
		{
			return new Indic4dbl(
				this.boxed
			);
		}

	}


}
