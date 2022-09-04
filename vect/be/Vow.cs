using nilnul.obj.be.vow_.xpN_._fail;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.vect.be
{
	public class Vow<TBe>
		: nilnul.obj.be.vow_.xpN_.Fail<planar.IVector, TBe>
		,
		planar.vect.VowI
		where TBe : planar.vect.BeI1
	{
		public Vow(TBe be) : base(be)
		{
		}

		public Vow(TBe be, FailException<IVector, TBe> xpn) : base(be, xpn)
		{
		}

		public Vow(TBe be, string msg) : base(be, msg)
		{
		}
	}

	public class Vow_beDefault<TBe> : Vow<TBe>
		where TBe : planar.vect.BeI1, new()

	{
		public Vow_beDefault() : base(nilnul.obj_.Singleton<TBe>.Instance)
		{
		}

		public Vow_beDefault( FailException<IVector, TBe> xpn) : base(nilnul.obj_.Singleton<TBe>.Instance, xpn)
		{
		}

		public Vow_beDefault(string msg) : base(nilnul.obj_.Singleton<TBe>.Instance, msg)
		{
		}

		static public Vow_beDefault<TBe> Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Vow_beDefault<TBe>>.Instance;
			}
		}

	}
}
