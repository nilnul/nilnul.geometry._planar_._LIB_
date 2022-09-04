using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.crux_
{
	/// <summary>
	/// point and curve can be directed
	/// all directed must be either curve or point.
	/// a 2d area has no direction.
	/// </summary>
	///
	public interface IDirectable
		:
		ICrux
		,
		sub_.IDirected
	{
	}
}
