using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.sub_.fractal
{
	/// <summary>
	/// like mass, the fractal can be measured.
	/// when it's scaled <var>s</var> times, the measue scaled <var>m</var> times; then s^d=m, and d=log(s,m)= ln(m) / ln(s) , where d is understood as dimension.
	/// for eg:
	///   for point,
	///		scale: 2
	///		mass: 1
	///			so measuere= ln(1) / ln(2) =0
	///	 for line segment,
	///		scale:2
	///		mass:2
	///			measure = ln(2) /ln(2) =1.
	///	for square
	///		measure = ln(4)/ln(2) =2.
	///		
	/// </summary>
	class Measure
	{
	}
}
