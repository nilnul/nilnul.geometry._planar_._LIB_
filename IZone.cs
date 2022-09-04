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
	/// alias:
	///		patch
	///		shape
	///			shape is invariant when translated, rotated, flipped
	///		domain
	///		zone
	///		region
	///		tract
	///	vs : curve_.cloze
	///		cloze has direction
	///		zone doesnot.
	///		
	/// </remarks>
	/// zone has no direction. the edge might has direction.
	///   in other words, the zone implies a direction.
	public interface IZone :
		//zone_.ISimple,
		track_.IBoundaried      //,
								//, ISwath
		,
		swath_.IBoundarable
	//surface_.ISimple  //non simple surface can be composite (by subtraction), hence is not simple.
	//,	///implied
	//sub_.connected_.simple_.IRoadable   //implied


	{
	}
}
