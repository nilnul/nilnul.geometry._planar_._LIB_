using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.tope_.bloc
{
	/// <summary>
	/// for a bloc, it has two fronts|edges to advance|expand its area.
	///		,like  d(x^2) /dx =2x, which is 2* linear
	/// for a 3d cube, it has three sides|facets to advance
	///		,like d (x^3) /dx =3 x^2, that means 3 * x^2, 
	/// for a grad on <see cref="nilnul.geometry.linear"/>,
	///		d x / dx =1 x^0, which is 1 point.
	///	for a point on <see cref="nilnul.geometry.original"/>
	///		d 1 / d x = 0, which is 0
	/// </summary>
	internal class Differential
	{
	}
}
