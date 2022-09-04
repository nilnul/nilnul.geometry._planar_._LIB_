using nilnul.obj;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.zone_.gon.vow.ee_
{
	public class VowNeo<TVow>
		:
		vow.Ee4dbl
		where TVow : gon.Vow4dblI, new()
	{
		public VowNeo(Polygon4dbl val) : base(val, _obj.typ_.nilable_.unprimable_.Singleton<TVow>.Instance)
		{
		}
	}
}
