using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.curve_
{
	/// <summary>
	/// Roughly speaking, a roulette is the curve described by a point (called the generator or pole) attached to a given curve as that curve rolls without slipping, along a second given curve that is fixed.
	/// You can think of this as engaging gear.
	/// Formally speaking, the curves must be differentiable curves in the Euclidean plane. The fixed curve is kept invariant; the rolling curve is subjected to a continuous congruence transformation such that at all times the curves are tangent at a point of contact that moves with the same speed when taken along either curve (another way to express this constraint is that the point of contact of the two curves is the instant centre of rotation of the congruence transformation). The resulting roulette is formed by the locus of the generator subjected to the same set of congruence transformations.
	/// </summary>
	/// <remarks>
	/// alias:
	///		一般旋轮线
	/// </remarks>
	public interface IRoulette
	{
	}
}
