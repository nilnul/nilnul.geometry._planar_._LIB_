using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.morph_.rebase_
{
	/// <summary>
	/// 
	/// the matrix is orthogonal; ie, two cols are perpendicular. one col might be nil; or two cols are both nil.
	/// this involves shear, also involve scale.
	/// </summary>
	/// <remarks>
	/// 
	/// </remarks>
	public interface IOrthogonal
		:
		IRebase
		//INonaffine
	{
		///using an orthonal matrix (a new basis)

	}
	/// 
	/// preserve innerProduct. Since the lengths of vectors and the angles between them are defined through the inner product, orthogonal transformations preserve lengths of vectors and angles between them.
	/// In particular, orthogonal transformations map orthonormal bases to orthonormal bases.
	/// Alias:
	///		Stiff
	///		not Rigid, as no translate happens are allowed
}
