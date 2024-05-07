using nilnul.geometry.linear_._measured.unit.calc_.binary_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.linear_._measured.unit.calc.amount_.ratio_
{
	public class Normalized
	{
		private Ratio4dbl _ratio;

		public Ratio4dbl ratio
		{
			get { return _ratio; }
			set { _ratio = value; }
		}

		public Normalized(Ratio4dbl ratio)
		{
			this._ratio = ratio;
		}

		public Normalized(Unit4dblI unit, Unit4dblI radic):this(
			new Ratio4dbl(unit,radic)
		)
		{
		}

		public double dividend {
			get {
				return _ratio.numerator.magnitude.dblen.ee / _ratio.denominator.magnitude.dblen.ee;
			}
		}

		public double quantity {
			get {
				return 1/dividend;
			}
		}


		public calc.Amount4dbl toAmount() {
			return new calc.Amount4dbl(
				1/dividend
				,
				_ratio
			);
		}



		/// <summary>
		/// multi this to a distance, and the distance would not change;
		/// </summary>
		/// <returns></returns>
		public override string ToString()
		{
			return $"{_ratio}/{dividend}";
		}


		static public calc.Amount4dbl operator *(
			Normalized normalized
			,
			measured.span.Distance4dbl distance
		) {
			return new calc.Amount4dbl(
				distance.amount.realee.ee / normalized.dividend
				,
				new calc_.binary_.Multi4dbl(
					normalized.ratio
					,
					distance.unit
				)
			);
		}

	}
}
