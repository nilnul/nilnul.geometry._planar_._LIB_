using nilnul.num.real_;
using System;

namespace nilnul.geometry.linear_._measured.unit_
{
	public class Km4dbl : Unit4dblI
	{

		public const double MetersPerKm = 1000;

		public PositiveDblI magnitude => new PositiveDbl(MetersPerKm);

		public override string ToString()
		{
			return "km";
		}

	

		static public Km4dbl Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<Km4dbl>.Instance;
			}
		}

	}
}
