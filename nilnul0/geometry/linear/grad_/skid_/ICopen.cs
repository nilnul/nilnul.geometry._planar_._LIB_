namespace nilnul.geometry.linear.grad_.skid_
{
	/// <summary>
	/// a point, unioned with an <see cref="IOpen"/>. The point is <see cref="original.IPoint"/>, 0d, and the <see cref="IOpen"/> is 1d.
	/// This is favored in decomposing a large skid, as the partition is a cover (pass each point once and only once).
	/// </summary>
	/// <remarks>
	/// this helps define <see cref="planar.cycle_.circ"/>
	/// </remarks>
	internal class ICopen:ISkid
	{
	}

}
