using nilnul.obj;
using nilnul.obj.be.vow_.xpN_._fail;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.point.str.be
{
	public class Vow
		:
		nilnul.obj.be.Vow4<
			IEnumerable<PointI1>
		>
		,
		planar.point.str.VowI
	{
		public Vow(BeI1<IEnumerable<PointI1>> be) : base(be)
		{
		}

		public Vow(Predicate<IEnumerable<PointI1>> predicate) : base(predicate)
		{
		}

		public Vow(Func<IEnumerable<PointI1>, bool> func) : base(func)
		{
		}
	}
}
