using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar._point.coord
{

	/// <summary>
	/// for a same space, we can use different coord sys, and the coord can be converted.
	/// eg:
	/// we can convert orthogonal coord to polar coord.
	/// in 3d, we can use:
	///		orthogonal
	///		,
	///		sphere
	///		,
	///		cylinder,
	///		etc
	/// </summary>
	/// <remarks>
	///	vs:
	///		<see cref="nameof(planar.ITrans)"/>
	///			which is used to transform object from one space to another space. Two different spaces. 'cuz it's on space, and extends to another, so it's placed under the root namespace.
	///
	/// alias:
	///		trans
	///			avoid this as it's used in <see cref="nameof(ITrans)"/>
	/// </remarks>
	class Conversion
	{
	}
}
