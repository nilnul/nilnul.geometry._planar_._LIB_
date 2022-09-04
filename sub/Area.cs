using nilnul.geometry.planar._area;
using nilnul.num;
using nilnul.num.real_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using R = nilnul.num.RealI;
namespace nilnul.geometry.planar
{

	public class Area<TUnit>
		:
		nilnul.obj.Measure<TUnit>
		,
		AreaI<TUnit>

		where TUnit : _area.UnitI
	{
		public Area(NonnegI amount, TUnit unit) : base(amount, unit)
		{
		}
		public Area(RealI amount, TUnit unit) : base(amount, unit)
		{
		}

		public Area(int v, TUnit unit) : base(v, unit)
		{
		}
	}

	public class Area : Area<_area.Unit>
	{
		public Area(RealI amount, Unit unit) : base(amount, unit)
		{
		}

		public Area(NonnegI amount, Unit unit) : base(amount, unit)
		{
		}

		public Area(int v, Unit unit) : base(v, unit)
		{
		}
	}
}
