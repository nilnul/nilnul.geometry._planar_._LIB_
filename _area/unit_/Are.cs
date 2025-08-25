using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using qr = nilnul.num.real_;
using Qr = nilnul.num.real_.Quotient;
using Q = nilnul.num.Quotient1;
using R = nilnul.num.real_.PositiveI;
namespace nilnul.geometry.planar._area.unit_
{
	/// <summary>
	///  100 square meters (about 119.6 square yards).公亩（are）是面积的单位，定义为100平方米，相当于边长为10米的正方形面积。
	/// </summary>
	public class Are: UnitI
	{


		public static readonly Q AsSqMeters = 100; 
		public R magnitude
		{
			get
			{
				return new nilnul.num.real_.Positive( AsSqMeters );
			}
		}

		static public Are Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Are>.Instance;
			}
		}


	}
}
