namespace nilnul.geometry.planar
{
	/// point or curve.
	///  the dimension is no more than 1.including:
	///		point, which is 0 in dimension
	///	cantor set, the dimension is in (0,1), would be discussed later, as a stream of trails, not here.
	/// <summary>
	/// point or curve.
	/// point 0 curve can be sequential. 
	/// 0d, 1d,  excluding 2d objects.
	/// </summary>
	/// <remarks>
	/// <seealso cref="nilnul.geometry.linear.IDrawable"/>
	/// excluding xD, where x is in (0,1).
	/// also exclude anything more than 1d.
	/// like traversing a tree, there is always a node called root;
	/// </remarks>
	///
	/// <seealso cref="linear.ITope"/>
	/// alias:
	///		trip
	///		patrol
	///		trek
	///		trace,where c implies curve
	///			,vs trail, where l implies a line, which is undirected
	///		tread
	///		trot
	///
	public interface ITroll:crux_.IUniformDimension,manifold_.INil0oneDimension{ }




}
