namespace nilnul.geometry.planar.map_
{
	/// <summary>
	/// 
	/// alias:transform.
	/// a special map:
	///		the target is 2d as well, whileas map can have target of any number of dimension
	/// </summary>
	/// <remarks>
	/// a <see cref="IMap"/> where a world is mapped to the same world with different coordinate system.
	/// <seealso cref="IMorph"/>
	/// </remarks>
	/// <seealso cref="planar.ITrans"/>
	public interface ITrans:IMap { }
}
