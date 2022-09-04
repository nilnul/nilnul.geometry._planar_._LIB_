using nilnul.num.real_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.linear_._measured.unit_
{
	/// <summary>
	///公引，又称粨（英式英文：hectometre、美式英文：hectometer，记号hm）是国际单位制之一，为“百”和“米”的合字，即100米；此单位现已较少使用，曾较常用于度量道路、桥梁、铁路。
	/// 
	/// </summary>
	public class Hecto
		: UnitA
	{
		/// <summary>
		/// </summary>
		public const string InCn = "粨";
		public Hecto() : base(
			nilnul.num.Quotient1.CreateUnit(100)
		)
		{
		}


		static public Hecto Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<Hecto>.Instance;
			}
		}


	}
}
