using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.cycle_.trigon.cevian.theorem_
{
	/// <summary>
	/// given a splitter that is from a vertex,A, to a point on the opposite edge, M.
	/// b^2 *|BM| + c^2 *|CM|
	/// = a*( |AM|^2 + |BM|*|CM|)
	/// where b is the edge opposte to B, c is the edge opposite to C. M is a point at edge BC.
	/// </summary>
	/// <remarks>
	/// put in other ways:
	///		let ABC be colinear points at a <see cref="planar.ILead"/>,
	///		and P is any point,
	///	then
	///		|PA|^2 * BC + |PB|^2 *CA + |PC|^2 *AB + AB * BC *CA =0
	///	where BC, etc, means a <see cref="geometry.linear.grad.Displace"/>, that is it's a signed distance, on condition that line ABC is oriented.
	///
	///  This can be proved using <see cref="zone_.trigon.theorem_.Cosine"/>, by multiplying each <see cref="zone_.trigon.theorem_.Cosine"/> with the corresponding coef.
	/// </remarks>
	 class Stewart
	{

	}
}
