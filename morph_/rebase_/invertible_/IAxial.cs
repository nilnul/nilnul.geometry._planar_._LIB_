using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.morph_.rebase_.invertible_
{

	/// <summary>
	/// each vec is <see cref="nilnul.num.real.vec.be_.IAxial"/>
	/// </summary>
	/// <remarks>
	/// as it's invertible, the vec cannot be zero, but <see cref="nilnul.num.real.vec.be_.axial_.INonNil"/>
	/// </remarks>
	public interface IAxial: nilnul.geometry.planar.morph_.matrixed_.IInvertible
	{
	}
}
