using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using P = nilnul.geometry.planar.Point4dbl;
using E = nilnul.geometry.planar.tend_.EdgeD;
using nilnul.geometry.planar.grad_;
using nilnul.geometry.planar.point.trio.be_.tripod.vow;

namespace nilnul.geometry.planar.cycle_
{
	/// <summary>
	/// the area might be negative, but cannot be nil.
	/// </summary>
	public class TriangleDbl
		:planar.point.trio.be_.tripod.vow.EeD
		,
		zone_.gon_._tri_.ArrowsDblI
		,
		Triangle4dblI
	{
		


		public TriangleDbl(point.TrioD points):
			base(
				new point.TrioD(
				points.a,points.b,points.c
				)
				)
		{
			///the area might be negative.
			//if (points.angle()<Angle.HalfTau)
			//{
			//_points = points;

			//}
			//else
			//{
			//	_points = points.toReverse();
			//}
		}

		public TriangleDbl(double v1, double v2, double v3, double v4, double v5, double v6):this(
			new Point4dbl(v1,v2)
			,
			new Point4dbl(v3,v4)
			,
			new Point4dbl(v5,v6)
		)
		{
		}

		public TriangleDbl(P pointDbl1, P pointDbl2, P pointDbl3):this(new point.TrioD(pointDbl1, pointDbl2,pointDbl3))
		{
		}

		public TriangleDbl(Point4dblI point1, Point4dblI point, P tip):this(
			point1.ToOrthogonal(),point.ToOrthogonal(),tip
		)
		{
		}

		public TriangleDbl(Point4dblI alfa, Point4dblI bravo, Point4dblI charlie) : base(alfa, bravo, charlie)
		{
		}

		public TriangleDbl(IEnumerable<Point4dblI> enumerable)
			:this(
				 new point.TrioD(enumerable)
			)
		{
		}

		public IEnumerable<E> edges
		{
			get
			{
				yield return new E(this.ee. a, ee.b);
				yield return new E(ee.b, ee.c);
				yield return new E(ee.c, ee.a);
			}
		}

		public grad_.skid_.ByPoints4Dbl arrow0th => new grad_.skid_.ByPoints4Dbl(ee.a,ee.b);

		public grad_.skid_.ByPoints4Dbl arrow1st => new grad_.skid_.ByPoints4Dbl(ee.b,ee.c);

		public grad_.skid_.ByPoints4Dbl arrow2nd => new grad_.skid_.ByPoints4Dbl(ee.c,ee.a);

		public EeD points => this;

		public IEnumerable<Point4dblI> vertexes => points.ee;

		public IEnumerable<Grad4dbl_byPointsI> grads => new[] {
			arrow0th,arrow1st,arrow2nd
		};

		public E edge_ab() {
			return new E(ee.a,ee.b);
		}

		public E edge_bc() {
			return new E(ee.b,ee.c);
		}
		public E edge_ca() {
			return new E(ee.c,ee.a);
		}

		public double area() {
			return planar.coil_.gon._SurroundedX.Area(ee);
		}

		public E getOneMaxEdge() {
			return tend_.edge.str_.started.subsume_._MaxX._Max(edges);
		}

		public int getIndexOppositeToOneMaxEdge() {
			
				return 
					obj.s.IndexOfX.IndexOf(
						edges
						, getOneMaxEdge()
					)
				;
		}

		public Point4dbl getPointOppositeToOneMaxEdge() {
			
				return this.boxed.ElementAt(
					obj.s.IndexOfX.IndexOf(
						edges
						, getOneMaxEdge()
					)
				);
		}

		public double getMaxAngle() {
			return new nilnul.geometry.planar.angle_.Points4dbl(rearrangePointsAsMaxAngle()).azimuth;
		}

		public IEnumerable<Point4dbl> rearrangePointsAsMaxAngle() {
			var index = getIndexOppositeToOneMaxEdge();

			var pivot = boxed.Where((e,i)=>i==index).First();

			var otherPoints = boxed.Where((e, i) => i != index);


			var r = new List<Point4dbl>();
			r.Add(otherPoints.ElementAt(0));
			r.Add(pivot);
			r.Add(otherPoints.ElementAt(1));
			return r;
		}

		public static TriangleDbl Of(Triangle4dblI v)
		{
			return v switch
			{
				TriangleDbl a => a
				,
				_ => new TriangleDbl(v.vertexes)
			};
		}
	}
}
