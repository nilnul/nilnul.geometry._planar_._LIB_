using System;

namespace nilnul.geometry.planar.morph_
{

	/// <summary>
	/// 
	/// (x,y) * [2*m]
	/// , where the m, variable for <see cref="map_.IMatrixed"/>, here has to be two
	/// </summary>
	/// <seealso cref="IRebase"/>
	///alias:
	///		matric

	[Obsolete(
		nameof(IRebase)
	)]
	public interface IMatrix:
		//IRebase
		//,
		//trans_.affine_.IRebase
		//,
		map_.IMatrixed
	{

	}


}
