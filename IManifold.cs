﻿using nilnul.num;
using R = nilnul.num.Real;

namespace nilnul.geometry.planar
{

	/// <summary>
	/// this might be disconnected.
	/// 
	/// give natural number:n
	///		this is n-dimensional everywhere uniformaly.
	///		and
	///		this is topologically homotology to n-euclid space.
	///	eg:
	///		point
	///		line
	///		circle
	///		plane
	///	countereg:
	///		curve_: 8
	///		filed: 8
	///			it's 2d everywhere
	///			but it's not homotology to 2-dimensional euclid space, as the middle section point cannot be mapped continousely to a neighborhood of 2d euclid space
	///		
	/// </summary>
	/// alias:
	///		manifold
	///			"m"easure by length, or area, and the measure changes according tothe zoom rate. If the length changes in such way, it's 1d. if the area changes in such a way, it's 2d.
	/// <see cref="planar.ITope"/>
	public interface IManifold
		:crux_.IUniformDimension
	{
		
	}


}