using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.zone_.trigon
{
	/// <summary>
	/// the vertex of the biggest angle.
	/// when we place the apex on the upper, this is stable as the spread of the basis is the biggest, and the apex's perpendicular foot is inner at the basis.
	/// </summary>
	/// <remarks>
	/// the altitude of this is minimum as, given the area, the basis is the longest.
	/// Thus by placing apex above ,and the basis under, this is the most stable.
	/// </remarks>
	/// alias:
	///		apex
	///		peak
	///		pinnacle
	///		crest
	///		
	/// try to form a 2d object from 1d object, by bundles all the out rays of every point to the apex.
	///			this is analog to how we form 3d cone from 2d basis.
	///	<seealso cref="edge.IApex"/>
	///	
	public interface IApex
	{
	}
}
