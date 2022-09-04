using nilnul.obj.be.vow_.xpN_._fail;

namespace nilnul.geometry.planar.vect.be.vow_
{
	public class BeNeo4Dbl<TBe>
		:
		Vow4dbl
		where TBe : planar.vect.Be4dblI, new()

	{
		public BeNeo4Dbl() : base(
				 nilnul._obj.typ_.nilable_.unprimable_.singleton_.ByLazy<TBe>.Instance
				)
		{
		}


		static public BeNeo4Dbl<TBe> Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<BeNeo4Dbl<TBe>>.Instance;
			}
		}


	}
}
