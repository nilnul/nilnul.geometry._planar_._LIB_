using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.point.str.vow
{
	public class Ee<TVow> : nilnul.obj.vow.Ee1<IEnumerable<PointI1>, TVow>
		where TVow : planar.point.str.VowI
	{
		public Ee(IEnumerable<PointI1> val, TVow vow) : base(val, vow)
		{
		}
	}

	public class Ee : Ee<planar.point.str.VowI>
	{
		public Ee(IEnumerable<PointI1> val, VowI vow) : base(val, vow)
		{
		}
	}
}
