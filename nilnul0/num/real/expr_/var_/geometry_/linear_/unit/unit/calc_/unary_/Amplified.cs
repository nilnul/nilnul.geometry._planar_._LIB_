using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.linear_._measured.unit.calc_.unary_
{
	/// <summary>
	/// <seealso cref="measured.span.Distance4dblI"/>
	/// </summary>
	public class Amplified
	{
		private double _amplifier;

		public double amplifier
		{
			get { return _amplifier; }
			set { _amplifier = value; }
		}

		private Unit4dblI _denominator;

		public Unit4dblI denominator
		{
			get { return _denominator; }
			set { _denominator = value; }
		}

		public Amplified(
			double numerator
			,
			Unit4dblI denominator
		)
		{
			this._amplifier = numerator;
			this._denominator = denominator;
		}

		public Amplified(
			Unit4dblI unit
		):this (1,unit)
		{

		}

	
		public override string ToString()
		{
			return $"{_amplifier}{_denominator}";
		}







	}
}
