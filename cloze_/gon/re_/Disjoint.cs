using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.cloze_.gon.re_
{
	/// <summary>
	/// some might be at the internal of the other
	/// </summary>
	public class Disjoint4dbl
		:
		nilnul.obj.ReA<cloze_.Polygon4dblI>
		,
		co.Be4dblI
	{
		public override bool re(Polygon4dblI Item1, Polygon4dblI Item2)
		{
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

		public bool be(cloze_.Polygon4dblI Item1, cloze_.Polygon4dblI Item2)
		{
			return re(Item1, Item2);
		}

		public bool be(Co4dbl obj)
		{
			return	be(obj.Item1,obj.Item2);
		}

		public bool be((Polygon4dblI, Polygon4dblI) obj)
		{
			return be(obj.Item1,obj.Item2);
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
