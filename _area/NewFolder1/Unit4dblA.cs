using nilnul.num.real_;
using System;

namespace nilnul.geometry.planar._area
{
	[Obsolete(nameof(sub._area.Unit4dblI))]

	public abstract class Unit4dblA

		:
		nilnul.obj._measure.Unit4dblA,

		Unit4dblI
	{
		protected Unit4dblA(PositiveDblI val) : base(val)
		{
		}

		protected Unit4dblA(PositiveDbl x) : base(x)
		{
		}

		protected Unit4dblA(double x) : base(x)
		{
		}
	}
}
