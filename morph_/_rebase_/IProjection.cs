using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.morph_._rebase_
{
	/// <see cref="rebase_.shear_.IInvertible"/>, where it shows that the projection is not the new coordinates.
	/// <summary>
	/// put the coord:P , as a col, to the right  of the matrix:M
	/// ,: MP
	/// = {row0, row1} * P
	/// = ( row0 . x,  row1 . y )
	/// = (x', y')
	/// , which means x',y' are regarded as the coords, so they are the new, not old, coords
	/// </summary>
	/// <remarks>
	/// old coord projected to the new coord
	/// </remarks>
	/// x, the old coord
	/// Mx, the new coord;
	/// MxM, according to <see cref="ICoordinate"/>, is (Mx)M the old coord, on condtion that the morph is involute;
	/// , when x = (Mx)M = x'M
	/// , then x/M = x'
	/// ; so, /M is the counter morph that would morph the old back into new.
	///
	/// also note: M\x/m = x
	/// <see cref="rebase_.orthic_.IUnial"/>
	public interface IProject {


	}
}
