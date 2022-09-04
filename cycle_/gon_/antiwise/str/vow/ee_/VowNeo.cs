using nilnul.obj;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.cycle_.gon_.antiwise.str.vow.ee_
{
	public class VowNeo<TVow>
		:
		Ee4dbl
		where TVow :
		nilnul.obj.VowI2<
			IEnumerable<
				Antiwise4dbl
			>
		>, new()
	{
		public VowNeo(IEnumerable<Antiwise4dbl> val) : base(val,

				 nilnul._obj.typ_.nilable_.unprimable_.singleton_.ByLazy<TVow>.Instance

			)
		{
		}
	}
}
