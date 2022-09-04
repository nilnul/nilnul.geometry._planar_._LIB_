using nilnul.num.real_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.linear_._measured.unit_
{
	public class Kilo
		: UnitA
	{
		public Kilo() : base(
			1000 
		)
		{
		}


		static public Kilo Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<Kilo>.Instance;
			}
		}

		public override string ToString()
		{
			return "km";
		}


	}
}
