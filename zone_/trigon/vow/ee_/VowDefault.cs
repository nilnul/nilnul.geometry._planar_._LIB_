using nilnul.obj;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.zone_.trigon.vow.ee_
{
	public class VowDefault<TVow>
		:
		planar.zone_.trigon.vow.Ee4dbl<TVow>

		where TVow : trigon.Vow4dblI, new()
	{
		public VowDefault(TriangleDbl val) : base(val, _obj.typ_.nilable_.unprimable_.singleton_.ByLazy<TVow>.Instance)
		{

		}
	}
}
