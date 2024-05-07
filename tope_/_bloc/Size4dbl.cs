using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.tope_._bloc
{
	/// <summary>
	/// length, width
	/// 
	/// </summary>
	/// <remarks>
	/// or length for time, and width, and height for planar.
	/// </remarks>
	/// nearness(perception) in addition to width and height, for 3d.
	public interface Size4dblI

	{
		nilnul.num.real_.NonnegOfDoubleI width { get; }
		nilnul.num.real_.NonnegOfDoubleI height { get; }

	}
}
