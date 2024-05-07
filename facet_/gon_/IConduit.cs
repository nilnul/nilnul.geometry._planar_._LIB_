
namespace nilnul.geometry.planar.facet_.gon_
{
	/// <summary>
	/// connect cycles into a single coil, by conduiting the bubbled air inside the hole out.
	/// Note: if two holes are pegged to the same point of the hull, the one with min veer is traversed first.
	/// the conduit searching might be expensive. but it is easy to remove the conduit  to restore to <see cref="facet_.Gon4dbl"/>
	/// </summary>
	/// <remarks>
	/// there might be 0 holes; there might be 1 hole, or 2 holes, etc.
	/// inside the hole, there is no more gons.
	/// to put gons inside hole, <see cref="gon.Nest"/>; but for that, the gon inside a hole is not connected, so it's better regarded as gons, and, if each is converted as a conduit, <see cref="conduit.INested"/>
	/// </remarks>
	/// successive vertex pair are not same.
	/// edges are not cross. (vertex might be incident.)
	///		Hower, an edge can only be incident twice: one neg, one positive. and the two side of this edge must be inside the gon.
	///
	public interface IConduit:IGon { }
}
