using nilnul.obj.be.vow_.xpN_._fail;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.point.trio.be.vow_
{
	public class BeDefaultD<TBe>
		: VowD<TBe>
		where TBe : planar.point.trio.BeDblI, new()

	{
		public BeDefaultD() : base(nilnul.obj_.Singleton<TBe>.Instance)
		{
		}

		public BeDefaultD( FailException<TrioD, TBe> xpn) : base(nilnul.obj_.Singleton<TBe>.Instance, xpn)
		{
		}

		public BeDefaultD( string msg) : base(nilnul.obj_.Singleton<TBe>.Instance, msg)
		{
		}

		static public BeDefaultD<TBe> Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<BeDefaultD<TBe>>.Instance;
			}
		}

	}
}
