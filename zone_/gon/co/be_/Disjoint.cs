using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.zone_.gon.co.be_
{
	public class Disjoint4dbl
		:
		nilnul.obj.ReA<zone_.Polygon4dblI>
		,
		co.Be4dblI
	{
		public override bool re(Polygon4dblI component, Polygon4dblI component1)
		{
			var disjoint = cycle_.gon.co.be_.Disjoint4dbl.Singleton.be(
				component
				,
				component1
			);

			if (!disjoint )
			{

				return false;
			}

			return cycle_.gon.co_.nonjoint.be_._Nondonut4dblX._Be_assumeNonjoint(
				component
				,
				component1
			);

		}

		public bool be(Co4dbl obj)
		{

			return re(
				obj.component
				,
				obj.component1
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
