using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.morph_
{
	/// <summary>
	/// (x,y) => (f(x), g(y) where f,g are two separate functions. f(x) is not dependepnt on y; g(y) is not dependent on x.
	/// 
	/// transform each axis independently together. the transform of each axis is 1d trans, including scale and shift.
	/// not including shear, which rotates each axis independently, unable to happen in 1d.
	/// </summary>
	public interface IIndepend
	{
	}
}
