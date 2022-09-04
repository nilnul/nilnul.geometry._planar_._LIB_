using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.cycle_.gon_.facade.re_
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
		gon_.facade.Re4dblI
	{
		public bool re(Facade4dbl outer, Facade4dbl inner)
		{

			if (
					zone_.gon.vsPoint.has_.byRay_._StokesIfIntersected.IsInPolygon(
						outer,
					inner.ee.vertexes.First()
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
