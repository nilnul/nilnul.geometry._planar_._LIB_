using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.zone_.trigon.vsPoint
{
	/// <summary>
	/// <see cref="cycle_.trigon.vsPoint.Barycentric"/>;
	/// find the coordinates in terms of the three edges;
	///
	/// p =a + p(b-a) + q(c-a)    , where (p,q) is the coords of points with respect to (b-a), (c-a) as the basis.
	///   = (1-p-q)a + pb+ qc
	/// </summary>
	/// alias:
	///		trilinears
	public interface IBarycentric
	{
	}
}
