using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.geometry.planar
{
	/// <summary>
	/// en.wikipedia.org/wiki/Curve#Jordan
	/// A plane simple closed curve is also called a Jordan curve. It is also defined as a non-self-intersecting continuous loop in the plane.
	/// The Jordan curve theorem states that the set complement in a plane of a Jordan curve consists of two connected components (that is the curve divides the plane in two non-intersecting regions that are both connected).
	/// </summary>
	///
	[Obsolete(nameof(ILasso))]
	public interface ILap : orbit_.ISimple
	{
	}
}