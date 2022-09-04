using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.sub_.directed_.connected_._polygon_
{
	public interface VertexesI
	{
		/// <summary>
		/// If the input points include some consecutive pair that is same, the following same point is disregarded.
		/// consecutive vertexes must be distinct, while consective points might be not.
		///		This is in alignment with the rationale that the begining point is implicitly taken as the closing point, making the two (begining and closing) are the same, but only one is accounted for here.
		///	
		/// </summary>
		IEnumerable<geometry.planar.PointI1> vertexes { get; }


	}
}
