using nilnul.geometry.planar.point.trio.be_.tripod.vow;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.zone_.trigon_.equilateral_
{
	public class BaseOne4Dbl
		:
		cloze_.trigon_.BaseOne4DblA
		,
		zone_.Trigon4dblI

	{
		public BaseOne4Dbl() : base(
			new Point4dbl(
				0.5
				,
				nilnul.num.real_.geometry_.planar_._TrignoX.SqrtThree_Ov_Two
			)
		)
		{
		}

		public EeD points => new EeD(alfa,base.bravo,base.charlie);

		public IEnumerable<Grad4dbl_byPointsI> grads => new Grad4dbl_byPointsI[] {
			new Grad4dbl_byPoints(base.alfa,base.bravo)
			,
			new Grad4dbl_byPoints(base.bravo,base.charlie)
			,
			new Grad4dbl_byPoints(base.charlie,base.alfa)
		};
	}
}
