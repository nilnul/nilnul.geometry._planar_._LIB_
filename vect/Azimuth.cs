using nilnul.geometry.planar.rotation_;
using nilnul.num;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.vect
{


	/// <summary>
	/// </summary>
	static public class _AzimuthX
	{

		/// <summary>
		/// </summary>
		/// <param name="x"></param>
		/// <param name="y"></param>
		/// <returns>
		/// 0, if both are nils
		/// </returns>
		static public double GtNegPiLePi(double x, double y)
		{
		/// todo: microsoft document is self-contradictory in whether the returned value includes -PI.
		/// I have submitted a PR to make it clear that negPi is not included.
			return Math.Atan2(y, x);



		}


		static public double GtNegPiLePi(Point4dbl p)
		{

			return GtNegPiLePi(p.x,p.y);

		}

		public static double GtNegPiLePi(Vect4dbl vect)
		{
			return GtNegPiLePi(vect.point);
			//throw new NotImplementedException();
		}

		static public double GtNegPiLePi(Point4dblI p)
		{

			return GtNegPiLePi(p.x,p.y);

		}


		static public double GtNegPiLePi(Vector4dblI p)
		{
			return GtNegPiLePi(p.point);
		}
		static public double GtNegPiLePi(VectorDbl p)
		{
			return GtNegPiLePi((Vector4dblI)p);
		}
	}
}
