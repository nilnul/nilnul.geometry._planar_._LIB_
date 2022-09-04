using System.Collections.Generic;

namespace nilnul.geometry.planar.zone_.gon_
{
	public class Quod4dbl :
		gon.vow.ee_.VowNeo_ofInterface<
			gon.be_.quod.Vow4dbl
		>
		,
		_gon_.Vertexes4dblI
		,
		zone_.Polygon4dblI
	{
		public Quod4dbl(Polygon4dblI val) : base(val)
		{
		}

		public Quod4dbl(Point4dbl vertex0, Point4dbl vertex1, Point4dbl vertex2, Point4dbl vertex3)
			:this(
				 new Polygon4dbl_onPositiveCycle(vertex0
					 ,
					 vertex1
					 ,
					 vertex2
					 ,
					 vertex3
				)
		)
		{
		}

		public IEnumerable<Point4dblI> vertexes => ee.vertexes;

		public IEnumerable<Grad4dbl_byPointsI> grads =>ee.grads;
	}
}
