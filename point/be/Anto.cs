using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.point.be
{
	public class Anto<TBe>
		:nilnul.obj.be.Anto<planar.PointI1, TBe>
		,
		planar.point.BeI
		where TBe: nilnul.obj.BeI1< planar.PointI1 > ,new()
	{
	}
}
