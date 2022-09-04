using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Point1 = nilnul.geometry.planar.Point4dbl;

using R = nilnul.num.RealI;


namespace nilnul.geometry.planar.point.re_
{
	/// <summary>
	/// </summary>
	public class Unapprox4dbl
		:
		nilnul.obj.re.complement_.ReDefault<
			Point4dblI,Approx4dbl
		>
		,
		point.Re4dblI
	{
		static public Unapprox4dbl Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<Unapprox4dbl>.Instance;
			}
		}

	}
}
