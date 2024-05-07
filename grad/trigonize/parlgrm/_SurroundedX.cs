using nilnul.geometry.planar.point;
using nilnul.geometry.planar.vect.co;
using nilnul.geometry.planar.vect.drag.co;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.grad.trigonize.parlgrm
{
	/// <summary>
	/// 
	/// </summary>
	/// <remarks>
	/// Note: this is not double the <see cref="grad._StokesX"/>
	/// </remarks>
	static public class _SurroundedX
	{
		public static double Surrounded(Complex point1, Complex point2)
		{
			return planar.vect.co.to_.real_._CrossProductX.SurroundedOfParallelogram(point1,point2);

		}
		
		public static double Surrounded(Point4dblI point1, Point4dblI point2)
		{
			return (point1.x - point2.x) * (point1.y + point2.y);
		}

		public static double Surrounded(Vect4dbl v1, Vect4dbl v2)
		{
			return Surrounded(v1.point,v2.point);
		}


		public static double Surrounded(this CoD x)
		{
			return Surrounded(x.component,x.component1);
		}





	}
}
