using nilnul.obj;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.point.str.vow.ee_
{
	public class VowNeo4Dbl<TVow> : Ee4dbl
		where TVow :
		nilnul.obj.VowI2<IEnumerable<planar.Point4dblI>>,
		new()
	{
		public VowNeo4Dbl(
			IEnumerable<Point4dblI> val
		) : base(
			val
			, 
			 nilnul._obj.typ_.nilable_.unprimable_.singleton_.ByLazy<TVow>.Instance
		)
		{
		}
	}
}
