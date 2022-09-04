using nilnul.obj;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.cycle_.gon_.antiwise.str.be.vow_
{
	public class BeNeo<TBe>
		: be.Vow
		where TBe : nilnul.obj.BeI1<
			IEnumerable<cycle_.gon_.Antiwise4dbl>
		>, new()
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
