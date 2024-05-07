using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;

namespace nilnul.geometry.planar.lead.vsPoint.be_
{

	/// <summary>
	/// at the positive side. or on the line itself.
	/// </summary>
	static public class _NonconWindX
	{ 
		static  public bool ByCrossProduct(planar.grad_.skid_.ByPoints4Dbl arrow, planar.Point4dbl point)
		{


			return nilnul.geometry.planar.vect.co.to_.real_._CrossProductX.SurroundedOfParallelogram(
				planar.grad._DisplaceX.Vect(arrow)
				,
				planar.grad._DisplaceX.Vect1(arrow.basis,point)

			)>=0			;

		}

		static  public bool _Be_0skid(
			(Complex start, Complex end) arrow
			, Complex point
		)
		{


			return nilnul.geometry.planar.vect.co.to_.real_._CrossProductX.SurroundedOfParallelogram(
				arrow.end -arrow.start
				,
				point - arrow.start
	
			)>=0			;

		}

	}
}
