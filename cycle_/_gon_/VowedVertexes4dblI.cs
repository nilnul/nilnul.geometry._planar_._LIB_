using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.cycle_._gon_
{
	/// <summary>
	/// make sure the vertexes are swirled positive
	/// </summary>
	public interface VowedVertexes4dblI
		
	{
		/// <summary>
		/// If the input points include some consecutive pair that is same, the following same point is disregarded.
		/// consecutive vertexes must be distinct, while consective points might be not.
		///		This is in alignment with the rationale that the begining point is implicitly taken as the closing point, making the two (begining and closing) are the same, but only one is accounted for here.
		///	
		/// </summary>
		coil_.gon_.poly.be_.cycle.vow.Ee4dbl coilVertexes { get; }


	}
}
