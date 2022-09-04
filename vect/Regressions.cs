using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.vect
{
	static public class _RegressionsX
	{
		static public Vect4dbl ToNew(this Vector4dblI old) {
			return new Vect4dbl(
				old.point
			);
		}
	}
}
