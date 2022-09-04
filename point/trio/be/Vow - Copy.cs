using nilnul.obj.be.vow_.xpN_._fail;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.point.trio.be
{
	public class VowD<TBe>
		: nilnul.obj.be.vow_.xpN_.Fail<TrioD, TBe>
		,
		planar.point.trio.IVowD
		where TBe : planar.point.trio.BeDblI
	{
		public VowD(TBe be) : base(be)
		{
		}

		public VowD(TBe be, FailException<TrioD, TBe> xpn) : base(be, xpn)
		{
		}

		public VowD(TBe be, string msg) : base(be, msg)
		{
		}
	}
}
