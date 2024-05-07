using nilnul.num.real_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.linear_._measured.unit_
{
	public class Milli4dbl
		: Unit4dblA
	{
		public Milli4dbl() : base(
			0.001 
		)
		{
		}


		static public Milli4dbl Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<Milli4dbl>.Instance;
			}
		}


	}
}
