using nilnul.geometry.planar.morph_;

namespace nilnul.geometry.planar.morph_.rebase_
{
	/// <summary>
	/// eg:
	///		1,0
	///		0,1
	///	eg:
	///		1,0;
	///		0,-1
	/// </summary>
	/// alias:
	///		reorient
	///	<see cref="nilnul.geometry.linear.morph_.IOrient"/>
	public interface IOrient
		:
		invertible_.axial_.IUnial
		,
		IRebase
	{ }
}
