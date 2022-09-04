using System;

namespace nilnul.geometry.planar.point.trio.be_
{
	/// <summary>
	/// a is not b.
	/// c is not b
	/// a, c might be the same.
	///
	/// This is a sunshine reflection or refraction
	/// </summary>
	/// <see cref="curve_.piecewise_.polystep_.IDi"/>
	///
	//[Obsolete(nameof(_Angulated_pivot1stX) + ".  curve_.piecewise_.polystep_.Di can be less misleading; " + nameof(curve_.piecewise_.polystep_.IDi))]
	//[Obsolete(nameof(grad_.step.co_.Chain))]
	[Obsolete(nameof(grad_.step.co_.Chain))]
	static public class _StepsX
	{
		/// <summary>
		/// we start with the inward point and end with outward point, not starting with the pivot(middle point), such that the path is continous and mimics the way of the reflection of sunshine
		/// </summary>
		/// <param name="inward"></param>
		/// <param name="pivot"></param>
		/// <param name="outward"></param>
		/// <returns></returns>
		static public bool Be(Point1 inward, Point1 pivot, Point1 outward)
		{
			return inward != pivot && outward != pivot;
		}

		static public bool Be(PointI1 inward, PointI1 pivot, PointI1 outward)
		{
			return Be(new Point1(inward), new Point1(pivot),new Point1(outward));
		}

		static public bool Be(Point4dbl inward, Point4dbl pivot, Point4dbl outward)
		{
			return inward != pivot && outward != pivot;
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
