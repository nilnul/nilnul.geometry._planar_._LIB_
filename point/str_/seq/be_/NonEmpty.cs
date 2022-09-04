using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.geometry._2d.point.s.be
{
	public partial class NonEmpty
		:nilnul.bit.Be<IEnumerable<PointInDouble>>
	{
		static public bool Eval(IEnumerable<PointInDouble> points) {
			return nilnul.collection.enumerable.be.Positive<PointInDouble>.Be(points);
		}

		public NonEmpty()
			:base(Eval)
		{


		}

		public class Asserted:
			nilnul.collection.enumerable.be.Positive<PointInDouble>.Asserted1
			//nilnul.bit.be.Asserted<IEnumerable<Point>,NonEmpty>
			
		{
			public Asserted(IEnumerable<PointInDouble> points)
				:base(points)
			{

			}

		}

	}
}
