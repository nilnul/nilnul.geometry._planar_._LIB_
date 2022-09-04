using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.grad.be.vow_
{
	public class BeDefault<TBe>
		:
		nilnul.obj.be.vow_.BeDefaulted4<
			geometry.planar.Grad4dbl_byPointsI
			,
			TBe
		>
		,
		geometry.planar.grad.Vow4dblI

		where TBe: nilnul.obj.BeI1<
			geometry.planar.Grad4dbl_byPointsI
		>,new()
	{
	}
}
