using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Triangle = nilnul.geometry.planar.zone_.TriangleDbl;

namespace nilnul.geometry.planar.cycle_.trigon.be_
{
	public class RightDbl
		: nilnul.obj.be_.FroFunc<TriangleDbl>
		,
		trigon.BeDoubleI
	{

		static public bool Eval(TriangleDbl triangle)
		{

			return nilnul.num.real.double_.Eq.Default.Equals(
				triangle.getMaxAngle()
				,
				planar.RotationOfDouble.QuarterTau
			);

		}



		public RightDbl()
			: base(Eval)
		{

		}
	}



}
