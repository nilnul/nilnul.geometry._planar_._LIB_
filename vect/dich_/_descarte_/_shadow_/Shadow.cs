using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.vect.to_.co_.decompose
{
	/// <summary>
	/// the decomposed of, say a force (the vector), along the given <see cref="planar.ILeadDbl"/>
	/// </summary>
	/// alias:
	///		shadow
	///			as sunshine parrallelly projected all over the board into one direction defined by a lead, the shadow on a board which is perpendicular to the sunshine. Also, the board is directed, and is rotated +90 with respect to the lead.
	///		perspect
	///		precept
	///		projection
	///		
	///
	///

	//[Obsolete(nameof(_ProjectionX))]
	static public class PerceptX
	{

	/// <remarks>
	///    
	/// </remarks>
		static public double ScalarProject(planar.vect_.Polar4dbl vector, double directionOfBoard) {



			return  vector.polarPoint.radius
				*
				Math.Cos(
					vector.polarPoint.azimuth-

					directionOfBoard
				);
		}

	

		static public double ScalarProject(planar.Vector4dblI vector, double directionOfBoard) {



			return  ScalarProject( planar.vect_.Polar4dbl.Of(vector) , directionOfBoard) ;
		}


		static public planar.vect_.Polar4dbl Project(planar.Vector4dblI vector, double directionOfBoard) {

			return new planar.vect_.Polar4dbl(
				directionOfBoard,
				ScalarProject(vector,directionOfBoard)
			);
		}

	/// <summary>
		/// 
		/// </summary>
		/// <param name="vector"></param>
		/// <param name="directionOfShine"></param>
		/// <returns>
		/// negative if the rotation is over half tau
		/// </returns>
		static public double ScalarRejection(planar.vect_.Polar4dbl vector, double directionOfShine) {


			return  vector.polarPoint.radius
				*
				Math.Sin(
					vector.polarPoint.azimuth-

					directionOfShine
				);
		}

		static public double ScalarRejection(planar.Vector4dblI vector, double directionOfBoard) {



			return  ScalarRejection( planar.vect_.Polar4dbl.Of(vector) , directionOfBoard) ;
		}

		static public double ScalarRejection(planar.Vect4dblI vector, double directionOfBoard) {



			return  ScalarRejection( planar.vect_.Polar4dbl.Of(vector) , directionOfBoard) ;
		}		static public planar.vect_.Polar4dbl Rejection(
			planar.Vect4dblI vector
			,
			double directionOfShine
		) {

			return new planar.vect_.Polar4dbl(
				directionOfShine + num.real_.TauX.QuarterD
				,

				ScalarRejection(vector,directionOfShine)
			);
		}

	}
}
