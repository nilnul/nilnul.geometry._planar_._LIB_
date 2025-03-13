using nilnul.obj.be.vow_.xpN_._fail;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.point.trio.be
{
	public class Vow<TBe>
		: nilnul.obj.be.vow_.xpN_.Fail<Trio, TBe>
		,
		planar.point.trio.VowI
		where TBe : planar.point.trio.BeI
	{
		public Vow(TBe be) : base(be)
		{
		}

		public Vow(TBe be, FailException<Trio, TBe> xpn) : base(be, xpn)
		{
		}

		public Vow(TBe be, string msg) : base(be, msg)
		{
		}
	}
}
