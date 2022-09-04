using nilnul.obj;
using nilnul.obj.be.vow_.xpN_._fail;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.grad_.skid.str.be.vow_
{
	public class BeNeo4Dbl<TBe> : planar.grad_.skid.str.be.Vow4dbl
		where TBe : planar.grad_.skid.str.Be4dblI, new()

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
