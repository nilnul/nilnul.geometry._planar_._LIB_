using nilnul.obj.be.vow_.xpN_._fail;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.point.twin.be.vow_
{
	public class BeDefaultD<TBe>
		:
		planar.point.twin.be.VowD<TBe>
		where TBe : point.twin.IBeD, new()
	{
		public BeDefaultD() : base(nilnul.obj_.Singleton<TBe>.Instance)
		{
		}

		public BeDefaultD( FailException<TwinD, TBe> xpn) : base(nilnul.obj_.Singleton<TBe>.Instance, xpn)
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
