using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.point.re_
{
	public class Approx4dbl
		:
		point.Re4dblI
	{
		public bool re(Point4dblI a, Point4dblI b)
		{
			return nilnul.num.real.re_.approx_.ByInjected.Singleton.re(a.x, b.x)
				&&

				 nilnul.num.real.re_.approx_.ByInjected.Singleton.re(a.y, b.y)
;

		}


		static public Approx4dbl Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<Approx4dbl>.Instance;
			}
		}

	}
}
