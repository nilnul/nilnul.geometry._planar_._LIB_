using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.cycle_.gon.re_
{
	/// <summary>
	/// the second is at the interal of the first. the two are not tangent or crossed, or incident at some edges.
	/// </summary>
	/// alias:
	///		constraint
	///		confine
	///		imprision
	///		
	public class CloseInner
		:
		nilnul.obj.ReA<Polygon4dblI>
		,

		gon.Re4dblI
	{

		public override bool re(Polygon4dblI  outer, Polygon4dblI inner)
		{

			if (
					cycle_.gon.vsPoint.sign_._PointInsidePolygon.IsInsidePolygon(
						inner.vertexes.First()
						,
						outer
				) != true
			)
			{
				return false;
			}

			return !outer.grads.Any(
					outerGrad => inner.grads.Any(
						innerGrad =>
							planar.grad_.skid.re_.Joint4dbl.Singleton._re_assumeSkids(
								outerGrad
								,
								innerGrad
							)
					)
				)
			;

		}

	

	

		static public CloseInner Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<CloseInner>.Instance;
			}
		}

	}
}
