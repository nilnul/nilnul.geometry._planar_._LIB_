using nilnul.obj;
using nilnul.obj.be.vow_.xpN_._fail;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.linear.point.co.be.vow_
{
	public class BeDefault4Dbl<TBe>
		:
		linear.point.co.be.Vow4dbl
		where TBe :
		nilnul.obj.BeI1<point.CoDbl>
		//linear.point.co.Be4dblI
		, new()
	{
		public BeDefault4Dbl()
			:
		base(
			nilnul._obj.typ_.nilable_.unprimable_.singleton_.ByLazy<TBe>.Instance
		)
		{
		}


		static public BeDefault4Dbl<TBe> Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<BeDefault4Dbl<TBe>>.Instance;
			}
		}

	}
}
