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
	public class Chi:ChnI
	{
		/// <summary>
		/// </summary>
		public const string InCn = "尺";

		public PositiveI magnitude => new nilnul.num.real_.Positive(
			new nilnul.num.real_.Quotient(1,3)
		);



		static public Chi Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<Chi>.Instance;
			}
		}


	}
}
