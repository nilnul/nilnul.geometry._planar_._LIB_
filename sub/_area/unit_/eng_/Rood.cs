using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using qr = nilnul.num.real_;
using Qr = nilnul.num.real_.Quotient;
using Q = nilnul.num.Quotient1;
using R = nilnul.num.Real;
using nilnul.num;

namespace nilnul.geometry.planar._area.unit_.eng_
{
	public class Rood: UnitI
	{


		public static readonly Q AsPerchs = 40;


		public nilnul.num.Quotient1 _magInQuotient
		{
			get
			{
				return AsPerchs *nilnul.geometry.planar._area.unit_.eng_.Perch.Singleton._magInQuotient;
			}
		}

		
		public nilnul.num.real_.PositiveI magnitude
		{
			get
			{
				return new qr.Positive(
					AsPerchs *nilnul.geometry.planar._area.unit_.eng_.Perch.Singleton.magnitude.ToReal() );
			}
		}


		static public Rood Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<Rood>.Instance;
			}
		}


	}
}
