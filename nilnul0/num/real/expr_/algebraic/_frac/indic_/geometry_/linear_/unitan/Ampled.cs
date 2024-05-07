using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.expr_.algebraic._frac.indic_.geometry_.linear_.unitan
{
	/// <summary>
	/// eg:
	///		3 m^2
	///		3 cm^01
	///		5 mm ^ 0
	///		1 nm ^-5
	/// </summary>
	public class Ampled
		:
		nilnul.num.real.expr_.algebraic._frac.indic.Ampled

	{

		public OfUnit indic1 {
			get {
				return (OfUnit) ( base.indic );
			}
		}
		public Ampled(indic_.geometry_.linear_.OfUnit product) : base(product)
		{
		}

		public Ampled(num.real.expr_.var_.geometry_.linear_.UnitI y) : base(y)
		{
		}


		public Ampled(num.real.expr_.var_.geometry_.linear_.Unit y) : base(y)
		{
		}

		public Ampled(RealI coef, num.real.expr_.var_.geometry_.linear_.UnitI var) : base(coef, var)
		{
		}
		public Ampled(RealI coef, geometry.linear_._measured.UnitI var) : this(
			coef,

			var_.geometry_.linear_.Unit.Of(
				var
			)
		)
		{
		}

		public Ampled(RealI coef, indic_.geometry_.linear_.OfUnit product) : base(coef, product)
		{
		}


		public Ampled(int coef, indic_.geometry_.linear_.OfUnit product) : base(coef, product)
		{
		}

		public Ampled(int x, num.real.expr_.var_.geometry_.linear_.UnitI y) : base(x, y)
		{
		}


		/// <summary>
		/// eg:
		///		  3.1* mm^2 
		///		= 3.1 * 0.01 cm^2 
		///		=3.1 * .01) cm^2
		/// </summary>
		/// <returns></returns>
		public unitan.Ampled toAmpled(
			geometry.linear_._measured.UnitI unit

		//var_.geometry_.linear_.UnitI unit
		)
		{
			if (unit == this.indic1.unit)
			{
				return this;
			}

			return new unitan.Ampled(
				this.coef.ToReal() * this.indic1.toAmpled(unit).coef
				,
				unit
			);
		}

		static public unitan.Ampled operator *(
			nilnul.num.RealI real
			,
			unitan.Ampled ampled
		) {
			return new Ampled(
				real.ToReal() * ampled.coef
				,
				ampled.indic1
			);
		}
		static public unitan.Ampled operator *(
			unitan.Ampled ampled
			,
			nilnul.num.RealI real
		) {
			return real * ampled;
		}

	}
}