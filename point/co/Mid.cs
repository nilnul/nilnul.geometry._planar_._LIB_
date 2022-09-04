using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PointD = nilnul.geometry.planar.Point4dbl;

namespace nilnul.geometry.planar.point.co
{
	static public class _MidX
	{
		static public Point4dbl Mid(this point.CoD duo) {
			return new Point4dbl( (duo.component.x+duo.component1.x)/2, (duo.component.y+duo.component1.y)/2 );
		} 
	}
}
