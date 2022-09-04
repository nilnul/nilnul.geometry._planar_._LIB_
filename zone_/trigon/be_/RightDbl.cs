using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Triangle = nilnul.geometry.planar.zone_.TriangleDbl;

namespace nilnul.geometry.planar.zone_.trigon.be_
{
	public class RightDbl
		: nilnul.obj.be_.FroFunc<Trigon4dblI>
		,
		trigon.BeDoubleI
	{

		static public bool Eval(TriangleDbl triangle)
		{

			return nilnul.num.real.double_.Eq.Default.Equals(
				triangle.ee.getMaxAngle()
				,
				planar.RotationOfDouble.QuarterTau
			);

		}

		static public bool Eval(Trigon4dblI triangle)
		{

			return Eval(
				new TriangleDbl(triangle.points)
			);
			

		}



		public RightDbl()
			: base(Eval)
		{

		}
	}



}
