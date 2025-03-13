using nilnul.num.complex;
using nilnul.num.complex.of_.binary_;
using nilnul.num.complex.op_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.lasso_.ellipse
{
	static public class _BoundaryX
	{
		static public (double x, double y,double w, double h) Boundary(
			double centerX, double centerY,
			double radiusX, double radiusY, double rotation
		)
		{
			var w = planar.cloze_.ellipse_.central._BoundaryX.Boundary(
				radiusX,radiusY,rotation
			);

			return (
				centerX -w.boundaryRadiusX
				,
				centerY -w.boundaryRadiusY
				,
				w.boundaryRadiusX*2
				,
				w.boundaryRadiusY*2
			);

		}

	}
}
