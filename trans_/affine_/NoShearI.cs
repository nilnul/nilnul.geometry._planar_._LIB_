using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.trans_.affine_
{
	/// <summary>
	/// in linear, only use scale, no shear.
	/// translate can be used.
	/// </summary>
	public interface INoShear:trans_.independ_.IAffine
	{
	}
}
