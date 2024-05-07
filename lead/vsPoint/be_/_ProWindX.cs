using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;

namespace nilnul.geometry.planar.lead.vsPoint.be_
{

	
	/// <summary>
	/// prowind. the point is not on the line.
	/// if the point is on the line, we need <see cref="vsPoint_.colinear.be_._ArrowHasPointX"/>
	/// </summary>
	static public class _ProWindX
	{ 
		static  public bool ByCrossProduct(planar.grad_.skid_.ByPoints4Dbl arrow, planar.Point4dbl point)
		{


			return nilnul.geometry.planar.vect.co.to_.real_._CrossProductX.SurroundedOfParallelogram(
				planar.grad._DisplaceX.Vect(arrow)
				,
				planar.grad._DisplaceX.Vect1(arrow.basis,point)

			)>0			;

		}
		static  public bool _Be_0skid(
			Complex start, Complex end
			, Complex point
		)
		{


			return nilnul.geometry.planar.vect.co.to_.real_._CrossProductX.SurroundedOfParallelogram(
				end -start
				,
				point - start
	
			)>0			;

		}

		static  public bool _Be_0skid(
			(Complex start, Complex end) arrow
			, Complex point
		)
		{


			return _Be_0skid(arrow.start,arrow.end,point)	;

		}


	}
}
