using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.crux_
{
	/// <summary>
	/// no singular point.
	/// this might be a <see cref="planar.ICurve"/>
	/// or <see cref="planar.ISpread"/>
	/// or <see cref="planar.ISpread"/> connected with <see cref="planar.ICurve"/>
	/// </summary>
	/// this is equivalent to non<see cref="crux_.IUniformDimension"/>
	public interface INonsingular
		:ICrux
	{
	}
}
