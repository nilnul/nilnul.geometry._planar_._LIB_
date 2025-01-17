﻿namespace nilnul.geometry.planar.morph_
{
	/// <summary>
	/// a new basis is provided for the coords. the coords is interpretated using the new basis, then the result is interpreted using the old axises system.
	/// 
	/// the matrix is 2*2. the rank of the matrix can be not full (eg: the two base might be the same.). In other words, it can be 0 or 1. (for <see cref="nameof(map_.ILinear)"/>, the matrix is not 2*2)
	///
	/// This maps the old vector space to a new vector space. 
	/// (0th,1st) * [v1,v2  ]^T. =0th*v1 + 1st*v2. we take v1 as the new horizon axis , and v2 as the new vertical axis, thus in new vect orspace, the coord (0th,1st) referes to a point in new vector space, which in old vector space is (0th*v1+1st*v2).
	/// This is in fact maps the old orthogonal vector basis to the parallelogram vector pair.
	/// 
	/// </summary>
	/// <remarks>
	/// the axis are first stretched. then sheared (shear is vivid as we use the two axis as a scissor where origin is the hinge, axis positive part is the cutting edge and negtive part is the handle).
	///
	/// note: dotnet matrix is associated from right, keeping the coords at left. while in math books, the matrix is often associated from left.
	/// </remarks>
	/// alias:
	///		resettle
	///		rehabilitate
	///		refoot
	///		reline
	///		rehab
	///		remeasure
	///		remap
	///		rematric
	///			,remat
	///		reparallelogram
	///		
	///		
	///		pseudobase
	///		
	///		recoord
	///		reduct
	///		refound
	///		refund
	///		reference
	///		respan
	///		resys
	///		redef
	///		reord
	///		reordinate
	///		reanchor
	///		skew
	///		reskew
	///		
	///		remap
	///		reinterpret
	///		rebase
	///			,define a new linear space, which might be 1d, or 0d, as the matrix might regress. but it's still a base, shrinkable as it is redundant in some case.
	///			,but the matrix might be not a linear algebra base, as it can rank le 1.
	///		matrix2sq
	///		nontranslate
	///		linear
	///
	public interface IRebase:
		matrixed_.IInvertible

		//trans_.affine_.IRebase
		,
		map_.ILinear
		,
		map_.IMatrixed
	{

	}


}
