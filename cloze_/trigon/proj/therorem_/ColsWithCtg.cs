using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.curve_.cloze_.trigon.proj.therorem_
{
	/// <summary>
	/// when the trigon is projected to a line thru the vertex <var>A</var>, the two distances of the other two vertex <var>B</var> and <var>C</var> are <var>bCol</var> and <var>cCol</var>
	/// </summary>
	public class ColsWithCtg
	{
		/// <summary>
		/// 
		/// </summary>
		/// <param name="perpendFroVertexB"></param>
		/// <param name="perpendFroVertexC"></param>
		/// <param name="angleB"> on the same side of <paramref name="perpendFroVertexB"/></param>
		/// <param name="angleC"> on the same vertex of <paramref name="perpendFroVertexC"/></param>
		/// <returns></returns>
		static public double LengthOfProjection(double perpendFroVertexB,double perpendFroVertexC, double angleB, double angleC) {

			return perpendFroVertexB / Math.Tan(angleC) + perpendFroVertexC / Math.Tan(angleB);

		}
	}
}
