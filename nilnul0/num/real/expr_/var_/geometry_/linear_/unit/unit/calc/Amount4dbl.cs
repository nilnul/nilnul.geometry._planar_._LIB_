using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.linear_._measured.unit.calc
{
	/// <summary>
	/// this can be reduced to:
	///		
	/// </summary>
	public class Amount4dbl
	{

		private calc_.indic.Prod4dbl _calc;

		public Calc4dblI calc
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

		public Amount4dbl(
			double quantity_
			,
			Calc4dblI calc_
		)
		{
			this._quantity = quantity_
				;
			this._calc = calc_;
		}

		public Amount4dbl(
			
			Calc4dblI calc_
		):this(1,calc_)
		{
			
		}

		public Amount4dbl(
			
			Unit4dblI calc_
		):this(new  calc_.Unit4dbl(calc_) )
		{
			
		}

		static public Amount4dbl operator *(Amount4dbl a, Amount4dbl b) {
			return new Amount4dbl(
				a._quantity*b._quantity
				,
				new calc_.binary_.Multi4dbl(
					a._calc
					,
					b._calc
				)
			);
		}







	}
}
