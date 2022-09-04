using nilnul.num.real_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.linear_._measured.unit_
{
	/// <summary>
	/// 十米亦称公丈（dekameter），是长度计量单位，是国际单位制之一，符号为dam。该长度单位在实际上的使用很少，少数的使用如在水文学中，测量重力位高度的工具。
	/// </summary>
	public class Deca
		: UnitA
	{
		/// <summary>
		/// </summary>
		public const string InCn = "十米";
		public Deca() : base(
			nilnul.num.Quotient1.CreateUnit(10)
		)
		{
		}


		static public Deca Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<Deca>.Instance;
			}
		}


	}
}
