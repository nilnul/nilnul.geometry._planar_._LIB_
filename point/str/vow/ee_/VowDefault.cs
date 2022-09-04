using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.point.str.vow.ee_
{
	public class VowDefault<TVow> : Ee
		where TVow : str.VowI, new()
	{
		public VowDefault(IEnumerable<PointI1> val) : base(
			val
			, 
			 nilnul._obj.typ_.nilable_.unprimable_.singleton_.ByLazy<TVow>.Instance
		)
		{
		}
	}
}
