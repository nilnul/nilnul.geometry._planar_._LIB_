namespace nilnul.geometry.planar.map_
{
	/// <summary>
	/// borrowed from linear algebra. an coord multiplied by a 2xn matrix is a mapping into a new vector space. the matrix's rank can be anywhere between [0 ,2].
	/// </summary>
	/// <remarks>
	/// 	linear equation; i.e, the formula involves no term of which the exponent is more than 1. the exponent can be 1.
	/// this preserves the operations of vector addition and scalar multiplication.
	/// preserves addition and multi rules (still holds). thus the origin is still the origin
	/// the matrix (right mulitplication) is  2*n, where n is natural. so linear might not be trans( in trans_.Linear, the matrix must be 2*2)
	/// </remarks>
	/// alias:
	///		linear
	///		synonym to Matrixed.
	///		restrict
	///		regress
	///
	public interface IMatrixed { }

}
