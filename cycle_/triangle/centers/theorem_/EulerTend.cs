using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.cycle_.triangle.inners.theorem_
{
	/*
en.wikipedia.org/wiki/Euler_line

Euler showed in 1765 that in any triangle, the orthocenter, circumcenter and centroid are collinear
	 */
	/// <summary>
	/// 
	/// the orthocenter, circumcenter and centroid are collinear; <see cref="point.IsogonalConjugate"/>
	/// 
	/// </summary>
	/// <remarks>
	///the nine-point center, although it had not been defined in Euler's time, is also in that line;
	/// starting from circumcenter, to the centroid at distance 2t, then to the ninePoint center at 3t, then orthocenter at 6t.
	///
	///
	/// where 4t^2 = R^2 -1/9 * (a^2+ b^2+c^2), where R is the radius of circumradius, and a,b,c are the edge lengths;
	///  
	///In equilateral triangles, these four points coincide, but in any other triangle they are all distinct from each other, and the Euler line is determined by any two of them.
	///
	/// 
	/// </remarks>
	/// <see cref="cycle_.triangle.vsPoint_.inner_.IBrocard"/>
	internal class EulerTend
	{
	}
}
