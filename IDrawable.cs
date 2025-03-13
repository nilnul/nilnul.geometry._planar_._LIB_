using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar
{
	/// <summary>
	/// This is a property that holds since 1d.
	/// 
	/// </summary>
	///	alias:
	///		figure
	///			,used in System.Drawing as part of a path
	///		tangible
	///			for other objects to be tangent with this one at some point, the point has to be there.
	///		<see cref="points_.dwelt"/>
	///		nonhollow
	///		palpable
	///		palp
	///			,same initial as <see cref="planar.IPoint"/>, backnonymed as: Points, Et Al of Points;
	///		falt
	///		tramp
	///		trek
	///	<see cref="dwelt"/>
	///	<see cref="amalgram"/>
	///		cloud
	///		
	public interface IDrawable:
		flat_.IBoundaried
		,
		sub_.INonempty

	{
	}

}
	/// 0d, 1d, 2d, 1.5d, 0.5d. but not empty
