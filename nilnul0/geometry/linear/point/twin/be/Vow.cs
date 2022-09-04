using nilnul.obj.be.vow_.xpN_._fail;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.linear.point.twin.be
{
	public class Vow : nilnul.obj.be.vow_.xpN_.Fail<linear.point.Twin, linear.point.twin.BeI>
		,
		linear.point.twin.VowI
	{
		public Vow(BeI be) : base(be)
		{
		}

		public Vow(BeI be, FailException<Twin, BeI> xpn) : base(be, xpn)
		{
		}

		public Vow(BeI be, string msg) : base(be, msg)
		{
		}
	}
}
