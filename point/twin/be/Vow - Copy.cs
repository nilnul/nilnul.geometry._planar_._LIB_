using nilnul.obj.be.vow_.xpN_._fail;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.point.twin.be
{
	public class VowD<TBe> :
		nilnul.obj.be.vow_.xpN_.Fail<planar.point.TwinD, TBe>
		,
		point.twin.IVowD
		where TBe : point.twin.IBeD
	{
		public VowD(TBe be) : base(be)
		{
		}

		public VowD(TBe be, FailException<TwinD, TBe> xpn) : base(be, xpn)
		{
		}

		public VowD(TBe be, string msg) : base(be, msg)
		{
		}
	}
}
