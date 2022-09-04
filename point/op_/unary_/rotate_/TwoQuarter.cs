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
	public class _PiX
	{
		/// <summary>
		/// </summary>
		/// <param name="x"></param>
		/// <returns></returns>
		static public (double,double) Op(
			 double x,double y
		){
			return nilnul.geometry.planar.vect_.polar.op_.unary_.rotate_._ByPiX.Op(x,y);
		}

		static public nilnul.geometry.planar.Point4dbl Op_retClass(
			nilnul.geometry.planar.Point4dblI x
		){
			return new nilnul.geometry.planar.Point4dbl( Op(x.x, x.y) );
		}





	}
}
