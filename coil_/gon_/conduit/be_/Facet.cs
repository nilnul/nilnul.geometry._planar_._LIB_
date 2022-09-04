using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.coil_.gon_.conduit.be_
{
	public class Facet4dbl
		:
		conduit.Be4dblI
	{
		public bool be(Conduit4dbl obj)
		{
			return _FacetX._Be_assumeConduit(obj.ee.vertexes.ToArray());
			//throw new NotImplementedException();
		}


		static public Facet4dbl Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<Facet4dbl>.Instance;
			}
		}

	}
}
