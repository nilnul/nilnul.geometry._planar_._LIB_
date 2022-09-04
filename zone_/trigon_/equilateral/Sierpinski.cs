using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.zone_.trigon_.equilateral
{
	/// <summary>
	/// a stream of zones, by repeated removing a trigon part (1/4 of the total area) from each triangle of the previous step.
	/// This is a fractal.
	/// </summary>
	/// <remarks>
	/// alias:
	///		Sierpinski sieve
	///		sierpinski fractal
	///		sierpinski triangle
	///		sierpinski gasket
	/// </remarks>
	 interface ISierpinskiGasket:IFractal
	{

	}
}
