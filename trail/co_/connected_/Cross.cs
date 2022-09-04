using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.trail.co_.connected_
{
	/// <summary>
	/// A "+" is not homeomorphic to a line segment, since deleting the center point from the "+" gives a space with four components(i.e.pieces), whereas deleting a point from a line segment gives a space with at most two pieces;
	/// </summary>
	public interface ICross:IConnected
	{
	}
}
