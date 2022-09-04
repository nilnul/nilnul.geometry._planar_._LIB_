using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.curve_.algebraics_.spline_
{
	/// <summary>
	/// 
	/// spline of order 1
	/// </summary>
	public interface ILinear
		:

		spline_.INatural	//linear equation can be solved by the two constraints from the two endian points. no other "unnatural" constraints needed
	{
	}
}
