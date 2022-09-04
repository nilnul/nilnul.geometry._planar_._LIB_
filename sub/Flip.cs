using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.sub
{
	/// <summary>
	/// imagine that the plane in a 3d space, like a screen curtain hovering in the air, we can view the curtain from the front, or we can view the curtain from behind when the image shown is flipped.
	/// The lights transver thru the curtain ; and the lights is directed,of a direction, not opposite.
	/// <see cref="geometry.planar.coil_.gon._SurroundedX"/> is a value viewed from front, but is negated viewed from the behind. In some case, the surrounded viewed from front is negative, and becomes positive when viewed from the other side.
	/// </summary>
	public interface IFlip
	{
	}
}
