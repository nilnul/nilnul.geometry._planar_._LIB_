using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.zone_
{
	/// <summary>
	/// the inner area of a <see cref="curve_.cloze_.Circle1"/>
	/// </summary>
	/// <remarks>
	/// analog to <see cref="planar.cycle_.ICircle"/>, this is defined by a circle (which is in turn a point, and an open area), and the inner open area.
	/// </remarks>
	public interface IDisc
		:
		IZone
	{
	}
}
