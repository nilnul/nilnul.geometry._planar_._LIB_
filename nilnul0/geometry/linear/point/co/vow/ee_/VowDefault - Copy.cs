using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.linear.point.co.vow.ee_
{
	public class VowDefault4Dbl<TVow>
		: linear.point.co.vow.Ee4dbl
		where TVow:
		nilnul.obj.VowI2<point.CoDbl>
		//linear.point.co.Vow4dblI
		, new()
	{
		public VowDefault4Dbl(CoDbl val) : base(val, nilnul._obj.typ_.nilable_.unprimable_.singleton_.ByLazy<TVow>.Instance)
		{
		}
	}
}
