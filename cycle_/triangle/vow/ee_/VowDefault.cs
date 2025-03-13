using nilnul.obj;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.cycle_.triangle.vow.ee_
{
	public class VowDefault<TVow>
		:
		planar.cycle_.triangle.vow.Ee4dbl<TVow>

		where TVow : triangle.Vow4dblI, new()
	{
		public VowDefault(TriangleDbl val) : base(val, _obj.typ_.nilable_.unprimable_.singleton_.ByLazy<TVow>.Instance)
		{

		}
	}
}
