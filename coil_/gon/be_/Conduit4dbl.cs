using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.coil_.gon.be_
{
	public class Conduit4dbl
		:
		gon.Be4dblI
	{
		public bool be(Gon4dbl obj)
		{
			return _Conduit4dblX._Be_assumeCoil(
				obj.vertexes
			);

		}

		public bool be(Gon4dblI obj)
		{
			return _Conduit4dblX._Be_assumeCoil(
				obj
				.vertexes
			);

		}

		static public Conduit4dbl Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<Conduit4dbl>.Instance;
			}
		}

	}
}
