using nilnul.geometry.planar.point;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.curve_.polystep_
{
	/// <summary>
	/// one step and the other in succession
	/// </summary>
	public class Di4dbl
		:
			planar.point.trio.be_.steps.vow.Ee4dbl
		
		,

		IPolystep
		,
		curve_._polystep_.Grads4dblI
	{
		public Di4dbl(TrioD val) : base(val)
		{
		}

		public Di4dbl(Point4dblI basis1, Point4dblI basis2, Point4dblI finish):this(
			new TrioD(basis1,basis2,finish)
		)
		{
		}

		public IEnumerable<Grad4dbl_byPointsI> grads
		{
			get
			{
				yield return new Grad4dbl_byPoints(
					ee.a,ee.b
				);
				yield return new Grad4dbl_byPoints(
					ee.b,ee.c
				);

				//throw new NotImplementedException();
			}
		}
	}
}
