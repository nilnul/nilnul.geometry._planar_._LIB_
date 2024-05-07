using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.vwer_.morph_
{
	/// <summary>
	/// the auxillary axis (in other words, y) is flipped.
	/// eg:
	///		in math, the y is upward; but in screen, the y is downward. So the growing curve in math would be shown as downward going.
	/// </summary>
	/// <remarks>
	/// note: the prowindness of a cloze is not changed. eg: the prowind circle in math orientation, being counterclockwise there,  would still rotate from x to y on screen, but like a wallclock, rotating clockwise.
	/// </remarks>
	internal class IAuxillaryFlipped
	{
	}
}
