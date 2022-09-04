namespace nilnul.geometry.planar
{
	/// <summary>
	/// the arrow from one point to another; but the points can be the same. the pair forms a gradient which can be zero
	/// </summary>
	/// <remarks>
	/// alias:
	///		Grow
	///			:like Arrow, ending with "ow"
	///			:Grad, beginning with "gr"
	///		Move
	///		Grad:
	///			gradient
	///				derivative
	///		shift
	///			<see cref="nilnul.data_.state.Shift"/>
	///		
	/// </remarks>
	public interface IGrad : planar.vect.IBased, curve_.IFinite
	{

	}
}
