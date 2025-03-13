using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.morph_._rebase.matrix_
{
	/// <summary>
	/// the transpose of it is itself. 
	/// </summary>
	/// <remarks>
	/// that means (M x^T) = x M^T =xM
	/// eg:
	///		<see cref="morph_.IScale"/> is a such one. So it doesnot matter you use its <see cref="_rebase_.ICoordinate"/> or <see cref="_rebase_.IProject"/>
	///	but, for <see cref="morph_.affine_.ITranslateOnly"/> is not symmetric. So we can only use <see cref="_affine"/>
	///  </remarks>
    class ISymmetric
		:
		nilnul.num.real.matrix_.sq_.ISymmetric
		///nilnul.obj.matrix_.square_.Tertiary
		///nilnul.obj.matrix_.sq_.
    {
    }
}
