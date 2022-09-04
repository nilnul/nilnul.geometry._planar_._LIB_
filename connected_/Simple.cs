using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.connected_
{
	/// <summary>
	/// imaging an elastic point,
	/// we can expand the point without tearing it, or glueing it.
	/// 
	/// The result would be:
	/// a point (which is 0d simple),
	/// <see cref="trail_.Simple"/>, which is 1d simple, also 0d simple
	/// or
	/// ,<see cref="surface_.ISimple"/>
	/// 
	/// </summary>
	/// <remarks>
	///
	/// </remarks>
	public interface ISimple:ITract
	{
	}
}
