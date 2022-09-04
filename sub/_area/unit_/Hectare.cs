using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using qr = nilnul.num.real_;
using Qr = nilnul.num.real_.Quotient;
using Q = nilnul.num.Quotient1;
using R = nilnul.num.Real;

namespace nilnul.geometry.planar._area.unit_
{
	/// <summary>
	/// 公顷
	/// </summary>
	public class Hectare: UnitI
	{
		public static readonly Q AS_AREs = 100;
		public nilnul.num.Quotient1 _magInQuotient {
			get {
				return( AS_AREs*Are.AsSqMeters );

			}
		}



		//public const double SquareMeters_per_Hectare = 100 * Are.SquareMeters_per_Are;
		public nilnul.num.real_.PositiveI magnitude
		{
			get
			{
				return new qr.Positive( AS_AREs*Are.AsSqMeters );
				//throw new NotImplementedException();
			}
		}

		public const string toStrCn = "公顷";
		public const string toStrEn = "hectare";


		static public Hectare Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Hectare>.Instance;
			}
		}

	}
}
