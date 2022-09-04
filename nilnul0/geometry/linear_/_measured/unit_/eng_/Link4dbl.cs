
using nilnul.num.real_;
using System;

namespace nilnul.geometry.linear_._measured.unit_.eng_
{
	public class Link4dbl
		:
		unit_.EngAsInches4DblA
	{


		public const int THESE_PER_CHAIN = 100;
		public Link4dbl() : base( Chain4dbl.Singleton.inches /100)
		{
		}


		static public Link4dbl Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<Link4dbl>.Instance;
			}
		}

	}
}
