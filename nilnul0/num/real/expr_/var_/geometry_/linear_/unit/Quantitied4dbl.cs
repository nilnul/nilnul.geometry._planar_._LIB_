using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.expr_.var_.geometry_.linear_.unitan
{
	/// <summary>
	/// signed measure; or: deviation;
	/// </summary>
	public class Quantitied4dbl
		:
		nilnul.obj.measure.Signed4dbl<
			geometry.linear_._measured.UnitI
		>
	{
		public Quantitied4dbl(double amount, geometry.linear_._measured.UnitI unit) : base(amount, unit)
		{
		}

		public Quantitied4dbl(decimal amount, geometry.linear_._measured.UnitI unit) : base(
			(double)amount, unit
		)
		{
		}

		public Quantitied4dbl(long amount, geometry.linear_._measured.UnitI unit) : base(amount, unit)
		{
		}

		public Quantitied4dbl(int amount, geometry.linear_._measured.UnitI unit) : base(amount, unit)
		{
		}
		public Quantitied4dbl( geometry.linear_._measured.UnitI unit) : this(1, unit)
		{
		}

		public Quantitied4dbl(double quantity0, geometry.linear_._measured.UnitI unit) : base(quantity0, unit)
		{
		}

		public unitan.Quantitied toDeviationByStd(
		)
		{
			return new unitan.Quantitied(
				unit.magnitude
				,
				geometry.linear_._measured.Unit.Singleton
			);
		}

		static public Quantitied4dbl operator *(nilnul.num.RealI quantity, Quantitied4dbl quantitied) {
			return new Quantitied4dbl(
				quantity.ToReal() * quantitied.quantity
				,
				quantitied.unit
			);
		}

		/// <summary>
		/// eg:
		///		  mm^2 
		///		=  (0.1 cm)^2 
		///		=.01 cm^2
		/// </summary>
		/// <returns></returns>
		public unitan.Quantitied toDeviation(
			geometry.linear_._measured.UnitI unit
		)
		{
			if (unit == this.unit)
			{
				return this;
			}

			return this.quantity * var_.geometry_.linear_.Unit.ToDeviation(this.unit,unit);
		}
	}
}