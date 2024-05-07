using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.geometry.planar.grad_.skid.vsPoint.be_
{

	interface IProWind { }
	/// <summary>
	/// at the positive side. not on the line itsefl
	/// </summary>
	///<see cref="lead.vsPoint.be_._ProWindX"/>
	[Obsolete(nameof(IProWind))]
	static public class _LeewayX
	{
		static  public bool ByCrossProduct(planar.grad_.skid_.ByPoints4Dbl arrow, planar.Point4dbl point)
		{
			return nilnul.geometry.planar.vect.co.to_.real_._CrossProductX.SurroundedOfParallelogram(
				planar.grad._DisplaceX.Vect(arrow)
				,
				planar.grad._DisplaceX.Vect1(arrow.basis,point)

			)>0
		;
			
			


		}
	}
}
