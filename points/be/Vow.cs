using nilnul.obj;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.points.be
{
	public class VowDbl : nilnul.obj.be.Vow4<IEnumerable<Point4dbl>>
		,
		nilnul.geometry.planar.points.VowDblI
	{
		public VowDbl(BeI1<IEnumerable<Point4dbl>> be) : base(be)
		{
		}

		public VowDbl(Predicate<IEnumerable<Point4dbl>> predicate) : base(predicate)
		{
		}

		public VowDbl(Func<IEnumerable<Point4dbl>, bool> func) : base(func)
		{
		}
	}
}
