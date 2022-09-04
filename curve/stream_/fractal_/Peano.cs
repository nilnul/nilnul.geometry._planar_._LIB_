using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.curve.stream_.fractal_
{
	/// <summary>
	/// how to draw the initial curve for a square:
	/// -----------------------------------------------
	/// partion a square into 3*3 sub-squares.
	/// move from the center of lower-left subsquare upwards, and end at the upper-right subsquare.
	///=====================================================================
	/// recursion:
	///
	/// partition the square into 3*3 sub-squares.
	///   draw line for lower-left subsquare.
	///   going from previous subsquare to next by connecting adjacent subsquare center.
	///	========================================	
	///
	/// 
	/// </summary>
	/// <remarks>
	/// space filling.as per cantor, line is equipotent to plane.
	///
	/// </remarks>
	class Peano
	{
	}
}
