using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar._morph_
{
	/// <summary>
	/// alias:transform.
	/// a special map:
	///		the target is 2d as well, whileas map can have target of any number of dimension
	/// </summary>
	public interface OfCoord4DblI

	{
		(double, double) morph(double x, double y);
	}
}
