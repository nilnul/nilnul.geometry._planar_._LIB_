using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.grad_.skid.be.vow_
{
	public class BeDefault<TBe>
		:
		nilnul.obj.be.vow_.BeDefaulted4<
			geometry.planar.grad_.Skid4dblI
			,
			TBe
		>
		,
		geometry.planar.grad_.skid.Vow4dblI

		where TBe: nilnul.obj.BeI1<
			geometry.planar.grad_.Skid4dblI
		>,new()
	{
	}
}
