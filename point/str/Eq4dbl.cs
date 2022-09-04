using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.point.str
{
	public class Eq4dbl
		:
		nilnul.objs.eq_.MemberEqDefault<
			planar.Point4dblI
			,
			point.EqDbl
		>
		,
		IEqualityComparer<
			IEnumerable<planar.Point4dblI>
		>
	{


	}
}
