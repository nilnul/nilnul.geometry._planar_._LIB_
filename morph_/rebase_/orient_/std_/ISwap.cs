namespace nilnul.geometry.planar.morph_.rebase_.orient_
{
	/// <summary>
	/// 0,1
	/// 1,0
	/// </summary>
	/// <remarks>
	/// this negates the rotation of an angle.
	/// Thus this also negates the sign of the <see cref="planar.cloze_.gon._SurroundedX"/>;
	/// So this is not a good morph, as it changes the semantics of the original <see cref="planar.sub_.INonempty"/>
	/// </remarks>
	/// <see cref="flip_.IBisect"/>
	/// alias:
	///		flip around the bisect line.
	/// 
	public interface ISwap { }



}
