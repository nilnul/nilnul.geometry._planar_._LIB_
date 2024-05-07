using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry._planar
{
	/// <summary>
	/// if we raise our right palm, and let the back face outward, and the inner face inward to our face, then point the index finger up, and point the thumb outward to the right, as a consequence, we established a coordinate system, with x pointing rightward (from left2right), y pointing upward(from low).
	/// </summary>
	/// <remarks>
	/// if we keep the thumb rightward, but point the index finger downward, as a side effect the palm back will face innerward to our back, and the palm inner will face outside to our front. Thus we establish a coordinate system with x pointing rightward and y pointing downard, like our computer screen, or a book. Note the stokes surrounded signed area of a cloze will not change as we change the orientation of our hands, cuz the area's sign is depending on whether it's inner of the cloze, not on whether there is directed norm perpendicular to it; Thus when we reorient our hands, the innerness will not change; what's changed is the rotation which might change from counterclockwise to clockwise.
	///
	///
	/// So we can also use our lefthand to visualize the above coordinate system by justing changing the orient of the plam, back or inner of hand facing us or not.
	///
	/// flipping the plane will not change whether a point is inner of a cloze or not. It's only changing the rotation's clockwiseness relative to the old system; as the change exists only if we refernce an old coordinate system, hence it's a <see cref="planar.IMorph"/>, not a standalone coordiante system.
	///
	/// we can apply a cordinate system onto a thing, by flipping the coordinate system when needed, without changing the innerness of a cloze.
	/// </remarks>
	///
	///
	internal class IOrient
	{
	}
}
