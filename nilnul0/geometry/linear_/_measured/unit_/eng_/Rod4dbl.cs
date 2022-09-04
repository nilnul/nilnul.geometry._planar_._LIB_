using nilnul.num.real_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.linear_._measured.unit_.eng_
{
	/// <summary>
	/// 
	/// </summary>
	/// Also called a perch or pole:
	public class Rod4dbl
		:
		unit_.EngAsInches4DblA
		,
		IEng
	{
		//public const double Meters_Per_This=Chain4dbl.Meters_Per_This / 4;

		public const int Inches_Per_Rod = 198;

		public Rod4dbl() : base(Inches_Per_Rod)
		{
		}


		static public Rod4dbl Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<Rod4dbl>.Instance;
			}
		}


	}
}
