using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.vect_
{
	/// <summary>
	/// the vector from one point to another , represented by length and direction
	/// </summary>
	static public class _DisplaceX
	{
		static public PointI1 PointI(PointI1 start, PointI1 end) {
			return planar.point.co.band_.Minus.Singleton.combine(end ,start);
		}

		static public Vector1 Vector(PointI1 start, PointI1 end) {
			return new planar.Vector1(PointI(start,end) );
		}
	

	
		static public PointI1 PointI1(this point.Co duo) {
			return PointI(duo.begin,duo.end);
		}


	}

}
