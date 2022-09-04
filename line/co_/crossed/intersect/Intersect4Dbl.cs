using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.geometry.planar.line.co_.crossed.intersect
{
	static public  class _OfLineGradX
	{
		public static Point4dbl _Eval_4intersetedLines__retNullable(
			planar.IRayDbl line,
			planar.Tend4dbl segment

		) {

			return _Eval_4intersetedLines__retNullable( new LineDbl(line),segment );
		
		}



		public static Point4dbl _Eval_4intersetedLines__retNullable(
			LineDbl line,
			planar.Tend4dbl segment
			
		) {


			var point = planar.line.co_.crossed.Cross4Dbl._Eval_twoIntersectingLines(line, new LineDbl(segment));

			if ( planar.tend.vsPoint_.coline.be_._Has4DblX.Has( segment, point))
			{
				return point;
				
			}
			return null;
 
		
		}

	
	}
}
