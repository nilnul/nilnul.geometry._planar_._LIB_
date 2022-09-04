using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using qr = nilnul.num.real_;
using Qr = nilnul.num.real_.Quotient;
using Q = nilnul.num.Quotient1;
using R = nilnul.num.Real;
using RI = nilnul.num.RealI;
using nilnul.num;
using nilnul.num.real_;

namespace nilnul.geometry.planar._area.unit_.eng_
{

	public class Acre : UnitI
	{
		public const string STR_CN = "英亩";
		public const string STR_EN = "acre";

		//public const double SquareMeters_per_This = Chain.Meters_Per_This * Furlong.Meters_per_this;//22*220	
																								public const int SqYardsPerAcre = 4840;

		public static readonly Q AsRoods = 4;



		public nilnul.num.Quotient1 _magInQuotient
		{
			get
			{
				return
					AsRoods * nilnul.geometry.planar._area.unit_.eng_.Rood.Singleton._magInQuotient
				;
			}
		}

		public nilnul.num.real_.PositiveI magnitude
		{
			get
			{
				return new qr.Positive(
					AsRoods * nilnul.geometry.planar._area.unit_.eng_.Rood.Singleton.magnitude.ToReal()
				);
			}
		}



		static public Acre Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<Acre>.Instance;
			}
		}


	}
}
