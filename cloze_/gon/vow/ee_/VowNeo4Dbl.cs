using nilnul.obj;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.cloze_.gon.vow.ee_
{
	public class VowNeo4Dbl<TVow>
		:
		nilnul.geometry.planar.cloze_.gon.vow.Ee4dbl

		where TVow:
		VowI2<cloze_.Polygon4dblI>
		,
		new()
	{
		public VowNeo4Dbl(cloze_.Polygon4dblI val)
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
