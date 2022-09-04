using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.dimed
{
	/// <summary>
	/// suppose the k + 1 points in  {R} ^{k}, are affinely independent, which means  u_{1}-u_{0},... ,,u_{k}-u_{0}} are linearly independent. Then, the simplex determined by them is the set of points linearly combination of them.
	/// 
	/// a k-simplex is a k-dimensional polytope which is the convex hull of its k + 1 vertices
	/// </summary>
	/// a 0-simplex is a point,
	///a 1-simplex is a line segment,
	///a 2-simplex is a triangle,
	///a 3-simplex is a tetrahedron,
	public interface ISimplex
	{
	}
}
