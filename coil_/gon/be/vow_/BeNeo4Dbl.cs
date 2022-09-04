using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.coil_.gon.be.vow_
{
	public class BeNeo4Dbl<TBe>
		:
		nilnul.obj.be.vow_.BeDefaulted4<
			geometry.planar.coil_.Gon4dblI
			,
			TBe
		>
		,
		geometry.planar.coil_.gon.Vow4dblI

		where TBe: nilnul.obj.BeI1<
			geometry.planar.coil_.Gon4dblI
		>,new()
	{
	}
}
