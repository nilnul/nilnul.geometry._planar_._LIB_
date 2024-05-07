using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.coil_
{
	/// 	/// we might sample points in the middle of an edge, and at the same point,  hence an edge might be decomposed into several skids or grads.
	/// But after being reduced, adjacent points are distinct. nonadjacent points might be incident. in other words,
	/// <summary>
	///the edge is grad_.Skid.
	/// two tangent edge might be <see cref="curl_.elbow.be_.IReflex"/> or <see cref="curl_.elbow.be_.IStraight"/>
	/// </summary>
	/// <remarks>
	/// at least two points;
	/// Suppose we have one grad now,  and to be a cloze, the other grad has to be there opposite to the first one.
	/// 
	/// eg: digon
	///		note, two edge might on the same line.
	/// 
	/// </remarks>
	/// self intersected polygon is clearerly defined here rather than at <see cref="planar.IFacet"/>
	/// 
	public interface IGon :
		ICoil 
		,
		cloze_.IPolygon
		,
		grad_.skid.chain_.dwelt_.ICoil
	{
	}
}
