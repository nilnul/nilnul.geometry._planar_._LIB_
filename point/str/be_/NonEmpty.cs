using nilnul.geometry.planar.point;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.geometry.planar.point.str.be
{
	public partial class NonEmpty
		:nilnul.bit.Be<_str.EnumerableOfPointD>
	{
		static public bool Eval(_str.EnumerableOfPointD points) {
			return nilnul.collection.enumerable.be.Positive<Point4dbl>.Be(points);
		}

		public NonEmpty()
			:base(Eval)
		{


		}

		public class Asserted:
			nilnul.collection.enumerable.be.Positive<Point4dbl>.Asserted1
			//nilnul.bit.be.Asserted<IEnumerable<Point>,NonEmpty>
			
		{
			public Asserted(IEnumerable<Point4dbl> points)
				:base(points)
			{

			}

		}

	}
}
