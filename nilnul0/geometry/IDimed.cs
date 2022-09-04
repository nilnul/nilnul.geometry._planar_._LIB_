using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry
{
	/// <summary>
	/// dimension (0,1,2,3,...) is given/fixed.
	/// a 0-d geometry, or a point, is exploded into a line (1-d), then spreads to a plane(2-d), then expands to a stereo space.
	///		This happens very fast, and it's how our universe is formed from bigBang postulate.
	///			The sound of the explosition is:
	///				"Dim"
	///					not
	///						"Bang"
	/// </summary>
	public interface IDimed
	{
	}
}
