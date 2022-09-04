using nilnul.obj;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.zone_.gon.vow.ee_
{
	public class VowNeo_ofInterface<TVow>
		:
		vow.Ee4dbl_ofInterface
		where TVow : gon.Vow4dbl_ofInterfaceI, new()
	{
		public VowNeo_ofInterface(Polygon4dblI val) : base(val, _obj.typ_.nilable_.unprimable_.Singleton<TVow>.Instance)
		{
		}
	}
}
