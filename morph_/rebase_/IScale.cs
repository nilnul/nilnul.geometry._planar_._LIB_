﻿namespace nilnul.geometry.planar.morph_
{
	/// <summary>
	/// the newbasis's azimuth is the same as old one respectively.
	/// 
	/// an extension of 1d transform scale (not including 1d transform_.Shift/Translate)
	/// </summary>
	/// <remarks>
	/// alias:
	///		zoom
	/// </remarks>
	public interface IScale:
		IIndepend
		,
		matrixed_.IScaleOnly

	{ }
}
