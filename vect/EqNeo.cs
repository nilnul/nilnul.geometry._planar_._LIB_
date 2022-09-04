using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.vect
{
	public class Eq4dbl
		:
		nilnul.obj.eq_.homo_.EqDefault<Vect4dblI, Point4dblI, planar.point.EqDbl>
		,
		IEqualityComparer<
			Vect4dblI
		>
	{
		public Eq4dbl() : base(v=>v.point)
		{
		}

		static public Eq4dbl Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<Eq4dbl>.Instance;
			}
		}


	}
}
