using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.cycle_.gon.co_.pro1con.be_
{

	public class Donut4dbl
		:
		
		pro1con.Be4dblI
	{


		public bool re(
			planar.cycle_.gon_.Facade4dbl outer
			,
			planar.cycle_.gon_.Antiwise4dbl inner
		)
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

			return gon.co.be_.Disjoint4dbl.Singleton.re(
				outer,inner
			);

			//return !outer.grads.Any(
			//		outerGrad => inner.grads.Any(
			//			innerGrad =>
			//				planar.grad_.nonnil.re_.Cross4dbl.Singleton.re_assumeSteps(
			//					outerGrad
			//					,
			//					innerGrad
			//				)
			//		)
			//	)
			//;
			

		}



		public bool be(Pro1con4Dbl obj)
		{
			return re(
				obj.outer,obj.inner
			);
			

		}


		static public Donut4dbl Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<Donut4dbl>.Instance;
			}
		}

	}
}
