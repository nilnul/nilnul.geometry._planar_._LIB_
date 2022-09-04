using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.geometry.planar.point;

namespace nilnul.geometry.planar
{
	/// <summary>
	/// the arrow from one point to another; but the points can be the same. the pair forms a gradient which can be zero
	/// </summary>
	/// <remarks>
	/// alias:
	///		Move
	/// </remarks>
	public interface Grad4dbl_byPointsI:
		_grad_.Basis4dblI
		,
		_grad_.Finish4dblInInterfaceI
		,
		IGrad
	{
	}

}
