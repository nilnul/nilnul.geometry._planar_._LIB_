namespace nilnul.geometry.planar
{
	/// <summary>
	/// <seealso cref="nameof(nilnul.geometry.linear.IBar)"/>
	/// </summary>
	/// <remarks>
	/// cannot be defined by the bounding box ( <seealso cref="nameof(planar.IBloc)"/>), as the diagonal pointing to negative width is not definable(the defined is always the diagonal pointing to smaller width)
	/// 
	///
	/// </remarks>
	/// alias:
	///		tend
	///			like in "tendon", "tender"
	public interface ITend : ITrace
	{

	}

}
