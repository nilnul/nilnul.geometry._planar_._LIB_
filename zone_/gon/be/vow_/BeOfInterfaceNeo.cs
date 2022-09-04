using nilnul.obj;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.zone_.gon.be.vow_
{
	public class BeOfInterfaceNeo<TBe> :
		be.Vow4dbl_ofInterface
		where TBe: gon.Be4dblI,new()

	{
		public BeOfInterfaceNeo() : base(
			 nilnul._obj.typ_.nilable_.unprimable_.singleton_.ByLazy<TBe>.Instance
		)
		{
		}


		static public BeOfInterfaceNeo<TBe> Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<BeOfInterfaceNeo<TBe>>.Instance;
			}
		}


	}
}
