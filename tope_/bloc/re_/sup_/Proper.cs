using nilnul.geometry.planar.zone_.bloc_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.tope_.bloc.re_.sup_
{
	public class Proper4dbl
		:
		bloc.Re4dblI
	{
		public bool re(Bloc4dbl_byBoundsI a, Bloc4dbl_byBoundsI b)
		{
			return nilnul.num.real.bound_.closed.re_.sup_.Proper.Singleton.re(
				a.boundX,b.boundX
			)
				&&
nilnul.num.real.bound_.closed.re_.sup_.Proper.Singleton.re(
				a.boundY,b.boundY
			)
				;
		}

		public bool re(Bloc4dbl_byBounds bloc, Bloc4dbl_byBounds subCandidate)
		{
			return re((Bloc4dbl_byBoundsI)bloc, (Bloc4dbl_byBoundsI)subCandidate);

		}

		static public Proper4dbl Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<Proper4dbl>.Instance;
			}
		}

	}
}
