namespace nilnul.geometry.planar.point.trio.sig_
{
	/// <summary>
	/// colinar, negative, positive
	/// </summary>
	static public class _Coil4dblX
	{
		/// <summary>
		/// 
		/// </summary>
		/// <param name="a"></param>
		/// <param name="b"></param>
		/// <param name="c"></param>
		/// <returns>
		/// true if last point is at the positive side
		/// false if last point is at the negative side
		/// </returns>
		static public bool? Sig( Point4dbl a,Point4dbl b, Point4dbl c) {


			return nilnul.num.real._SignDblX.BitNul(
				planar.vect.co.to_.real_._CrossProductX.SurroundedOfParallelogram(
					b-a
					,
					c-b
				)
			);

		}
		static public bool? Sig( Point4dblI a,Point4dblI b, Point4dblI c) {

			return Sig( Point4dbl.Of(a), Point4dbl.Of(b),Point4dbl.Of (c));

		}

	}
}
