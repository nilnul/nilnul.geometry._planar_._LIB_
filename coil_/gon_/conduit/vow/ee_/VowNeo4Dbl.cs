using nilnul.obj;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.coil_.gon_.conduit.vow.ee_
{
	public class VowNeo4Dbl<TVow>
		:
		nilnul.geometry.planar.coil_.gon_.conduit.vow.Ee4dbl

		where TVow:
		VowI2<coil_.gon_.Conduit4dbl>
		,
		new()
	{
		public VowNeo4Dbl(coil_.gon_.Conduit4dbl val)
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
