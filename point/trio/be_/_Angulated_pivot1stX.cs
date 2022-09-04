using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.point.trio.be_
{
	/// <summary>
	/// a is not b.
	/// c is not b
	/// a c might be the same.
	///
	/// This is a sunshine reflection or refraction
	/// </summary>
	/// <see cref="curve_.piecewise_.polystep_.IDi"/>
	///
	[Obsolete(nameof(_StepsX),true)]
	static public class _Angulated_pivot1stX
	{
		/// <summary>
		/// we start with the inward point and end with outward point, not starting with the pivot(middle point), such that the path is continous and mimics the way of the reflection of sunshine
		/// </summary>
		/// <param name="pivot"></param>
		/// <param name="inward"></param>
		/// <param name="outward"></param>
		/// <returns></returns>
		static public bool Be( Point1 pivot, Point1 inward, Point1 outward)
		{
			return pivot != inward  &&  pivot != outward;
		}

		static public bool Be(PointI1 pivot,PointI1 inward,  PointI1 outward)
		{
			return Be( Point1.Of(pivot), Point1.Of(inward),  Point1.Of(outward));
		}

		static public bool Be(Point4dbl pivot,Point4dbl inward,  Point4dbl outward)
		{
			return pivot!=inward   && pivot!=outward  ;
		}


		static public bool Be(planar.point.Trio trio)
		{
			return Be(trio.a, trio.b, trio.c);
		}

		static public bool Be(planar.point.TrioD trio)
		{
			return Be(trio.a, trio.b, trio.c);
		}
	}



}
