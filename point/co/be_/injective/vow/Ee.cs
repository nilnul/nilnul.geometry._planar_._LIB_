using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.point.co.be_.injective.vow
{
	/// <summary>
	/// </summary>
	


		public class EeDbl : point.co.vow.ee_.VowDefaultDbl<VowDbl>
	{
			public EeDbl(CoD val) : base(val)
			{
			}

			static public double _InterPolate__duoInjective_xWithin(
				Point4dbl x, 
				Point4dbl y
				,
				
				double _x_withinDuo)
			{

				return _InterPolate__duoInjective_xWithin(
					new CoD(x,y), _x_withinDuo	
				);

			}
			static public double _InterPolate__duoInjective_xWithin(CoD _duo_injective,  double _x_withinDuo)
			{

				if (ReflexiveD.Singleton.be(_duo_injective))
				{
					return _duo_injective.component.y;
				}


				return sloped.vow.EeDbl._Polate_assumeSloped(
					_duo_injective,
					_x_withinDuo
				);

			}



		
	}
}
