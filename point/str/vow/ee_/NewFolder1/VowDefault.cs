using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.point.str_.seq.vow.ee_
{
	[Obsolete(nameof(str.vow.ee_))]
	public class VowDefault<TVow> : Ee<TVow>
		where TVow : str_.seq.VowI, new()
	{
		public VowDefault(str_.SeqI val) : base(val, nilnul.obj_.Singleton<TVow>.Instance)
		{
		}
	}
}
