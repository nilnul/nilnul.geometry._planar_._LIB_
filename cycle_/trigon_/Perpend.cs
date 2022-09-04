using nilnul.geometry.planar.point.trio.be_.tripod.vow;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;
using nilnul.num;

namespace nilnul.geometry.planar.cycle_.trigon_
{

	public class Perpend :
		planar.cycle_.trigon.be_.perpend.vow.Ee
		,
		TrigonI
	{
		public IEnumerable<nilnul.num.RealI> _lengths;
		public Perpend(TrigonI val) : base(val)
		{
			_lengths = arrows.Select(l=> nilnul.geometry.planar.tend._DistanceX.Distance(l));
		}

		public Perpend(IEnumerable<PointI1> points):base(new Triangle(points))
		{
		}

		public IEnumerable<grad_.Arrow> arrows
		{
			get
			{

				var stream = new nilnul.obj.stream_.slider_.Cyclic_ofSeq<nilnul.geometry.planar.PointI1>(
					this.ee.pointTrio.ee
				);
				for (int i = 0; i < 3; i++)
				{
					yield return new grad_.Arrow(stream.current, stream.next());

				}
			}
		}
		public IEnumerable<planar.PointI1> pointsApexFirst {
			get {
				var stream = new nilnul.obj.stream_.slider_.Cyclic_ofSeq<nilnul.geometry.planar.PointI1>(
					this.ee.pointTrio.ee
				);

				for (int i = 0; i < apexIndex; i++)
				{
					stream.moveNext();
				}

				for (int i = apexIndex; i < apexIndex + 3; i++)
				{
					yield return stream.next();
				}
			}
		}

		public Ee pointTrio => base.ee.pointTrio;
		public planar.PointI1 apex
		{
			get
			{
				return this.pointTrio.ee.ElementAt(
					nilnul.num.real.str_.started_.distinct._MaxX._Index_ofAssumeStartedDistance(_lengths)
				);
			}
		}

			public IEnumerable<grad_.Arrow> arrowsHypotenuseFirst
		{
			get
			{

				var stream = new nilnul.obj.stream_.slider_.Cyclic_ofSeq<nilnul.geometry.planar.grad_.Arrow>(
					this.arrows
				);


				for (int i = 0; i < apexIndex; i++)
				{
					stream.moveNext();

				}

				for (int i = apexIndex; i < apexIndex+3; i++)
				{
					yield return stream.next();
				}
			}
		}
	

		public int apexIndex
		{
			get
			{
				return (
					nilnul.num.real.str_.started_.distinct._MaxX._Index_ofAssumeStartedDistance(_lengths)
				);
			}
		}

	}
}
