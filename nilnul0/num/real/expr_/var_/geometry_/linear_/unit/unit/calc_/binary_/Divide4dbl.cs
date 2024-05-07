using nilnul.geometry.linear_._measured.unit.calc.amount_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.linear_._measured.unit.calc_.binary_
{
	/// <summary>
	/// </summary>
	public class Divide4dbl
		:Calc4dblI
	{
		private Calc4dblI _left;

		public Calc4dblI left
		{
			get { return _left; }
			set { _left = value; }
		}

		private Calc4dblI _right;

		public Calc4dblI right
		{
			get { return _right; }
			set { _right = value; }
		}

		public Divide4dbl(
			Calc4dblI numerator
			,
			Calc4dblI denominator
		)
		{
			this._left = numerator;
			this._right = denominator;
		}

		public Divide4dbl(Calc4dblI ratio, Unit4dblI unit)
			:this(
				 ratio
				 ,
				 new calc_.Unit4dbl(unit)
			)
		{
		}

		public override string ToString()
		{
			return $"{_left}/{_right}";
		}

		public Reduced4dbl reduce()
		{


		}
	}
}
