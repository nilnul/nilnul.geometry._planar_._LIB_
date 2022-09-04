using nilnul.obj;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.cycle_.gon_.antiwise.str.vow
{
	public class Ee4dbl<TVow>
		:
		nilnul.obj.str.vow.Ee1<
				cycle_.gon_.Antiwise4dbl 

		>
	where TVow : obj.VowI2<
IEnumerable<Antiwise4dbl>
	>
	{
		public Ee4dbl(IEnumerable<Antiwise4dbl> val, TVow vow) : base(val, vow)
		{
		}
	}
	public class Ee4dbl
		:
		Ee4dbl<
 obj.VowI2<IEnumerable<Antiwise4dbl>>
		>
	{
		public Ee4dbl(IEnumerable<Antiwise4dbl> val, VowI2<IEnumerable<Antiwise4dbl>> vow) : base(val, vow)
		{
		}
	}

}
