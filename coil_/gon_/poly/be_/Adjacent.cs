using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.coil_.gon_.poly.be_
{
	/// <summary>
	/// two edges might be incident such that two cycles might be adjacent.
	///		when the two edges are in the same direction, the two adjacent cycle wind into the same direction and their stokes surrounded is of the same sign.
	///		when the two edges are in the opposite direction, the two adjacent cycles wind to opposite direction. The two cycles' surrounded stokes is of the opposite sign.
	///		
	/// The two edges' endpoint might be not incident; the two edge might be staggered.
	/// </summary>
	public interface IAdjacent
	{
	}
}
