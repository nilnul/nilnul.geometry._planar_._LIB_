using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.vect.to_.co_.decompose
{
	/// <summary>
	///  this decomposed force will have 0impact along the given direction as it's perpendicular to the direction; so it's dicarded/rejected.
	/// </summary>
	/// alias:
	///		leg
	///			
	///		shed
	///			shed some sunshine, which is originated from the tip of the vector into a direction until the crosssection(which is perpendicualr to the sunshine) passes thru the origin.
	///		shadow
	///				
	///		rejection
	///			conjugate with projection
	///		torque
	///			just force, not taking into account of distance.
	///			Turning force
	///			torforce
	///				turning force
	///				this is not torque, which involves the radius distance, but only the force that is decomposed component perpendicular to the radius
	///			rotor
	///			turbine
	///			wrench
	///			torque force
	///		shed
	///			shed light
	/// 
	static public class _RejectionX
	{


		/// <summary>
		/// torque for the ray
		/// </summary>
		/// <remarks>
		///	/// regards the vect as a point, and compute the perpendicular leg(the point to the perpendicular foot)
		/// </remarks>
		/// <param name="point">from the origin</param>
		/// <param name="directionOfPrimaryAxis">ray from the origin</param>
		/// <returns>
		/// a vector perpendicular to <paramref name="directionOfPrimaryAxis"/>.the component resoluted along the perpendicular of <paramref name="directionOfPrimaryAxis"/>
		/// 
		/// negative if the rotation is over half tau
		/// 
		/// </returns>
		static public double RejectionRadius(planar.vect_.Polar4dbl point, double directionOfPrimaryAxis) {


			return  point.polarPoint.radius
				*
				Math.Sin(
					point.polarPoint.azimuth
					-

					directionOfPrimaryAxis
				);
		}

		static public double RejectionRadius(planar.Vector4dblI vector, double directionOfPrimaryAxis) {



			return  RejectionRadius( planar.vect_.Polar4dbl.Of(vector) , directionOfPrimaryAxis) ;
		}

		static public double RejectionRadius(planar.Vect4dblI vector, double directionOfPrimaryAxis) {


			return  RejectionRadius( planar.vect_.Polar4dbl.Of(vector) , directionOfPrimaryAxis) ;
		}



		/// <summary>
		/// 
		/// </summary>
		/// <param name="vector">
		/// a point
		/// </param>
		/// <param name="directionOfPrimaryAxis">stands for a lead<see cref="geometry.planar.ILead"/>(directed line), which happens to pass thru origin.</param>
		/// <returns></returns>
		///
		[Obsolete()]
		static public planar.vect_.Polar4dbl Rejection(
			planar.Vect4dblI vector
			,
			double directionOfPrimaryAxis
		) {

			return new planar.vect_.Polar4dbl(
				directionOfPrimaryAxis + num.real_.TauX.QuarterD	/// the  y-axis is ratated positively from the x-axis.
				,

				RejectionRadius(vector,directionOfPrimaryAxis)
			);
			// if the radius is negative, the normalized azimuth would be opposite to the unnormalized. and the result is still from foot to the point.
		}
		/// <summary>
		/// 
		/// </summary>
		/// <param name="vector"></param>
		/// <param name="directionOfPrimaryAxis">if it changs by Math.Pi, radius would change to opposite, the result would be the same</param>
		/// <returns> the leg pointing from foot to point</returns>
		static public planar.vect_.Polar4dbl_radius1st Rejection1(
			planar.Vect4dblI vector
			,
			double directionOfPrimaryAxis
		) {

			return new planar.vect_.Polar4dbl_radius1st(
				RejectionRadius(vector,directionOfPrimaryAxis)
				,
			directionOfPrimaryAxis + num.real_.TauX.QuarterD	/// the  y-axis is ratated positively from the x-axis.

			);
			// if the radius is negative, the normalized azimuth would be opposite to the unnormalized. and the result is still from foot to the point.
		}

		public static planar.vect_.Polar4dbl_radius1st Rejection(Point4dblI point, double lineAlignmentUnnormalized)
		{
			return Rejection1(
				new planar.Vect4dbl(point)
				,
				lineAlignmentUnnormalized
			);
			//throw new NotImplementedException();
		}
	}
}
