namespace nilnul.geometry.planar.facet_
{
	/// <summary>
	/// holed or not.
	/// when holed, it can be converted by <see cref="facet_.holed_.gon.to_.ICoil"/>
	///
	/// There might be muliple holes (eg: 0 holes, 1, 2 holes). The inner is still roadable. And the edge is still a <see cref="coil_.IGon"/> where some grads might be incident (imagining cuting from the hole to outside.).
	/// </summary>
	public interface IGon
	{
	}
}