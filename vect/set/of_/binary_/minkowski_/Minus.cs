using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.vect.set.op_.binary_.minkowski_
{
	public class Minus
		:
		Binary4dblI
	{
		public Set4dbl op(Set4dbl par, Set4dbl par1)
		{
			return new Set4dbl(
				par.SelectMany(a=> par1.Select(b=>(
					planar.vect.op_.binary_._MinusX.Op( a,b)
				)))
			);
			//throw new NotImplementedException();
		}

		static public Minus Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<Minus>.Instance;
			}
		}

	}
}
