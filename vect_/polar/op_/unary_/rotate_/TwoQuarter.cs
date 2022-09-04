using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.vect_.polar.op_.unary_.rotate_
{
	/// <summary>
	/// 
	/// </summary>
	static public class _ByPiX
	{
		/// <summary>
		/// first, (x,y) => r(cos(a) + i *sin(a)
		/// then,
		///  r ( cos(a) + i*sin(a) ) * ( cos(-pi/2), i * sin(-pi/2) )
		///  = r ( cos(a+pi)  + i * sin(a+pi) )
		///  = r ( -cos(a) - i* sin(a) )
		///  = -x, -y
		/// </summary>
		/// <param name="x"></param>
		/// <returns></returns>
		static public (double,double) Op(
			 double x,double y
		){
			return (-x, -y);
		}

		static public nilnul.geometry.planar.Point4dbl Op_retClass(
			nilnul.geometry.planar.Point4dblI x
		){
			return new nilnul.geometry.planar.Point4dbl( Op(x.x, x.y) );
		}





	}
}
