using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.drawable
{

	/// <summary>
	/// given an vect, return a point, x,  that is furthest.
	/// in other words, x . vect is the biggest.
	/// there mighbe be multiple points satisfying such condition.
	/// </summary>
	interface SupportFuncI
	//:obj.BoxRef<IConvex>

	{


		/// <param name="support"></param>
		/// <returns></returns>
		planar.Point4dblI op(
			geometry.planar.Vect4dblI support
		);
	}
}
