namespace nilnul.geometry.planar.morph_.rebase_
{
	/// <summary>
	/// the matrix is orthonorm.
	/// </summary>
	/// <remarks>
	/// the inverse matrix is its transpose.
	/// that means this morph is <see cref="nilnul.obj.op.be_.Involute"/>:
	///		MM x = x
	/// 
	/// </remarks>
	public interface IOrthonorm
		:
		orthic_.IUnial
		,
		IRebase
	{ }


}
