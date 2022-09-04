using nilnul.num.real_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.linear_._measured.unit_
{
	/// <summary>
	/// micro meter
	/// </summary>
	public class Micro
		: UnitA
	{
			/// <summary>
			/// </summary>
		public const string InCn = "微米";
		public Micro() : base(
			nilnul.num.Quotient1.CreateUnit(1000_000) 
		)
		{
		}



		static public Micro Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<Micro>.Instance;
			}
		}


	}
}
