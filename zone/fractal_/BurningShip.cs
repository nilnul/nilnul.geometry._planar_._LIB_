using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.sub.fractal_
{
	/// <summary>
	/// for f: z =>  ( |Re(z)| +  |Im(z)|    )^2 +c
	///		let the recursion be :
	///			z[n+1] =f(z[n])
	///			and z[0]=0.
	///
	///  for any c that makes the recursion stable, the c is in the set.
	/// </summary>
	interface IBurningShip:IFractal
	{


	}
}
