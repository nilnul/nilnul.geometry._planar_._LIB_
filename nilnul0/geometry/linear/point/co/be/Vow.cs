using nilnul.obj.be.vow_.xpN_._fail;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.linear.point.co.be
{
	public class Vow<TBe>
		: nilnul.obj.be.vow_.xpN_.Fail<linear.point.Co, TBe>
		,
		linear.point.co.VowI
		where TBe : linear.point.co.BeI
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

	public class Vow : Vow<linear.point.co.BeI>
	{
		public Vow(BeI be) : base(be)
		{
		}

		public Vow(BeI be, FailException<Co, BeI> xpn) : base(be, xpn)
		{
		}

		public Vow(BeI be, string msg) : base(be, msg)
		{
		}
	}
}
