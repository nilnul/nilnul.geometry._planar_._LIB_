namespace nilnul.geometry.planar
{
	/// <summary>
	/// the arrow from one point to another; but the points can be the same. the pair forms a gradient which can be zero
	/// </summary>
	/// <remarks>
	/// eg:
	///		from A to B is often denoted as AB with an overhead rightward arrow;
	/// </remarks>
	/// alias:
	///		Grow
	///			:like Arrow, ending with "ow"
	///			:Grad, beginning with "gr"
	///		Move
	///		Grad:
	///			gradient
	///				derivative
	///			,part of grid
	///		shift
	///			<see cref="nilnul.data_.state.Shift"/>
	///		step
	///			<see cref="nilnul.geometry.linear.IGrad"/>
	///		
	/// 
	public interface IGrad : planar.vect.IBased, curve_.IFinite
	{

	}
}
