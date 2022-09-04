using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.cycle_.gon.co.be_
{
	/// <summary>
	/// regard the gon as a curve, not an area. so the inner of the gon is not considered.
	/// some might be at the internal of the other
	/// </summary>
	public class Joint4dbl
		:
		nilnul.obj.ReA<cycle_.Polygon4dblI>
		,
		co.Be4dblI
	{
		public override bool re(Polygon4dblI Item1, Polygon4dblI Item2)
		{
			return		 Item1.grads.Any(
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


		static public Joint4dbl Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<Joint4dbl>.Instance;
			}
		}

	}
}
