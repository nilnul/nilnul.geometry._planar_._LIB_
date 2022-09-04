using nilnul.geometry.planar.point;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using R = nilnul.num.RealI;


namespace nilnul.geometry.planar.polygon_.quadri_.simple_.convex_.trape_.parlgrm
{
	
	/// <summary>
	/// a point with a vector
	/// </summary>
	public class Bounding
		
	{
		

		/// <summary>
		/// 
		/// </summary>
		/// <param name="_points_started">
		/// stokes turn positive, or negative
		/// </param>
		/// <returns></returns>
		static public Bounding _GetBoundingBox(IEnumerable<nilnul.geometry.planar.PointDbl> _points_started)
		{
			var maxX = nilnul.num.real.str_.started._MaxX.Index(_points_started.Select(p => p.x));
			var minX = (maxX + 2) % 4;
			var min

			return point.co_.Nondecrease._Bounding_assumeNondecrease(
				_points_started.ElementAt(minX).x
				,
				_points_started.ElementAt()
			);


			

		}

	
	}
}
