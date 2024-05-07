using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.point.op_.unary_.rotate_
{
	/// <summary>
	/// 
	/// </summary>
	public class _QuarterX
	{
		/// <summary>
		/// </summary>
		/// <param name="x"></param>
		/// <returns></returns>
		static public (double,double) Op(
			 double x,double y
		){
			return (-y, x);
		}

		static public nilnul.geometry.planar.Point4dbl Op_retClass(
			nilnul.geometry.planar.Point4dblI x
		){
			return new nilnul.geometry.planar.Point4dbl( Op(x.x, x.y) );
		}





	}
}
