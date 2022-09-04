using nilnul.obj.be.vow_.xpN_._fail;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.point.str_.seq.be
{
	[Obsolete()]
	public class Vow
		:
		nilnul.obj.be.vow_.xpN_.Fail<planar.point.str_.SeqI, planar.point.str_.seq.BeI>
		,planar.point.str_.seq.VowI
	{
		public Vow(BeI be) : base(be)
		{
		}

		public Vow(BeI be, FailException<str_.SeqI, BeI> xpn) : base(be, xpn)
		{
		}

		public Vow(BeI be, string msg) : base(be, msg)
		{
		}
	}
}
