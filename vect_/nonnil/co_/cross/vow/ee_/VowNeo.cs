using nilnul.obj;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.vect_.nonnil.co_.cross.vow.ee_
{
	public class VowNeo4Dbl<TVow>
		:
		vow.Ee4dbl
		where TVow : co_.cross.Vow4dblI, new()
	{
		public VowNeo4Dbl(Cross4dbl val) : base(val,

				 nilnul._obj.typ_.nilable_.unprimable_.singleton_.ByLazy<TVow>.Instance

		)
		{

		}
	}
}
