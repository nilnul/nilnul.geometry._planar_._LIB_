using nilnul.obj;
using nilnul.obj.be.vow_.xpN_._fail;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.point.str.be
{
	public class Vow4dbl
		:
		nilnul.obj.be.Vow4<
			IEnumerable<Point4dblI>
		>
		, planar.point.str.Vow4dblI
	{
		public Vow4dbl(BeI1<IEnumerable<Point4dblI>> be) : base(be)
		{
		}

		public Vow4dbl(Predicate<IEnumerable<Point4dblI>> predicate) : base(predicate)
		{
		}

		public Vow4dbl(Func<IEnumerable<Point4dblI>, bool> func) : base(func)
		{
		}
	}
}
