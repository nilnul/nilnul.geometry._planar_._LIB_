using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.morph_.rebase_
{
	/// <summary>
	/// eg:
	///		for point (x,y), the rebase is
	///			a1  b1
	///			a2   b2
	///	to get x*(a1,a2), y* (b1,b2), we need to put the matrix on the left:
	///			a1  b1  
	///			a2   b2
	///			*
	///			(x,y)^T
	///			=(a1x+b1y, a2x+ b2y )
	///			=x*(a1,a2) + y* (b1,b2)
	///		
	/// </summary>
	/// <remarks>
	/// matrix is put on the left.
	/// the left is two cols, and the right is also a col.
	/// </remarks>
	/// alias:
	///		asCols
	///		colwise
	internal class IColwise
	{
	}

}
