using nilnul.obj;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.zone_.trigon.be.vow_
{
	public class BeDefault4Dbl<TBe>
		: trigon.be.Vow4dbl
		where TBe : trigon.BeDoubleI, new()

	{
		public BeDefault4Dbl() : base(_obj.typ_.nilable_.unprimable_.singleton_.ByLazy<TBe>.Instance)
		{
		}

		
	}
}
