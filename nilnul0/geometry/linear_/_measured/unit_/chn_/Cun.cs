using nilnul.num;
using nilnul.num.real_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.linear_._measured.unit_.chn_
{
	/// <summary>
	/// 
	/// </summary>
	public class Cun:ChnI
	{
		/// <summary>
		/// or 市寸
		/// </summary>
		public const string InCn = "寸";

		public PositiveI magnitude => new nilnul.num.real_.Positive(
		Chi.Singleton.magnitude.real.en.ToReal() /10
		);
	}
}
