using nilnul.num.real.expr_._algebraic;
using nilnul.num.real.expr_._algebraic.pows;
using nilnul.num.real.expr_._algebraic.pows.prod;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.expr_.algebraic_.geometry_.linear_
{
	public class Unit
		:
		nilnul.num.real.expr_.Algebraic
	{
		public Unit()
		{
		}

		public Unit(List<Scaled_powIndexPositive> scaleds) : base(scaleds)
		{
		}

		public Unit(IEnumerable<Scaled_powIndexPositive> scaleds) : base(scaleds)
		{
		}

		public Unit(params Scaled_powIndexPositive[] scaleds) : base(scaleds)
		{
		}

		public Unit(IEnumerable<Product_ofPositivePow> scaleds) : base(scaleds)
		{
		}

		public Unit(params Product_ofPositivePow[] scaleds) : base(scaleds)
		{
		}

		public Unit(Pow_indexPositive pow) : base(pow)
		{
		}

		public Unit(VarI y) : base(y)
		{
		}

		public Unit(int v) : base(v)
		{
		}

		public Unit(RealI x, VarI y) : base(x, y)
		{
		}

		public Unit(int x, VarI y) : base(x, y)
		{
		}
	}
}
