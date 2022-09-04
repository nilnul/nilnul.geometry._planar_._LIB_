using nilnul.obj.be.vow_.xpN_._fail;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.point.co.be.vow_
{
	[Obsolete()]
	public class BeDefaultDbl<TBe>
		:
		planar.point.co.be.VowDbl<TBe>
		where TBe : point.co._be_.IOfD, new()
	{
		public BeDefaultDbl() : base(nilnul.obj_.Singleton<TBe>.Instance)
		{
		}

		public BeDefaultDbl( FailException<CoD, TBe> xpn) : base(nilnul.obj_.Singleton<TBe>.Instance, xpn)
		{
		}

		public BeDefaultDbl( string msg) : base(nilnul.obj_.Singleton<TBe>.Instance, msg)
		{
		}

		static public BeDefaultDbl<TBe> Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<BeDefaultDbl<TBe>>.Instance;
			}
		}

	}
}
