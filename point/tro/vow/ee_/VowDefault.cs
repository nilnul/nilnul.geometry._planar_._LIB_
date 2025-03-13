using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.point.trio.vow.ee_
{
	public class VowDefault<TVow>
		: planar.point.trio.vow.Ee<TVow>
		where TVow : planar.point.trio.VowI, new()
	{
		public VowDefault(Trio val) : base(val, nilnul.obj_.Singleton<TVow>.Instance)
		{
		}
	}
}
