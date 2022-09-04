using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.point.co.be_.sloped.vow
{


	public class EeDbl : point.co.vow.ee_.VowDefaultDbl<VowDbl>
	{


		static public double _GetSlope_assumeSloped(CoD _duo_sloped)
		{
			return _duo_sloped.verticalShift
				/
				_duo_sloped.horizonShift;
		}

		public EeDbl(CoD val) : base(val)
		{
		}



		static public double _Polate_assumeSloped(CoD _duo_sloped, double x)
		{

			return _duo_sloped.component.y
				+
				(x - _duo_sloped.component.x)
				*
				_GetSlope_assumeSloped(_duo_sloped)
			;

		}



	}
}
