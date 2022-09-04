using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.zone_.gon_.convex_
{
	public class Centripetal
	{
		/// <summary>
		/// 
		/// </summary>
		/// <param name="_dwelled_closedFinite_convex_simple"></param>
		/// <param name="_outsidePoint"></param>
		/// <returns></returns>
		static public IEnumerable<PointI1> _KeepingMerging4ConvexHull(IEnumerable<PointI1> _dwelled_closedFinite_convex_simple, PointI1 _outsidePoint)
		{
			/// extend each arrow (the directed edge of polygon)
			/// then the outside point (X) will fall in the following situations:
			/// 1) on the extended line of edge AB
			///		1.1)  on the leeway of CD
			///			in this case, replace B with _outsidePoint
			///		1.2) on the line of CD
			///		1.3) on the foreign of CD
			///			replace both B & C with X
			///	2) on the leeway of AB
			///		2.1) on the leeway of CD
			///			Add X. (keep BC)
			///		2.2) on the line of CD
			///			Add X. remove C.
			///		2.3) on the foreign of CD
			///			Add X. remove C
			///			
			///	2) on the reverted extended line of Edge CD (in other words ,the extended line of DC)
			///		in this case, replace C with X
			throw new NotImplementedException();

		}
	}
}
