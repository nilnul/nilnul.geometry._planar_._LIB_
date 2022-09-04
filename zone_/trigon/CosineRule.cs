using System;
using System.Net;

namespace nilnul.geometry.planar.zone_.trigon
{
	public  class CosineLaw
	{
		/// <summary>
		/// three edges are known. compute the triagel opposite to a.
		/// </summary>
		/// <param name="a"></param>
		/// <param name="b"></param>
		/// <param name="c"></param>
		/// <returns></returns>
		public static double Angle(double opposite,double adjacent1,double adjacent2) {

			
			return Math.Acos((adjacent1 * adjacent1 + adjacent2 * adjacent2 - opposite * opposite)/(2.0*adjacent1*adjacent2));

		
		}

		public static double Hypotenuse(double adjacent1,double adjacent2) {
			return Math.Sqrt(adjacent1 * adjacent1 + adjacent2 * adjacent2);
		}


	}
}
