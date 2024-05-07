using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.zone_.gon_.convex.co.be_.joint_
{
	/*
	 see: youtube.com/watch?v=ajv46BSqcK4
	 A Strange But Elegant Approach to a Surprisingly Hard Problem (GJK Algorithm)
	 * Reducible
	 * 
In 1988, three engineers came together and developed one of the most clever solutions to the problem of detecting when two complex objects collide. Their solution, the Gilbert Johnson Keerthi (GJK) algorithm, named after the authors, made an incredible impact in the fields of robotics, control, and computer graphics. This video is about understanding this ingenious algorithm from first principles.

The video covers a broad range of topics from Minkowski sums and differences to support functions to the full implementation of the 2D GJK algorithm. But what I hope you get out of this is an appreciation of the incredible shifts in perspective that lead to the final algorithm. Coming up with the algorithm is an amazing feat and useful for specific applications, but the overarching problem solving techniques that come through in the journey to the solution is truly invaluable.*/

	///	<summary>
	/// use <see cref="planar.vect.set.op_.binary_.minkowski_.Minus"/>, and determine whether 0 is in the set.
	/// </summary>
	class IGjkAlgorithm
	{

		///define the support function <see cref="crux_.complex.supportFunc"/> for each convex shape.
		/// then the support func for the <see cref="vect.set.op_.binary_.minkowski_.Minus"/> is defined by the above two support functions.
		/// select an arbitrary support func for <see cref="vect.set.op_.binary_.minkowski_.Minus"/>, for example, the horizontal one.
		/// then the point returned shall be the minus of the following two points:
		///		1) the point for the first convex on the same vector, but start from an inernal point of that convex.
		///		2) the point for the second convex on the opposite vector, but start from the internal point of that convex.
		/// see if the point is the origin. otherwise, select the vect from the point to origin
		/// continue select the next point. Now we have a line segment. See if the line segment passes thru origin. If not, select a normal vector pointing to origin, and get the support point. We now have a triangle. continue the process till we get a triangle that encloses the origin.
		/// If we end up with no such triangle, then the two convexes donot intersect.

	}
}
