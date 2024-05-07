using nilnul.geometry.planar.grad_;
using nilnul.geometry.planar.grad_.skid_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar
{
	/// <summary>
	/// there might be holes or overlaps (two or more layers; some layers cancel each other.).
	/// </summary>
	/// <seealso cref="planar.ICrux"/>
	/// alias:
	///		pattern
	///		mask
	///		clip
	///		facet
	///			surface means full, hence without "sur", it's bounded
	///			if it's a point, it's called vertex
	///			if it's a seg, it's called edge
	///			if it's a shape, it's called facet.
	///		facet
	///			there is no hole, as if there were a hole, for a 3d solid shape like polygon, there might be other facets down in the hole.
	///			holed zones is not simple. We can compose holed zones by simpletons.
	///		piece:
	///		plate
	///		splatter
	///		side
	///		flank
	///		spatter

	///		
	public interface IFacet
		:
		//board_.ISimple
		//,
		surface_.IBoundarable
	{

	}



}
