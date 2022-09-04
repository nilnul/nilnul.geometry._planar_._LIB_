using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.cycle_.gon.co.be_
{
	/// <summary>
	/// some might be at the internal of the other
	/// </summary>
	public class Disjoint4dbl
		:
		nilnul.obj.ReA<cycle_.Polygon4dblI>
		,
		co.Be4dblI
	{
		public override bool re(Polygon4dblI Item1, Polygon4dblI Item2)
		{
#if DEBUG
			IEnumerable<(Grad4dbl_byPointsI g, Grad4dbl_byPointsI g1)> t
				= from g in Item1.grads
					from g1 in Item2.grads
					select (g, g1)

				;

			IEnumerable <
				
					(Grad4dbl_byPointsI outerGrad, Grad4dbl_byPointsI innerGrad)
				
			> intersectedGrads = Item1.grads.SelectMany(
					outerGrad => Item2.grads.Select(
						innerGrad =>
						(outerGrad, innerGrad)
				)
			);

			var intersectedAsArray=t.Where(
				c=> planar.grad_.skid.re_.Joint4dbl.Singleton._re_assumeSkids(
								c
				)
			).ToArray();



#endif
			return		 !Item1.grads.Any(
					outerGrad => Item2.grads.Any(
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

		public bool be(cycle_.Polygon4dblI Item1, cycle_.Polygon4dblI Item2)
		{
			return re(Item1, Item2);
		}

		public bool be(Co4dbl obj)
		{
			return	be(obj.Item1,obj.Item2);
		}

		public bool be(zone_.Polygon4dblI component, zone_.Polygon4dblI component1)
		{
			return be(
				new cycle_.Polygon4dbl(component.vertexes)
				,
				new cycle_.Polygon4dbl(component1.vertexes)

			);

		}


		static public Disjoint4dbl Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<Disjoint4dbl>.Instance;
			}
		}

	}
}
