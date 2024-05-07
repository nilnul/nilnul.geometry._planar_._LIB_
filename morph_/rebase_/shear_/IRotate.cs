using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.morph_.matrixed_.shear_
{
	/// <summary>
	/// two axis rotates at the same angle.
	/// rotate both axis in same angel.
	/// </summary>
	/// <remarks>
	/// alias:
	/// 	Rotate
	/// 	uniform
	/// </remarks>

	public interface IRotate
		:IShear
		,
		matrixed_.IInvertible
	{
	}
}
