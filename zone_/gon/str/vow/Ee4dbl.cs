using nilnul.obj;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.zone_.gon.str.vow
{
	public class Ee4dbl<TVow>
		:
		nilnul.obj.str.vow.Ee1<
				zone_.Polygon4dblI

		>
	where TVow : obj.VowI2<
IEnumerable<Polygon4dblI>
	>
	{
		public Ee4dbl(IEnumerable<Polygon4dblI> val, TVow vow) : base(val, vow)
		{
		}
	}
	public class Ee4dbl
		:
		Ee4dbl<
 obj.VowI2<IEnumerable<Polygon4dblI>>
		>
	{
		public Ee4dbl(IEnumerable<Polygon4dblI> val, VowI2<IEnumerable<Polygon4dblI>> vow) : base(val, vow)
		{
		}
	}

}
