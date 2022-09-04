using nilnul.obj.be.vow_.xpN_._fail;
using System;

namespace nilnul.geometry.planar.vect.be.vow_
{
	[Obsolete(nameof(BeNeo4Dbl<TBe>))]
	public class BeNeo<TBe>
		:
		Vow4dbl
		where TBe : planar.vect.Be4dblI, new()

	{
		public BeNeo() : base(
				 nilnul._obj.typ_.nilable_.unprimable_.singleton_.ByLazy<TBe>.Instance
				)
		{
		}


		static public BeNeo<TBe> Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<BeNeo<TBe>>.Instance;
			}
		}


	}
}
