using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.geometry.planar
{
	//[Obsolete("as curve is always directable, hence see: "+ nameof(planar.coil_.IGon))]
	//[Obsolete(nameof(ILoop))]
	/// <summary>
	/// 
	/// </summary>
	/// alias:
	///		lapse
	///			,where "se" hints infinite or finite.
	///			,lack direction
	public interface ILapse
		:
		planar.curve.IUnDirected
		//,
		//orbit_.ISimple

		//, locus_.IEndAtStart
		//, ILoop
	{
	}
}