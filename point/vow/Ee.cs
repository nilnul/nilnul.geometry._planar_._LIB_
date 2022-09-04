using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.point.vow
{
	public class Ee<TVow>
		:
		nilnul.obj.vow.ee_.Defaultable<planar.PointI1, TVow>
		where TVow : planar.point.VowI, new()
	{
		public Ee(PointI1 val) : base(val)
		{
		}
	}
}
