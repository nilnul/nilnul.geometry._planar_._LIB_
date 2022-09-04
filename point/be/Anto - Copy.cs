using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.point.be
{
	public class AntoDbl<TBe>
		:nilnul.obj.be.Anto<planar.Point4dbl, TBe>
		,
		planar.point.BeDblI
		where TBe: planar.point.BeDblI ,new()
	{
	}
}
