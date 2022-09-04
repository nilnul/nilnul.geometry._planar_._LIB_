using nilnul.obj.be.vow_.xpN_._fail;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.point.co.be
{
	public class Vow<TBe> :
		nilnul.obj.be.vow_.xpN_.Fail<planar.point.Co, TBe>
		,
		planar.point.co.VowI
		where TBe : point.co.BeI
	{
		public Vow(TBe be) : base(be)
		{
		}

		public Vow(TBe be, FailException<Co, TBe> xpn) : base(be, xpn)
		{
		}

		public Vow(TBe be, string msg) : base(be, msg)
		{
		}
	}
}
