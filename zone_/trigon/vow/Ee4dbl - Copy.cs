using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.zone_.trigon.vow
{
	public class EeDouble<TVow> :
		nilnul.obj.vow.ee_.Defaultable<planar.zone_.TriangleDbl, TVow>
		where TVow : trigon.Vow4dblI, new()
	{
		public EeDouble(TriangleDbl val) : base(val)
		{
		}
	}
}
