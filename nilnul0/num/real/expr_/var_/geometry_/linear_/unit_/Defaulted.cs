using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.expr_.var_.geometry_.linear_.unit_
{
	public class Defaulted<T>
		:
nilnul.num.real.expr_.var_.geometry_.linear_.Unit<T>
		where T : nilnul.geometry.linear_._measured.UnitI, new()
	{
		public Defaulted() : base(

				 nilnul._obj.typ_.nilable_.unprimable_.singleton_.ByLazy<T>.Instance

		)
		{
		}


	}
}
