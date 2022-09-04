using nilnul.num.real_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.linear_._measured.unit_
{
	public class Cent
		: UnitA
	{
		public Cent() : base(
			nilnul.num.Quotient1.CreateUnit(100) 
		)
		{
		}


		static public Cent Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<Cent>.Instance;
			}
		}


	}
}
