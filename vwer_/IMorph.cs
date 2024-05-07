using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.vwer_
{
	/// <summary>
	/// in comparison with <see cref="planar.IMorph"/> which morphs either the object by <see cref="planar.morph_.ILocal"/>, or the coords by <see cref="planar.morph_.IGlobal"/>, but not both, here this morphs both at the same time.
	/// So for the former, the stokes sign might change by such as <see cref="planar.morph_.rebase_.orient_.IFlip"/>, or remain unchanged by such as <see cref="planar.morph_.rebase_.orient_.IRotate"/>.
	/// </summary>
	/// <remarks>
	/// we should avoid flipping morph, and only choose rigid <see cref="planar.morph_.affine_.rigid_"/>.
	/// </remarks>
	/// alias:
	///		rigid
	///			, the vwer, such as a connoisseur, doesnot alter things; the process is readonly. readers or audiences can add extra unobtrusive tags;
	///		morph
	public interface IRigid
	{
	}
}
