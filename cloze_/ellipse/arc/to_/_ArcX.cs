using nilnul.geometry.planar.curve_.elliptic_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.cloze_.ellipse
{
	static public class _ArcX
	{
		/// <summary>
		/// 
		/// </summary>
		/// <param name="ellipse"></param>
		/// <param name="startAngle">
		///If one thinks of an ellipse as a circle that has been stretched and then rotated,then this angle is of the arc prior to the stretch and rotate operations. 
		/// </param>
		/// <param name="sweep">
		///If one thinks of an ellipse as a circle that has been stretched and then rotated,then this angle is of the arc prior to the stretch and rotate operations. 
		///
		/// </param>
		/// <returns></returns>
		static public (System.Numerics.Complex start, bool large, bool orient, System.Numerics.Complex end) Polar2peggy(
			cloze_.Ellipse ellipse, double startAngle, double sweep
		) {

			var start = ellipse.locus(startAngle);
			var end = ellipse.locus(startAngle+sweep);

			var large = Math.Abs( sweep ) > Math.PI;
			var orient = sweep > 0;

			return (start, large, orient,end);
		}


	}
}
