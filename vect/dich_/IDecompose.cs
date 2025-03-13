using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.vect.dich_
{
	/// <summary>
	/// the sum of the resulted two (one might be nil) is the original
	/// </summary>
	/// <remarks>
	/// <see cref="planar.morph_.rebase_.shear_.IInvertible"/>
	/// </remarks>
	/// 
	/// decompose the vector into two vectors at the given <see cref="vect.co_.Cross"/> such that the resutled vects' sum is the original vect.
	///
	/// alias:
	///		decompose, related to dif.
	///		distribute
	///		partition
	///		Bisect
	///		bipartition
	///		bipartisan
	public interface IDecompose:vect.IDichnotomy
	{
	}


}
