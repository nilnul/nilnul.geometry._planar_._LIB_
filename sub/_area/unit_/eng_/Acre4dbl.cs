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
using nilnul.obj._measure._unit_;

namespace nilnul.geometry.planar.sub._area.unit_.eng_
{

	public class Acre4dbl
		:

		Unit4dblI
	{
		public const string STR_CN = "英亩";
		public const string STR_EN = "acre";

		public PositiveDblI magnitude => new PositiveDbl(
			linear_._measured.unit_.eng_.Chain4dbl.Singleton.magnitude.dblen.ee
			*
			linear_._measured.unit_.eng_.Furlong4dbl.Singleton.magnitude.dblen.ee
		);

		static public Acre4dbl Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<Acre4dbl>.Instance;
			}
		}

	}
}
