using nilnul.num.real_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.linear_._measured.unit_
{
	public class Deci
		: UnitA
	{
	/// <summary>
	/// 台湾作公寸
	/// </summary>
		public const string InCn = "分米";
		public Deci() : base(
			nilnul.num.Quotient1.CreateUnit(10) 
		)
		{
		}


		static public Deci Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<Deci>.Instance;
			}
		}


	}
}
