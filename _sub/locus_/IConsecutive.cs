using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar._sub.locus_
{
	///  disjoint continuous,  will countable break points, each of which is contiguous. a continuous map from borel. Hence it can be empty;
	///
	/// <summary>
	/// on each disjoint interval of borel, the locus is continuous.
	/// Overall, there could be countable break point, some of which are between the intervals, some coulld be also on a singleton interval.
	/// </summary>
	/// <remarks>
	/// this can be empty.
	/// this is from real to complex, not from real to real.
	/// </remarks>
	/// alias:
	///		borel
	public interface IConsecutive
		:locus_.borel_.IContinuous8continuous
    {
    }



}
