using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.zone_
{
	/// <summary>
	/// the stokes area is positive.
	/// if it's negative, then the clozed surface is the outside, which is still a surface, but not a zone. As we are under the namespace of zone, hence this polygon here is always positive.
	/// </summary>
	public class Polygon4dbl_onPositiveCycle
		:

		cycle_.gon_.Facade4dbl
		,
		Polygon4dblI
	{


		public Polygon4dbl_onPositiveCycle(cycle_.Polygon4dbl val) : base(val)
		{
		}

		public Polygon4dbl_onPositiveCycle(IEnumerable<Point4dblI> enumerable) : base(enumerable)
		{
		}

		public Polygon4dbl_onPositiveCycle(params Point4dblI[] vertex0)
			:this( (IEnumerable<Point4dblI>)vertex0)
		{
		}
		public Polygon4dbl_onPositiveCycle(params Point4dbl[] vertex0)
			:this( (IEnumerable<Point4dblI>)vertex0)
		{
		}

	}
}
