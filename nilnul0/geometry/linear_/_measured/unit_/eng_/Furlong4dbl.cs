using nilnul.num.real_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.geometry.linear_._measured.unit_.eng_
{
	public class Furlong4dbl
		:
		unit_.EngAsInches4DblA
		,
		IEng
	{

		public const int Chains_Per_This = 10;

	

		public Furlong4dbl() : base(Chains_Per_This*Chain4dbl.Singleton.inches)
		{
		}


		static public Furlong4dbl Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<Furlong4dbl>.Instance;
			}
		}

	}
}
