using nilnul.obj;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.zone_.gon.be
{
	public class Vow4dbl
		:
		obj.be.Vow4<
			Polygon4dbl
		>
		,
		gon.Vow4dblI
	{
		public Vow4dbl(BeI1<Polygon4dbl> be) : base(be)
		{
		}

		public Vow4dbl(Predicate<Polygon4dbl> predicate) : base(predicate)
		{
		}

		public Vow4dbl(Func<Polygon4dbl, bool> func) : base(func)
		{
		}
	}
}
