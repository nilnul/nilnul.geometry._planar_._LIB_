using nilnul.obj;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.points.vow
{
	public class Ee : nilnul.obj.vow.Ee1<IEnumerable<Point4dbl>>
	{
		public Ee(IEnumerable<Point4dbl> val, VowI2<IEnumerable<Point4dbl>> vow) : base(val, vow)
		{
		}
	}
}
