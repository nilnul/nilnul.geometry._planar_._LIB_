using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.linear_._measured.unit.calc.amount_
{
	/// <summary>
	/// this can be reduced to:
	///		eg:
	///			3.1 * cm^0
	///			4* cm^-1
	///			5*cm
	///			7* cm^3
	///	
	/// </summary>
	/// <see cref="unit.calc_.Indic4dbl"/>
	public class Reduced4dbl
	{

		private calc_.Indic4dbl _calc;

		public calc_.Indic4dbl calc
		{
			get { return _calc; }
			set { _calc = value; }
		}

		private double _quantity;

		public double quantity
		{
			get { return _quantity; }
			set { _quantity = value; }
		}

		public Reduced4dbl(
			double quantity_
			,
			calc_.Indic4dbl calc_
		)
		{
			this._quantity = quantity_
				;
			this._calc = calc_;
		}

		public Reduced4dbl(
			calc_.Indic4dbl calc_
		) : this(1, calc_)
		{

		}

		public Reduced4dbl(Unit4dblI boxed)
			: this(
				  new calc_.Indic4dbl(boxed)
				 )
		{
		}

	

		/// <summary>
		/// eg:
		///		3 mm
		///			3 mm * ( 0.1 cm/mm ) =  3 * 0.1 * (mm* cm/ mm)
		///		3*cm^-2
		///			= 3* ( cm * mm/cm / 0.1)^-2
		///			= 3* ( mm /0.1 )^-2
		///			= 3* mm^-2 / 0.1^-2
		///			= 3/0.1^-2 * mm^-2
		/// </summary>
		/// <param name="unit"></param>
		/// <returns></returns>
		public Reduced4dbl changeUnit(Unit4dblI unit)
		{

	

			return amount.op_.binary_._MultiX.Multi2reduce(
				this.quantity
				,
				reduced_.CoefOne.ChangeUnit(this._calc, unit)
			);

		}

		static public Reduced4dbl _Multi_assumeSameUnit(Reduced4dbl amount, Reduced4dbl reduced)
		{


			return new Reduced4dbl(
				amount._quantity * reduced._quantity
				,
				new calc_.Indic4dbl(
					reduced._calc.radic
					,
					amount._calc.indic + reduced._calc.indic
				)
			);



		}


		static public Reduced4dbl operator *(Reduced4dbl amount, Reduced4dbl reduced)
		{

			if (reduced._calc.radic == amount._calc.radic)
			{
				return _Multi_assumeSameUnit(
					amount
					,
					reduced.changeUnit(amount._calc.radic)
				);

			}

			return _Multi_assumeSameUnit(
				amount
				,
				reduced.changeUnit(amount._calc.radic)
			);


		}



		static public Reduced4dbl Reduce(Calc4dblI amount)
		{

			return amount.reduce();
		}
		static public Reduced4dbl Reduce(Amount4dbl amount)
		{

			return amount.quantity*
				amount.calc.reduce()
			;
		}

		static public Reduced4dbl operator *(double x, Reduced4dbl y) {
			return new Reduced4dbl(
				x*y.quantity
				,
				y.calc
			);
		}




	}
}
