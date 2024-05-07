using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.zone_.gon_.quad_.parlgrm_.lowered._area.by_
{
	///---------------
	/// \  |          \
	///  \ |           \
	///   \|            \
	///    ---------------
	/// then:
	///    ---------------
	///    |          \  |
	///    |           \ |
	///    |            \|
	///    ---------------
	/// 
	/// <summary>
	/// take the second leftmost vertex, and from it an altitude is originated, reaching to the opposite edge. This will cut a triangle at the left.
	/// We then move this triangle to the right of the remained part(which would be a <see cref="quad_.trape_.perpend_"/> ), the two will comprise a <see cref="zone_.IRect"/>, the area of which then can be computed.
	/// </summary>
	/// <remarks>
	/// </remarks>
	internal class Cut9compose
	{
	}
}
