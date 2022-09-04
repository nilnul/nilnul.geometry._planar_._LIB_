using nilnul.obj.be.vow_.xpN_._fail;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.vect.be
{
	[Obsolete(nameof(planar.vect.be.Vow4dbl))]
	public class VowDouble<TBe>
		: nilnul.obj.be.vow_.xpN_.Fail<planar.Vector4dblI, TBe>
		,
		planar.vect.VowDoubleI
		where TBe : planar.vect.BeOfDoubleI
	{
		public VowDouble(TBe be) : base(be)
		{
		}

		public VowDouble(TBe be, FailException<Vector4dblI, TBe> xpn) : base(be, xpn)
		{
		}

		public VowDouble(TBe be, string msg) : base(be, msg)
		{
		}
	}
}
