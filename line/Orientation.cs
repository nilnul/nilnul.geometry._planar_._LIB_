using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.line
{

	static public class _OrientationX
	{
		static public nilnul.geometry.planar.rotation_.Orientation Orientation(planar.LineI line) {
			return planar.tend_.edge._OrientationX.Orientation(line.points);
		}

		static public double Orientation(planar.LineDbl line) {
			return planar.tend_.edge._OrientationX.Orientation( line.ee);
			

		}
	}
}
