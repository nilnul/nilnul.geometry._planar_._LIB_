using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar
{
	/// <summary>
	/// the dimension is in 2.
	/// fixed shape. shape with coordinates. the translation, orientation, scale is important
	/// any two points in the region must be in a neighborhood, which is a sub of the region. So region might be unbounded
	///		so two regions sharing only one point, is not regarded as one region.
	///		two regions sharing one edge, can be regarded as one region.
	/// </summary>
	/// <remarks>
	/// zone has no direction. the edge might has direction.
	///   in other words, the zone implies a direction.
	///  eg:
	///		for a rect, the edges must cycle positively; otherwise, it's not zone, but a space with a rect hole;
	///		
	/// </remarks>
	///   
	/// alias:
	///		hull
	///		tray
	///		patch
	///		mask
	///		shape
	///			shape is invariant when translated, rotated, flipped
	///		domain
	///		zone
	///		region
	///		tract
	///		zune
	///		zine, magzine;
	///	vs : curve_.cloze
	///		cloze has direction
	///		zone doesnot.
	///

	public interface IZone
		:
		cycle_.IProWinded
		,
		facet_.ISimple
		,
		//zone_.ISimple,
		swath_.IBoundarable
	//surface_.ISimple  //non simple surface can be composite (by subtraction), hence is not simple.
	//,	///implied
	//sub_.connected_.simple_.IRoadable   //implied
	,
		flank_.IBoundaried      //,
								//, ISwath
		

	{
		
	}
}
