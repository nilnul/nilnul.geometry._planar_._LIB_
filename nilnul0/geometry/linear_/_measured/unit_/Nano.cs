using nilnul.num.real_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.linear_._measured.unit_
{
	/// <summary>
	/// </summary>
	public class Nano
		: UnitA
	{
			/// <summary>
			/// </summary>
		public const string InCn = "纳米";
		public Nano() : base(
			nilnul.num.Quotient1.CreateUnit(1000_000_000) 
		)
		{
		}



		static public Nano Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<Nano>.Instance;
			}
		}


	}
}
