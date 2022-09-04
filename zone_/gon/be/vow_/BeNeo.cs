using nilnul.obj;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.zone_.gon.be.vow_
{
	public class BeNeo<TBe> :
		Vow4dbl
		where TBe: gon.BeOfClass4DblI,new()

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
