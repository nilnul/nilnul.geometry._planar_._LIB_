using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar._troll.locus_.borel_.interval_
{
	/// <summary>
	/// the break pooint can be:
	///		jump (at an interval of one sdie)
	///		removable(the two sides are at the save value)
	///	the excluded/exceptional point can be
	///		excluded but on one side
	///					or on neither sides
	///		, exceptional
	///		
	/// </summary>
	/// vs:
	///		<see cref="dwelt_.IContiguous"/> which might be not continuous.
	///	vs:
	///		connected, which might be empty
	///
	///		crux, connected and dwelt;, which might be a single point
	/// 
	///		continuous, spanned, connected. meaning continuing from this point to next
	///		
	///		contiguous ,continuous with countable points excluded.
	///		
	///		consecutive, disjoint continuous,  will countable break points, each of which is contiguous. a continuous map from borel. Hence it can be empty;
	///		
	///		
    public interface IContiguous
    {
    }


}
