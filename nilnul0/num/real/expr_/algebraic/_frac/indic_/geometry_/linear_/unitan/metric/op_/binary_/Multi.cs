using nilnul.geometry.linear_._measured;

namespace nilnul.num.real.expr_.algebraic._frac.indic_.geometry_.linear_.unitan.metric.op_.binary_
{
	public class Multi
		:
		nilnul.obj.Box_ofIn<
			geometry.linear_._measured.UnitI
		>
		,
		BinaryI
	{
		public Multi(in UnitI val) : base(val)
		{
		}

		public Multi(UnitI x) : base(x)
		{
		}

		public Ampled op(Ampled par, Ampled par1)
		{
			return _MultiX.Multi(this.boxed,par, par1);
		}
	}
}