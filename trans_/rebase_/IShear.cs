using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.trans_.rebase_
{
	/// <summary>
	/// no scale; just shear.
	/// the newbasis's norm is one.
	/// 
	/// this is trans of space, not morph of objects. so shear means turn one or two axises.
	/// So the shear angel is the sweep of the axis, not the object.
	/// </summary>
	public interface IShear
		:
		rebase_.IShearOnly { }
	
}
