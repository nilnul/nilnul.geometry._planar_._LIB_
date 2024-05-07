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
	/// <see cref=""/>
	public class Quantitied
		:
		nilnul.obj.measure.Signed<
			geometry.linear_._measured.UnitI
		>
	{
		public Quantitied(RealI amount, geometry.linear_._measured.UnitI unit) : base(amount, unit)
		{
		}

		public Quantitied(real_.Quotient amount, geometry.linear_._measured.UnitI unit) : base(amount, unit)
		{
		}

		public Quantitied(QuotientI1 amount, geometry.linear_._measured.UnitI unit) : base(amount, unit)
		{
		}

		public Quantitied(Quotient1 amount, geometry.linear_._measured.UnitI unit) : base(amount, unit)
		{
		}

		public Quantitied(long amount, geometry.linear_._measured.UnitI unit) : base(amount, unit)
		{
		}

		public Quantitied(int amount, geometry.linear_._measured.UnitI unit) : base(amount, unit)
		{
		}
		public Quantitied(geometry.linear_._measured.UnitI unit) : this(1, unit)
		{
		}




		static public Quantitied operator *(nilnul.num.RealI quantity, Quantitied quantitied)
		{
			return new Quantitied(
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
		public unitan.Quantitied changeUnit(
			geometry.linear_._measured.UnitI unit
		)
		{
			if (unit == this.unit)
			{
				return this;
			}

			return this.quantity * var_.geometry_.linear_.Unit.ToDeviation(this.unit, unit);
		}
		public unitan.Quantitied changeUnit2std(
		)
		{
			return changeUnit(
				geometry.linear_._measured.Unit.Singleton
			);
		}


		public algebraic._frac.indic_.geometry_.linear_.unitan.Ampled toRational(
		)
		{
			return new expr_.algebraic._frac.indic_.geometry_.linear_.unitan.Ampled(this.quantity, this.unit);
		}



	}
}