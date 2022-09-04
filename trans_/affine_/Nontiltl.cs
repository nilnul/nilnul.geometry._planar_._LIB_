using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.trans_.affine_
{
	/// <summary>
	/// visuall maps to a rect(might be trivia)
	/// 
	/// the matrix is orthogonal; ie, the two cols are perpendicular (one col might be nil. or two nils are both nil.)
	///
	/// the translation part is not constrained here.
	/// 
	/// </summary>
	/// <remarks>
	/// alias:
	///		orthogonal
	///			linear_.orthogonal first, then translate
	///			<seealso cref="nameof(affine_.INoShear)"/>
	///			<seealso cref="nameof(independ_.IAffine)"/>
	/// </remarks>
	 public interface INontilt
	{
		
	}

}
