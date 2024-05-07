using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.expr_.algebraic._frac.indic_.geometry_.linear_.unitans
{
	/// <summary>
	/// eg:
	/// 	mm^2 * cm^-1
	/// </summary>
	public class Prod
		: nilnul.num.real.expr_.algebraic._frac.pows.Product
	{

		public IEnumerable<_frac.indic_.geometry_.linear_.OfUnit> indics {
			get {
				return base.pows.Select(p => (_frac.indic_.geometry_.linear_.OfUnit)p);
			}
		}

		public Prod(IEnumerable<OfUnit> val) : base(val)
		{
		}


		public Prod(params OfUnit[] val) : base(val)
		{
		}

		public Prod(num.real.expr_.var_.geometry_.linear_.Unit y) : base(y)
		{
		}

		public Prod(params num.real.expr_.var_.geometry_.linear_.Unit[] vars) :
			base(
			vars.Select(x=>new OfUnit(x))
		)
		{
		}

		public Prod(IEnumerable<num.real.expr_.var_.geometry_.linear_.Unit> vars) : base(vars)
		{
		}



		/// <summary>
		/// eg:
		///		   mm^2 * cm^-1
		/// </summary>
		/// <returns></returns>
		public unitan.Ampled toAmpled(
			geometry.linear_._measured.UnitI unit

		//var_.geometry_.linear_.UnitI unit
		)
		{
			var cumulator = new indic_.geometry_.linear_.unitan.metric.op_.binary_.multi.cumulator.Cumulate(
				unit
			);

			return cumulator.cumulate(
				this.indics.Select(
					i=>i.toAmpled(unit)
				)
			);
		}
	}
}