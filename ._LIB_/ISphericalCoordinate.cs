using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using nilnul.expr;
using nilnul.real;

namespace nilnul.geometry
{

	public interface ISphericalCoordinate {
		IPlane fundamentalPlane { get; set; }
		IPole positivePole { get; set; }
		IPole negativePole { get; set; }


		/// <summary>
		/// 0 ≤ θ ≤ π is the angle between the positive z-axis and the line formed between the origin and P. 
		/// 		θ is referred to as the zenith, colatitude or polar angle.


		/// </summary>
		IExpr<IReal> zenithAngle { get; set; }


		/// <summary>
		/// 0 ≤ φ < 2π is the angle between the positive x-axis and the line from the origin to the P projected onto the xy-plane.
		/// φ is referred to as the azimuth
		/// </summary>
		IExpr<IReal> azimuth { get; set; }

		/// <summary>
		/// r ≥ 0 is the distance from the origin to a given point P. 

		/// </summary>
		IExpr<IReal> radialDistance { get; set; }

		


	}
public interface IPole { 

		}
}


