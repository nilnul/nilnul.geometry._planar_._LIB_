using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.sub.fractal_
{
	/// <summary>
	/// for f: z => e^z +c, where z and c are complex numbers
	/// ,
	/// definea holomorphic dynamics or complex dynamics, (dynamic means, according to Holly Krieger, is a simple rule applied recursively)
	///		f(z0) = z1, f(z1) -> z2, etc,
	///			where z0 = 0,
	///		if the sequence has a limit, we call c is stable, and then c is a member of this set.
	/// </summary>
	interface IExponential:IFractal
	{


	}
}
