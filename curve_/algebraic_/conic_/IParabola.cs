using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.curve_.algebraic_.conic_
{
	/// <summary>
	/// eg:
	///		x=y**2+y+1
	/// </summary>
	public interface IParabola:
		IConic
		,
		algebraic_.polynomial_.IQuadratic
	{
	}
}
