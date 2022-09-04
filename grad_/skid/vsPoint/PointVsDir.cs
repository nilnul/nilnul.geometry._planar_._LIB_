using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.geometry._2d.dir.binary.op
{
	public partial class PointToDir
	{
		static public int Eval(point.PointInDouble point,Dir dir) {

			if (point==dir.start)
			{
				return 0;
				
			}
			if (point==dir.end)
			{
				return 0;
				
			}
			return -(
				Angle.Eval(
					dir
					,
					Dir.Create(dir.start, point)
				)-Math.PI
			).CompareTo(0);
			
		}
	}
}
