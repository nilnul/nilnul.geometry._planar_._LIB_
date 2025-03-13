using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.cycle_.triangle.op_.unary_
{
	public class EnsureFacade :
		UnaryI
	{
		public Triangle4dblI op(Triangle4dblI par)
		{
			if (triangle.be_.Positive.Singleton.be(par))
			{
				return par;
			}
			return new TriangleDbl(
				par.vertexes.Reverse()
			);
		}


		static public EnsureFacade Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<EnsureFacade>.Instance;
			}
		}

	}
}
