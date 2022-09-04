using nilnul.obj.be.vow_.xpN_._fail;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.rotation.be
{
	public class Vow
		: nilnul.obj.be.vow_.xpN_.Fail<planar.RotationI1, planar.rotation.BeI>
	{
		public Vow(BeI be) : base(be)
		{
		}

		public Vow(BeI be, FailException<RotationI1, BeI> xpn) : base(be, xpn)
		{
		}

		public Vow(BeI be, string msg) : base(be, msg)
		{
		}
	}
}
