using nilnul.obj;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.grad_.skid.vow.ee_
{
	public class VowDefault4Dbl<TVow>
		:
		nilnul.geometry.planar.grad_.skid.vow.Ee

		where TVow:
		VowI2<grad_.Skid4dblI>
		//geometry.planar.grad.Vow4dblI
		,
		new()
	{
		public VowDefault4Dbl(grad_.Skid4dblI val)
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
