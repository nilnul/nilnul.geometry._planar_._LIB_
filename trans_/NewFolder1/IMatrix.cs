using System;

namespace nilnul.geometry.planar.trans_
{

	[Obsolete(
		nameof(IRebase)
	)]
	public interface IMatrix:
		IRebase
		,
		trans_.affine_.IRebase
		,
		map_.ILinear
	{

	}


}
