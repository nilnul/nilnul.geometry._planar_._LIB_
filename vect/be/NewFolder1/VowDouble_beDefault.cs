using nilnul.obj.be.vow_.xpN_._fail;
using System;

namespace nilnul.geometry.planar.vect.be
{
	[Obsolete(nameof(vect.be.vow_))]
	public class VowDouble_beDefault<TBe> : VowDouble<TBe>
		where TBe : planar.vect.BeOfDoubleI, new()

	{
		public VowDouble_beDefault() : base(nilnul.obj_.Singleton<TBe>.Instance)
		{
		}

		public VowDouble_beDefault( FailException<Vector4dblI, TBe> xpn) : base(nilnul.obj_.Singleton<TBe>.Instance, xpn)
		{
		}

		public VowDouble_beDefault(string msg) : base(nilnul.obj_.Singleton<TBe>.Instance, msg)
		{
		}

		static public VowDouble_beDefault<TBe> Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<VowDouble_beDefault<TBe>>.Instance;
			}
		}

	}
}
