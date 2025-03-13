using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.morph_
{
	/// <summary>
	/// turn the axises. the rotation of the two angles can differ.
	/// 
	/// shear only. no rotation.
	/// horizonal shear or vertical shear.
	/// also known as slant
	/// </summary>
	/// <remarks>
	/// each row is unial.
	/// the col can be ununial.
	/// </remarks>
	/// alias:
	///		decompose, as in physics/mechanics, to decompose a force by parallelogram;
	public interface IShearOnly
	{
	}
}
