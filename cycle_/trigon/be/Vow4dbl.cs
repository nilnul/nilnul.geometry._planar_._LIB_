using nilnul.obj;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.cycle_.trigon.be
{
	public class Vow4dbl
		:
		obj.be.Vow4<TriangleDbl>
		,
		planar.cycle_.trigon.Vow4dblI


	{
		public Vow4dbl(BeI1<TriangleDbl> be) : base(be)
		{
		}

		public Vow4dbl(Predicate<TriangleDbl> predicate) : base(predicate)
		{
		}

		public Vow4dbl(Func<TriangleDbl, bool> func) : base(func)
		{
		}
	}
}
