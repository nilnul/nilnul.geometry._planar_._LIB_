using R = nilnul.num.RealI;

namespace nilnul.geometry.planar.vect.co.to_
{
	/// <summary>
	/// a matrix with one vector on the other.
	/// </summary>
	static public class _AsMatrixX
	{
		static public nilnul.num.real.matrix_.square_.Secondary Fro(VectorI a, VectorI b) {
			return new num.real.matrix_.square_.Secondary(
				a.x,a.y,b.x,b.y	
			);
		}

		static public nilnul.num.real.matrix_.square_.Secondary ToMatrixRows(VectorI a, VectorI b) {
			return new num.real.matrix_.square_.Secondary(
				a.x,a.y,b.x,b.y	
			);
		}

		static public double[,] ToMatrixRows(Point4dblI a, Point4dblI b) {
			return new double[,] {
				{ a.x,a.y }
				,
				{ b.x,b.y }
			};
		}

		/// according to 3blue1brown's video: youtube.com/watch?v=eu6i7WJeinw
		/// ,
		/// *Note, in all the computations here, I list the coordinates of the vectors as columns of a matrix, but many textbooks put them in the rows of a matrix instead.  It makes no difference for the result, since the determinant is unchanged after a transpose, but given how I've framed most of this series I think it is more intuitive to go with a column-centric approach.
		/// <summary>
		/// </summary>
		/// <param name="a"></param>
		/// <param name="b"></param>
		/// <returns></returns>
		static public double[,] ToMatrixCols(Point4dblI a, Point4dblI b) {
			return new double[,] {
				{ a.x,b.x }
				,
				{ a.y,b.y }
			};
		}

		static public double[,] ToMatrixRows(Vect4dblI a, Vect4dblI b) {
			return ToMatrixRows(a.point,b.point);
		}


		public static double[,] ToMatrixRows(Vector4dblI a, Vector4dblI b)
		{
			return ToMatrixRows(a.point,b.point);

		}


		static public nilnul.num.real.matrix_.square_.Secondary Fro(IVector a, IVector b) {
			return new num.real.matrix_.square_.Secondary(
				a.point.x,a.point.y,b.point.x,b.point.y	
			);

		}

		static public nilnul.num.real.matrix_.square_.Secondary Fro(Vector1 a, Vector1 b) {
			return new num.real.matrix_.square_.Secondary(
				a.point.x,a.point.y,b.point.x,b.point.y	
			);
		}

	

		static public nilnul.num.real.matrix_.square_.Secondary To(Co duo) {
			return Fro(duo.Item1,duo.Item2);
		}

		public static double GetDeterminant(Vect4dblI x, Vect4dblI y)
		{
			return nilnul.num.real.matrix_.square.to_.scalar_._DeterminantX._Determinant_assumeSquare(
			 ToMatrixRows(x,y)
			 );
		}
		public static double GetDeterminant(Vector4dblI x, Vector4dblI y)
		{
			return nilnul.num.real.matrix_.square.to_.scalar_._DeterminantX._Determinant_assumeSquare(
			 ToMatrixRows(x,y)
			 );

		}

		public static double GetDeterminant(Point4dblI x, Point4dblI y)
		{
			return nilnul.num.real.matrix_.square.to_.scalar_._DeterminantX._Determinant_assumeSquare(
				ToMatrixRows(x,y)
			 );
		}

		static public R GetDeterminant(PointI1 a, PointI1 b) {

			return Fro((Vector1)a, (Vector1)b).getDeterminant();
		}


		static public R GetDeterminant(VectorI a, VectorI b) {
			return Fro(a, b).getDeterminant();
		}
		static public R GetDeterminant(Vector1 a, Vector1 b) {
			return Fro(a, b).getDeterminant();
		}


		static public R GetDeterminant(IVector a, IVector b) {
			return Fro(a, b).getDeterminant();
		}

	}
}
