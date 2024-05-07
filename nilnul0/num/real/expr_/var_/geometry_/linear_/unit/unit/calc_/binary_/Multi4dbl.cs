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
	public class Multi4dbl
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

		public Multi4dbl(
			Calc4dblI numerator
			,
			Calc4dblI denominator
		)
		{
			this._left = numerator;
			this._right = denominator;
		}

		public Multi4dbl(Calc4dblI ratio, Unit4dblI unit)
			:this(
				 ratio
				 ,
				 new calc_.Unit4dbl(unit)
			)
		{
		}

		public Multi4dbl(Unit4dblI a, Unit4dblI b)
			:this( new calc_.Unit4dbl(a), b)
		{
		}

		public override string ToString()
		{
			return $"{_left}*{_right}";
		}

		/// <summary>
		/// eg:
		///		cm * mm
		///		=cm * (mm * cm/mm) /10
		///		=cm^2 /10
		/// </summary>
		/// <returns></returns>
		/// <exception cref="NotImplementedException"></exception>
		public Reduced4dbl reduce()
		{
			var leftReduced = left.reduce();
			var rightReduced = right.reduce();



		}
	}
}
