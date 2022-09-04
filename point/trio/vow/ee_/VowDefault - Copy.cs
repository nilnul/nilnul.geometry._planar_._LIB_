using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.point.trio.vow.ee_
{
	public class VowDefaultD<TVow>
		: planar.point.trio.vow.EeD<TVow>
		where TVow : planar.point.trio.IVowD, new()
	{
		public VowDefaultD(TrioD val) : base(val, nilnul.obj_.Singleton<TVow>.Instance)
		{
		}
	}
}
