using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace nilnul.geometry.planar.cloze_.gon.be_.surround_
{
	static public class _ProwindX
	{
		static public bool _Be_0started(
			IEnumerable<Complex> _started
		) {
			return gon._SurroundedX._Surround_0started(_started)>0;
		}

		public static bool _Be_0started(IEnumerable<Point4dblI> contour)
		{
			return _Be_0started(
				contour.Select( p=> new Complex(p.x,p.y))
			);
		}
	}


}
