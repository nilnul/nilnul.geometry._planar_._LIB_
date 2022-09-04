using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.manifold_
{
	/// <summary>
	/// a cirlce can be charted to <see cref="manifold_.circ_.RealProjectiveLine"/>
	///  a cicle cannot be charted to a line.
	/// a cicle without a point can be charted to a line
	/// </summary>
	public interface ICirc:IManifold
	{
	}
}
