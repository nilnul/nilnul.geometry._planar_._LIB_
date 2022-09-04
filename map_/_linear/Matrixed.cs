using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.map_._linear
{
	/// <summary>
	/// the matrix is a row*2 matrix, where row may be:
	///		=1
	///			mapped to linear axis
	///		=2
	///			mapped  to the same plane
	///		=0
	///			mapped to nil-dimensional (trivia) space: a singluar point
	///	row greater than 2 is not processed here, but in higher dimensions which is an extension on this library.
	/// </summary>
	interface IMatrix
	{
	}
}
