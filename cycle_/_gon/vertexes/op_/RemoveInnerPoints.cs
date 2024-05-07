using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.cycle_._gon.vertexes.op_
{
	/// <summary>
	/// if a vertex is inner of an edge (that is, the angle here is halfTau), it shall be removed.
	/// eg:
	///		a---->----b---->---c, where b shall be removed
	/// </summary>
	/// <remarks>
	/// c-----<----a---<---->---b, that a2b2c is disallowed by <see cref="ICycle"/>
	/// </remarks>
	internal class RemoveInnerPoints
	{
	}
}
