using nilnul.obj;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.points.vow.ee_
{
	public class VowDefault<TVow> : Ee
		where TVow : nilnul.obj.VowI2<IEnumerable<Point4dbl>>,new()
	{
		public VowDefault(IEnumerable<Point4dbl> val) : base(val, nilnul.obj_.Singleton<TVow>.Instance)
		{
		}

	}
}
