using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.cycle_.triangle.point
{
	/// <summary>
	/// given <see cref="point"/> P, we get three <see cref="planar.line"/>s: PA, PB, PC
	/// for each such line, we get the reflected around the <see cref="vertex._BisectorX"/>.
	/// the three reflected would intersect at one point, which is this.
	/// </summary>
	/// <remarks>
	/// For a given point P in the plane of triangle △ABC, let the reflections of P in the sidelines BC, CA, AB be Pa, Pb, Pc. Then the center of the circle 〇PaPbPc is the isogonal conjugate of P
	///
	/// </remarks>
	internal class IsogonalConjugate
	{
		/*
		 The isogonal conjugate of the incenter of triangle △ABC is the incenter itself.


the isogonal conjugate of the orthocenter is the circumcenter.
		 */
	}


}
