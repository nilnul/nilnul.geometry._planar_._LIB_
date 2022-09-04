using nilnul.geometry.planar.point;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.curve_.polystep_.di.be_
{
	/// <summary>
	/// the order of the points is significant. the middle point is the nadir of the right angle.
	/// the direction of the outward ray (the last two points) is important such that the angle must be positive quarter, not negative quarter.
	/// </summary>
	public class Quarter4dbl : curve_.polystep_.di.Be4dblI
	{
		public bool be(polystep_.Di4dbl obj)
		{
			return 
				new nilnul.num.real.re_.approx_.Ratio(0.001).re(
					planar.grad_.skid.co._TurnX.Rotation(
						obj.ee.a
						,
						obj.ee.b
						,
						obj.ee.b
						,
						obj.ee.c
					)
					,
					nilnul.num.real_.TauX.QuarterD
				)

				//planar.vector_.nonnil.co._RotationX.Rotation(obj);
				;

			//throw new NotImplementedException();
		}


		static public Quarter4dbl Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<Quarter4dbl>.Instance;
			}
		}

	}
}
