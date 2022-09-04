using nilnul.num.real_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.linear_._measured.unit_
{
	public class Centimeter4dbl
		: Unit4dblA
	{
		public Centimeter4dbl() : base(
			0.01 
		)
		{
		}


		static public Centimeter4dbl Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<Centimeter4dbl>.Instance;
			}
		}


	}
}
