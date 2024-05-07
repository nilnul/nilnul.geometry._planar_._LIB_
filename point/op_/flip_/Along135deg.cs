using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.point.op_.unary_.flip_
{
	/// <summary>
	/// 
	/// </summary>
	static public class _Along135degX
	{
		/// <summary>
		/// </summary>
		/// <param name="x"></param>
		/// <returns></returns>
		static public (double,double) Op(
			 double x,double y
		){
			return(-y, -x);
		}

		static public nilnul.geometry.planar.Point4dbl Op_retClass(
			nilnul.geometry.planar.Point4dblI x
		){
			return new Point4dbl(
				Op(x.x,x.y)
			);
		}





	}
}
