using nilnul.obj.be.vow_.xpN_._fail;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.point.twin.be
{
	public class Vow<TBe> :
		nilnul.obj.be.vow_.xpN_.Fail<planar.point.Twin, TBe>
		,
		point.twin.VowI
		where TBe : point.twin.BeI
	{
		public Vow(TBe be) : base(be)
		{
		}

		public Vow(TBe be, FailException<Twin, TBe> xpn) : base(be, xpn)
		{
		}

		public Vow(TBe be, string msg) : base(be, msg)
		{
		}
	}
}
