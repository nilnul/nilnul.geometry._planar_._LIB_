using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.point.vow
{
	public class EeDbl<TVow>
		:
		nilnul.obj.vow.ee_.Defaultable<planar.Point4dbl, TVow>
		where TVow : planar.point.VowDblI, new()
	{
		public EeDbl(Point4dbl val) : base(val)
		{
		}
	}
}
