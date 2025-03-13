using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.troll
{
	/// <summary>
	/// regard this as a set. So the direction is important, and the repetitiveness is also unimportant.
	/// </summary>
	/// <remarks>
	/// if we disregard the order, some self intersected points would be lost; And we lose significant information about the "lineness" of this <see cref="IDrawable"/> and only keep a measurable set, which might be measued as area, or length, or <see cref=""/>
	/// </remarks>
	/// alias:
	///		track
	///		,trac
	///			,not tract, or trace
	public interface IUndirected
	{
	}
}
