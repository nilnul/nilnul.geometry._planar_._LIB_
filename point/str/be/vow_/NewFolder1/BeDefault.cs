using nilnul.obj.be.vow_.xpN_._fail;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.point.str_.seq.be.vow_
{

	[Obsolete(nameof(str.be.vow_))]
	public class BeDefault<TBe> : planar.point.str_.seq.be.Vow
		where TBe : planar.point.str_.seq.BeI,new()

	{
		public BeDefault() : base(nilnul.obj_.Singleton<TBe>.Instance)
		{
		}

		public BeDefault( FailException<str_.SeqI, BeI> xpn) : base(nilnul.obj_.Singleton<TBe>.Instance, xpn)
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
