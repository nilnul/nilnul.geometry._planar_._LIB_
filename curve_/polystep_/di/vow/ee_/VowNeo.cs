using nilnul.obj;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.curve_.polystep_.di.vow.ee_
{
	public class VowNeo<TVow>
		:
		vow.Ee4dbl
		where TVow : nilnul.obj.VowI2<polystep_.Di4dbl>, new()
	{
		public VowNeo(Di4dbl val) : base(val, 
				 nilnul._obj.typ_.nilable_.unprimable_.singleton_.ByLazy<TVow>.Instance
				)
		{
		}
	}
}
