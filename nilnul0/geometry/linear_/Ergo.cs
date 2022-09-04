using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.linear_
{
	/// <summary>
	/// a one dimension geometry per the perspective of researcher (where the human stands).
	/// when we study an object that is linear such as a stick, we place the object before us. we place the object always horizontally or latitudely or transversly. <see cref="nameof(ergo_.horizon_.ILeft2right)"/>
	/// ------------------------------------------------
	/// why horizon
	///		not from dow to top,
	///			when from left to right, we can walk from left to right. but it's hard to climb from upside to top due to gravity
	///		not from back to forth
	///			we have a bigger perspective angle from left to right.
	///			our pair of eyes are horizontal. were object place from back to front, the observer angle (angle of view ) is too small.
	///		from left to right,
	///			we in screen, in book (minor portion of languages are from right to left)
	///
	/// -----------------------------------------------------
	///	We also define the axis points from left to right.	why from left to right?
	///		out left eye is at the side of the heart. Heart is the origion, and right eye departs from origin
	///		on the screen, in the row, we start from left to right.
	///		on the book, in a line, we read from left to right.
	///			on the book, it's line-major
	///			though there are languages from right to left.
	///		on the matrix
	///			 it's row-major.
	///		our two eyes are horizontally layouted.
	///			eyes are nearer when object is placed horizontally
	///			horizontal sight has the biggest angle, bigger than vertial
	/// </summary>
	/// <remarks>
	/// nomenclature:
	///		ergonomics
	///	alias:
	///		humanoid
	///		artificial
	///		manual
	///		manned
	///		man
	///
	///  for example, when we face the river, we say how long the river is; how wide/broad the rive is the measure from our back to our forth.
	///		河真宽 is different from 长河
	/// </remarks>
	public interface IErgo
		:ILinear
	{
	}
}
