using nilnul.geometry.planar._point;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.geometry.planar._point.pointD._str.enumerableOfPointD.be
{
	public partial class NonEmpty
		:nilnul.bit.Be<EnumerableOfPointD>
	{
		static public bool Eval(EnumerableOfPointD points) {
			return nilnul.collection.enumerable.be.Positive<PointD>.Be(points);
		}

		public NonEmpty()
			:base(Eval)
		{


		}

		public class Asserted:
			nilnul.collection.enumerable.be.Positive<PointD>.Asserted1
			//nilnul.bit.be.Asserted<IEnumerable<Point>,NonEmpty>
			
		{
			public Asserted(IEnumerable<PointD> points)
				:base(points)
			{

			}

		}

	}
}
