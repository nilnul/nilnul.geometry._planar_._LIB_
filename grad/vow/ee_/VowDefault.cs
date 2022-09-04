using nilnul.obj;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.grad.vow.ee_
{
	public class VowDefault4Dbl<TVow>
		:
		nilnul.geometry.planar.grad.vow.Ee4dbl

		where TVow:
		VowI2<Grad4dbl_byPointsI>
		//geometry.planar.grad.Vow4dblI
		,
		new()
	{
		public VowDefault4Dbl(Grad4dbl_byPointsI val)
			:
			base(
			val
			,
			_obj.typ_.nilable_.unprimable_.singleton_.ByLazy<TVow>.Instance
		)
		{
		}
	}
}
