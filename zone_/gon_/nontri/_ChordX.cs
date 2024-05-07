using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.zone_.gon_.nontri
{
	/// <see cref="gon.corner"/>
	/// <see cref="cycle_.gon.corners.theorem_.Ge3Convex"/>
	/// <see cref="cycle_.gon.theorem_.IEarCorneredOffSide"/>
	/// <summary>
	/// 
	/// </summary>
	static public class _ChordX
	{
		/// <summary>
		/// 
		/// </summary>
		/// <param name="vertices">
		///		distinct
		///		each corner is not align
		///		forms a zone
		///		four or more edges
		///			
		/// </param>
		/// <returns></returns>
		static public (Complex start, Complex end) _FindChord_0nontriZone(
			IEnumerable<Complex> vertices
		)
		{
			return nontri.chord._find_.by_._ByElbowX._FindChord_0nontriZone(vertices);
			//return nontri.chord._find_.by_._ByCornerX._FindChord_0nontriZone(vertices);

		}
	}
}
