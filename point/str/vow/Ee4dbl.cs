using nilnul.obj;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.point.str.vow
{
	public class Ee4dbl<TVow> : nilnul.obj.vow.Ee1<IEnumerable<planar.Point4dblI>, TVow>
		where TVow : nilnul.obj.VowI2<IEnumerable<planar.Point4dblI>>
	{
		public Ee4dbl(IEnumerable<planar.Point4dblI> val, TVow vow) : base(val, vow)
		{
		}
	}
	public class Ee4dbl : Ee4dbl<
		nilnul.obj.VowI2<IEnumerable<planar.Point4dblI>>
	>

	{
		public Ee4dbl(IEnumerable<Point4dblI> val, VowI2<IEnumerable<Point4dblI>> vow) : base(val, vow)
		{
		}
	}

}
