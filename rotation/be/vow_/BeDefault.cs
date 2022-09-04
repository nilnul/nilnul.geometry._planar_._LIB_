using nilnul.obj.be.vow_.xpN_._fail;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.rotation.be.vow_
{
	public class BeDefault<TBe>
		: planar.rotation.be.Vow
		where TBe : planar.rotation.BeI, new()
	{
		public BeDefault() : base(nilnul.obj_.Singleton<TBe>.Instance)
		{
		}

		public BeDefault( FailException<RotationI1, BeI> xpn) : base(nilnul.obj_.Singleton<TBe>.Instance, xpn)
		{
		}

		public BeDefault( string msg) : base(nilnul.obj_.Singleton<TBe>.Instance, msg)
		{
		}
	}
}
