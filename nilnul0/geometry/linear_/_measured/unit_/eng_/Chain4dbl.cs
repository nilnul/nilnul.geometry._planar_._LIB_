using nilnul.num.real_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.linear_._measured.unit_.eng_
{
	public class Chain4dbl
		:
		unit_.EngAsInches4DblA
		,
		IEng
	{

		public const int Rods_Per_This = 4;

		public Chain4dbl() : base(Rods_Per_This * Rod4dbl.Singleton.inches)
		{
		}


		static public Chain4dbl Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<Chain4dbl>.Instance;
			}
		}

	}
}
