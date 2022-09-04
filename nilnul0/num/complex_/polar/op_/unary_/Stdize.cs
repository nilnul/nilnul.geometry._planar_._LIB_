using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.complex_.polar.op_.unary_
{
	public class Std
		: UnaryI
	{

		public Polar op(Polar par)
		{
			par.normalize();
			return par;

		}


		static public Std Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<Std>.Instance;
			}
		}

	}
}
