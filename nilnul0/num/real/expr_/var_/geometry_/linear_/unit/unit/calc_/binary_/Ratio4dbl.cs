using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.linear_._measured.unit.calc_.binary_
{
	/// <summary>
	/// this is unit free; so this is a ratio,
	/// </summary>
	public class Ratio4dbl
		:
		Calc4dblI
	{
		private Unit4dblI _numerator;

		public Unit4dblI numerator
		{
			get { return _numerator; }
			set { _numerator = value; }
		}

		private Unit4dblI _denominator;

		public Unit4dblI denominator
		{
			get { return _denominator; }
			set { _denominator = value; }
		}

		public Ratio4dbl(
			Unit4dblI numerator
			,
			Unit4dblI denominator
		)
		{
			this._numerator = numerator;
			this._denominator = denominator;
		}

		public double toRatio() {
			return _numerator.magnitude.dblen.ee / _denominator.magnitude.dblen.ee;
		}


		public double toRatioInvert() {
			return 1/toRatio();
		}


		public override string ToString()
		{
			return $"{_numerator}/{_denominator}";
		}

		static public Calc4dblI operator *(
			Unit4dblI unit
			,
			Ratio4dbl b
		) {
			if (b._denominator==unit)
			{
				return new calc_.Unit4dbl( b._numerator );
			}
			return new binary_.Multi4dbl(
				unit,b._numerator
			);
		}

		/// <summary>
		/// the ratio is 10/1=10.
		/// To convert mm to cm, say, to convert 17mm to cm, we can :
		///		17mm * ( cm/mm ) /*which is 10; so we need 1/10*/ * 1/10 = 1.7cm
		/// </summary>
		static public readonly Ratio4dbl OfCmMm = new Ratio4dbl(
			unit_.Centimeter4dbl.Singleton
			,
			unit_.Milli4dbl.Singleton
		);






	}
}
