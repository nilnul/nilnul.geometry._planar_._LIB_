using nilnul.geometry._2d.point;
using nilnul.geometry.planar._point;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.geometry.planar.point.s.b
{
	[Obsolete()]
	public partial class Headed
		:nilnul.obj.B<IEnumerable<PointD>>
	{
		static public bool Eval(IEnumerable<PointD> points) {
			return nilnul.collection.enumerable.be.Positive<PointD>.Be(points);
		}
		public Headed()
			:base(Eval)
		{


		}

		public class Asserted:
			nilnul.obj.Asserted<IEnumerable<PointD>,Headed>
			//nilnul.collection.enumerable.be.Positive<PointInDouble>.Asserted1
			//nilnul.bit.be.Asserted<IEnumerable<Point>,NonEmpty>
			
		{
			public Asserted(IEnumerable<PointD> points)
				:base(points)
			{

			}

		}

	}
}
