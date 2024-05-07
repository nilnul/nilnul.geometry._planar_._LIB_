namespace nilnul.geometry.planar_.geo_
{
	/// <summary>
	/// in the north semiglobe, the house is facing south; <see cref="planar.rotation_.IClockwise"/>; <see cref="geometry.planar.rotation_.ISun"/>;
	/// when one gets out of the house, standing at the stepping, his left is east, his right is west.
	///		x:
	///			from west to east, as the sun goes;
	///		y:
	///			from nearer to further, as the person goes
	///	<seealso cref="ergo_.level_.IBoard"/>
	/// </summary>
	/// <remarks>
	/// in line with the house, the seat is also facing south; and the east is at a prior status with respect to the west. For example, in China, 东 means host.
	/// </remarks>
	public interface IHouseInNorthSemiglobe { }
}
