using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.geometry.planar.sub_.directed_.connected_.polygon.be.simple
{
	public partial class SumOfInteriorAngles
	{
		public double Eval(int countOfEdges) {
			return (countOfEdges-2)*Math.PI;
		}
	}
}
