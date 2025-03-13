using System;

namespace nilnul.geometry.planar.map_
{
	/// <summary>
	/// <see cref="planar.vect.dich_.orthic_.IPerject"/>:
	/// projected onto a vect, and also scaled by that vect.
	/// </summary>
	/// <remarks>
	///
	/// </remarks>
	/// <see cref="vect.op_.unary_._ProjectionX"/>
	///		<seealso cref="vect.op_.unary_._TorqueForceX"/>
	///	the result is only dependent on the direction, not on the distance of the basis vect.
	///
	//[WronglyImplementation]
	//[Obsolete("old vector, even in the target vector direction, shall be also converted into the new space, as in fact they are two vectors in two spaces.",true)]
	static public class _PerjectX

	{
		
		/// <summary>
		/// <see cref=""/>
		/// </summary>
		/// <param name="tgtBasis"></param>
		/// <param name="point2proj"></param>
		/// <returns></returns>
		static public point_.Polar4dbl_radius1st Point(vect_.Polar4dbl_radius1st tgtBasis, Point4dblI point2proj) {
			return new point_.Polar4dbl_radius1st(
				planar.vect.co.to_.real_._DotProductX.Dbl(tgtBasis, point2proj)
				,
				tgtBasis.polarPoint.azimuth
			);
		}

		static public point_.Polar4dbl_radius1st Point(Vect4dblI tgtBasis, Point4dblI point2proj) {
			return Point(
				vect_.Polar4dbl_radius1st.Of(tgtBasis), point2proj
			);



		}



	}
}
