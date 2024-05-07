namespace nilnul.geometry.planar.morph_.rebase_.orient_
{
	/// <summary>
	/// flip is not preferred to <see cref="IRotate"/> as it changes the sign of the stokes surrounded signed area.
	/// </summary>
	/// <remarks>
	/// we don't have the concept of handedness (<see cref="planar_.xpn_.IHandedness"/>) in non3d planar geometry. But we still have stokes sign, which is better preserved. 
	/// </remarks>
	public interface IFlip:IOrient { }



}
