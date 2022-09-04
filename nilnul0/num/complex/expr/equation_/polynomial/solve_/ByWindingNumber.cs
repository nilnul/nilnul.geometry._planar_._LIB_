using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.complex.expr.equation_.polynomial.solve_
{
	/// <summary>
	/// winding number would be the rank of the polynomial.
	/// eg: 5 for a quintic polynomial
	///
	/// if a region's winding number is positive, then solution is in it.
	/// we keep bisect the region, and at least one half's winding would be positive.
	/// We can finally find a region small enough.
	///
	/// if a region's winding number is negative, just reverse the direction of the path.
	///
	/// if a region's winding number is nil, just expand the region.
	/// </summary>
	class ByWindingNumber
	{
	}
}
