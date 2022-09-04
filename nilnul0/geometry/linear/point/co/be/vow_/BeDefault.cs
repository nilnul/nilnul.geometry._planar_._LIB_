using nilnul.obj.be.vow_.xpN_._fail;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.linear.point.co.be.vow_
{
	public class BeDefault<TBe> : linear.point.co.be.Vow
		where TBe : linear.point.co.BeI, new()
	{
		public BeDefault() : base(nilnul.obj_.Singleton<TBe>.Instance)
		{
		}

		public BeDefault(FailException<Co, BeI> xpn) : base(nilnul.obj_.Singleton<TBe>.Instance, xpn)
		{
		}

		public BeDefault( string msg) : base(nilnul.obj_.Singleton<TBe>.Instance, msg)
		{
		}

		static public BeDefault<TBe> Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<BeDefault<TBe>>.Instance;
			}
		}

	}
}
