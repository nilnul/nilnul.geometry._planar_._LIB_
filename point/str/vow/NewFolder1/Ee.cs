using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.point.str_.seq.vow
{
	[Obsolete(nameof(str.vow))]
	public class Ee<TVow> : nilnul.obj.vow.Ee1<planar.point.str_.SeqI, TVow>
		where TVow : planar.point.str_.seq.VowI
	{
		public Ee(str_.SeqI val, TVow vow) : base(val, vow)
		{
		}
	}
}
