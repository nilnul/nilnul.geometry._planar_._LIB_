using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Point = nilnul.geometry.planar.Point4dbl;
using EdgeD = nilnul.geometry.planar.tend_.EdgeD;

using DistinctPoints = nilnul.geometry.planar.point.trio.be_.distinct.vow.Ee;
using PointD = nilnul.geometry.planar.Point4dbl;
using Point1 = nilnul.geometry.planar.Point4dbl;
using nilnul.geometry.planar.grad_;

namespace nilnul.geometry.planar.cycle_.gon_.quad_
{
	/// <summary>
	/// area might be negative.
	/// </summary>
	/// 
	public class ParlgrmDbl
		:
		nilnul.obj.Box1< planar.cycle_.TriangleDbl >
		,
		_gon_.ArrowFirstThreeDblI
		,
		_gon_.Arrow3rdI
	{

		public ParlgrmDbl(TriangleDbl val) : base(val)
		{
		}

		public ParlgrmDbl(Point4dbl a, Point4dbl b, Point4dbl c):this(new TriangleDbl(a,b,c))
		{

		}

		public Point4dbl a
		{
			get { return boxed.ee.a; }
		}


		public Point4dbl b
		{
			get { return boxed.ee.b; }
		}

		public Point4dbl c
		{
			get { return boxed.ee.c; }
		}


		public Point4dbl d
		{
			get {

				return a+c-b ;

			}
		}

		public grad_.skid_.ByPoints4Dbl arrow0th => boxed.arrow0th;

		public grad_.skid_.ByPoints4Dbl arrow1st => boxed.arrow1st;

		public grad_.skid_.ByPoints4Dbl arrow2nd => new grad_.skid_.ByPoints4Dbl(c,d);

		public grad_.skid_.ByPoints4Dbl arrow3rd => new grad_.skid_.ByPoints4Dbl(d,a);

		public EdgeD edge_ab() {
			return -boxed.edge_ab();
		}

		public EdgeD edge_bc() {
			return boxed.edge_bc();
		}

		
		

		public EdgeD edge_cd() {
			return new EdgeD(c, d);
		}
	
		public EdgeD edge_da() {
			return new EdgeD( d,a);
		}

	


	}
}
