using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.crux_
{
	/// <summary>
	/// there is no hole.
	/// eg:
	///		<see cref="planar.ISwath"/>
	///		<see cref="splash_."/>
	/// imaging an elastic point,
	/// we can expand the point without tearing it, or glueing it.
	/// 
	/// The result would be:
	/// a point (which is 0d simple),
	/// <see cref="trail_.Simple"/>, which is 1d simple, also 0d simple
	/// or
	/// ,<see cref="surface_.ISimple"/>
	/// or
	///		a rect with a tail (a <see cref="planar.tend_.IEdge"/>)
	/// </summary>
	/// <remarks>
	///
	/// </remarks>
	public interface ISimple:ICrux
	{
	}
}
