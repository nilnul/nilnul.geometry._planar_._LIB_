using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.grad_.skid.co_.coline.be_
{

	/// <summary>
	/// joint. share at least one point.
	/// </summary>
	public class Joint4dbl
		//: Re4dblI
	{
		public bool _re_assumeSkidsAlign(Grad4dbl_byPointsI x, Grad4dbl_byPointsI y)
		{

			//map to linear
			//x start would be mapped to nil
			var xVect = grad._DisplaceX.Vect(x);
			var yBasisMapped = grad._DisplaceX.Vect1(x.basis,y.basis);
			var yEndMapped = grad._DisplaceX.Vect1(x.basis,y.finish);


			var projector = new vect.Projector4dbl(xVect);

			var xEndProj = projector.dot();
			var yBasisMappedProjected = projector.dot(yBasisMapped);
			var yEndMappedProjected = projector.dot(yEndMapped);


			return geometry.linear.grad_.skid.re_.Joint4dbl.Singleton.re(
				(0d,xEndProj)
				,
				(yBasisMappedProjected,yEndMappedProjected)
			);
		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="x"></param>
		/// <param name="y"></param>
		/// <returns></returns>
		/// <seealso cref="nameof(grad.co.be_.Cross)"/>
		public bool _re_assumeAlign(Skid4dblI x, Skid4dblI y)
		{
			return _re_assumeSkidsAlign( (Grad4dbl_byPointsI)x, (Grad4dbl_byPointsI)y);


		}

		static public Joint4dbl Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<Joint4dbl>.Instance;
			}
		}


	}
}
