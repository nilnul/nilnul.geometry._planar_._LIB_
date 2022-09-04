namespace nilnul.geometry.planar.facet_.gon_
{
	/// <summary>
	/// connect cycles into a single coil, by concuiting the bubbled air inside the hole out.
	/// the conduit searching might be expensive. but remove the conduit is easy to restore to <see cref="facet_.Gon4dbl"/>
	/// </summary>
	/// successive vertex pair are not same.
	/// edges are not cross. (vertex might be incident.)
	///		Hower, an edge can only be incident twice: one neg, one positive. and the two side of this edge must be inside the gon.

	public interface Conduit4DblI
		:
		facet_.Gon4dblI
	{

	}
}
