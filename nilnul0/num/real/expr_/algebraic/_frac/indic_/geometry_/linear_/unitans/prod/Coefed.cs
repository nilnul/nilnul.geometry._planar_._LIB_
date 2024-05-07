using nilnul.num.real.expr_.algebraic._frac.pows;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using U =nilnul.num.real.expr_.var_.geometry_.linear_.Unit;

namespace nilnul.num.real.expr_.algebraic._frac.indic_.geometry_.linear_.unitans.prod
{
	/// <summary>
	/// eg:
	///		3.5 cm^2 mm/ m^2 
	/// </summary>
	/// alias:
	///		metric
	///	vs:
	///		<see cref="nilnul.obj.measure.ISigned"/>
	///	vs:
	///		<see cref="nilnul.obj.IMetric"/>
	public class Coefed
		: nilnul.num.real.expr_.algebraic._frac.pows.prod.Scaled
	{


		public Prod prod
		{
			get { return (Prod)  base.product; }
		}

		public Coefed()
		{
		}

		public Coefed(RealI coef) : base(coef)
		{
		}

		public Coefed(Prod product) : base(product)
		{
		}

		public Coefed(OfUnit product) : base(product)
		{
		}

		public Coefed(int x) : base(x)
		{
		}

		public Coefed(U y) : base(y)
		{
		}

		public Coefed(RealI coef, Prod product) : base(coef, product)
		{
		}

		public Coefed(int coef, Prod product) : base(coef, product)
		{
		}

		public Coefed(RealI x, U y) : base(x, y)
		{
		}

		public Coefed(int x, U y) : base(x, y)
		{
		}

		public Coefed(int v, params U[] vars) : base(v, vars)
		{
		}

		/// <summary>
		/// eg:
		///		3.2 *  ( cm * mm^2 / dm )
		///		=3.2 cm * (0.1 cm)^2 / (10 cm)
		///		=3.2 * .01 / 10 * cm^2
		/// </summary>
		/// <returns></returns>
		public unitan.Ampled toAmpled(
			geometry.linear_._measured.UnitI unit

		//var_.geometry_.linear_.UnitI unit
		)
		{
			return this.prod.toAmpled(unit) * this.coef;
		}
	}
}
