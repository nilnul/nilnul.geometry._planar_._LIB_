using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.complex.of_.real_
{
	/// <summary>
	///  the curve is not self intersecting; but it can be a <see cref="geometry.planar.ICycle"/>, where the curve ends before the start point;
	///  eg:
	///		y=x
	///		z= E(t) where t is in [0,Tau)
	///	excluding:
	///		<see cref="geometry.planar.coil_.INonSimple"/>
	/// </summary>
	public interface IInjective
	{
	}
}
