using nilnul.num.real_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.linear_._measured.unit_
{
	/// <summary>
	/// milli meter
	/// </summary>
	public class Mm1
		: UnitA
	{
			/// <summary>
			/// 公釐 in Taiwan
			/// </summary>
		public const string InCn = "毫米";
		public Mm1() : base(
			nilnul.num.Quotient1.CreateUnit(1000) 
		)
		{
		}



		static public Mm1 Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<Mm1>.Instance;
			}
		}


	}
}
