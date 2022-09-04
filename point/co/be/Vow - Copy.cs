using nilnul.obj.be.vow_.xpN_._fail;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.point.co.be
{
	[Obsolete()]
	public class VowDbl<TBe> :
		nilnul.obj.be.vow_.xpN_.Fail<planar.point.CoD, TBe>
		,
		planar.point.co.IVowD
		where TBe : point.co._be_.IOfD
	{
		public VowDbl(TBe be) : base(be)
		{
		}

		public VowDbl(TBe be, FailException<CoD, TBe> xpn) : base(be, xpn)
		{
		}

		public VowDbl(TBe be, string msg) : base(be, msg)
		{
		}
	}
}
