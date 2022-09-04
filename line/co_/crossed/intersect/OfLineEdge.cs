using nilnul.geometry.planar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using nilnul.num.real;
using nilnul.num;

namespace nilnul.geometry.planar.line.co_.crossed.intersect
{
	static public  class _LineThruEdgeX
	{
		public static planar.Point1 _Eval_4intersetedLines__retNullable(
			Line line,
			planar.tend_.EdgeI segment
		)
		{
			var point = planar.line.co_.crossed._CrossX._Point_ofAssumeCrossed(line, new Line(segment.pair));
			if (
				planar.tend.vsPoint_.coline.be_._HasX._Has_ofColinear(segment, point)
			)
			{
				return point;
			}
			return null;
		}
	

		public static planar.Point1 _Eval_4intersetedLines__retNullable(
			planar.Ray line,
			planar.tend_.EdgeI segment

		)
		{
			return _Eval_4intersetedLines__retNullable(new Line(line), segment);
		}

		public static planar.Point1 _Eval_4intersetedLines__retNullable(
			planar.Ray line,
			planar.grad_.Arrow segment

		)
		{
			return _Eval_4intersetedLines__retNullable(line, new planar.tend_.Edge(segment.ee.begin, segment.ee.end));
		}




	
	}
}
