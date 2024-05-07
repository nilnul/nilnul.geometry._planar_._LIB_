using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.morph_.affine_
{
	/// <summary>
	/// rotate, translate;
	/// excluding: flip, which changes the sign of stokes surrounded signed area.; and to flip a rigid area, we have to leave the plane and do it in 3d space.
	/// </summary>
	public interface IRigid
	{
	}
}
