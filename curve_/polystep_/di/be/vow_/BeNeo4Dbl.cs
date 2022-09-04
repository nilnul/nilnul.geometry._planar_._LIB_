using nilnul.obj;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.curve_.polystep_.di.be.vow_
{
	public class BeNeo4Dbl<TBe>
		:
		be.Vow4dbl
		where TBe : nilnul.obj.BeI1<polystep_.Di4dbl>, new()
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
