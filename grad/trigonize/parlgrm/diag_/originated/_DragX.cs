using nilnul.geometry.planar.point;
using nilnul.geometry.planar.vect.co;
using nilnul.geometry.planar.vect.drag.co;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.grad.trigonize.parlgrm.diag_.originated
{
	/// <summary>
	///
	/// the signed area of the bounding box of the parlgram
	/// </summary>
	static public class _DragX
	{
		
		public static double Drag_01grad(Point4dblI point1, Point4dblI point2)
		{
			return (point1.x + point2.x) * (point1.y + point2.y);
		}

		public static double Drag_01grad(Vect4dbl v1, Vect4dbl v2)
		{
			return Drag_01grad(v1.point,v2.point);
		}


		public static double Drag_0grad(this CoD x)
		{
			return Drag_01grad(x.component,x.component1);
		}



	}
}
