using nilnul.geometry.planar.point_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.zone_.gon_.quad
{
	/// <summary>
	/// </summary>
	public class Parameterize
		:
		nilnul.obj.Box1<
			planar.zone_.gon_.Quod4dbl
		>
		,
		drawable._morph_.OfPoint4DblI

	{
		public Parameterize(Quod4dbl val) : base(val)
		{
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="proportionsAtUnitSquare"></param>
		/// <returns></returns>
		public Point4dbl morphAsClass(Point4dblI proportionsAtUnitSquare)
		{
			var OneMinusProportionX = 1 - proportionsAtUnitSquare.x;
			var OneMinusProportionY = 1 - proportionsAtUnitSquare.y;

			var vertexes= boxed.ee.vertexes.ToArray();

			var p0 = vertexes[0];
			var p1 = vertexes[1];
			var p2 = vertexes[2];
			var p3 = vertexes[3];

			return p0.ToOrthogonal() * OneMinusProportionX * OneMinusProportionY
				+
				p1.ToOrthogonal() * proportionsAtUnitSquare.x * OneMinusProportionY
				+
				p2.ToOrthogonal() * proportionsAtUnitSquare.x * proportionsAtUnitSquare.y
				+
				p3.ToOrthogonal() * OneMinusProportionX * proportionsAtUnitSquare.y
			;


		}

		public (double,double) toCoordInUnitSquare(double i, double j)
		{

			return toCoordInUnitSquare( new Point4dbl(i,j) );

		}

		public Point4dbl toCoordInUnitSquareAsPointClass(double i, double j)
		{

			return new Point4dbl( toCoordInUnitSquare(i,j ) );

		}


		public Point4dblI morph(Point4dblI proportionsAtUnitSquare)
		{
			return morphAsClass(proportionsAtUnitSquare);
		}

		public Point4dbl morphAsClass(double proportionX, double proportionY)
		{
			return morphAsClass(
				new Point4dbl(proportionX,proportionY)
			);
		//	throw new NotImplementedException();
		}

		public (double,double) toCoordInUnitSquare(Point4dblI pointInQuad)
		{
			var vertexes = boxed.vertexes.ToArray();
			var p1 = vertexes[0];
			var p2 = vertexes[1];
			var p3 = vertexes[2];
			var p4 = vertexes[3];

			double x1 = p1.x, y1 = p1.y ,x2=p2.x,y2=p2.y
				,
				x3=p3.x,y3=p3.y,x4=p4.x,y4=p4.y;

			double x = pointInQuad.x, y = pointInQuad.y;

			double v_sqrt = Math.Sqrt(
		4 * (
		(x3 - x4) * (y1 - y2) - (x1 - x2) * (y3 - y4)) * (x4 * (-1 * y + y1) + x1 * (y - y4) + x * (-1 * y1 + y4)) +
		Math.Pow(
		(x3 * y - x4 * y - x3 * y1 + 2 * x4 * y1 - x4 * y2 + x1 * (y + y3 - 2 * y4) + x2 * (-1 * y + y4) + x * (-1 * y1 + y2 - y3 + y4))
		, 2)
		);

			double u_sqrt = Math.Sqrt(
					4 * ((x3 - x4) * (y1 - y2) - (x1 - x2) * (y3 - y4))
					* (
						x4 * (-1 * y + y1) + x1 * (y - y4) + x * (-1 * y1 + y4)
					) +
					Math.Pow(
					(x3 * y - x4 * y - x3 * y1 + 2 * x4 * y1 - x4 * y2 + x1 * (y + y3 - 2 * y4) + x2 * (-1 * y + y4) + x * (-1 * y1 + y2 - y3 + y4))
					, 2)
				);

			double k = 1 / (2 * ((x3 - x4) * (y1 - y2) - (x1 - x2) * (y3 - y4)));
			double l_ = 1 / (2 * ((x1 - x4) * (y2 - y3) - (x2 - x3) * (y1 - y4)));

			///////////////////////////////////////////////////////////////////////////////////////////////
			double v1 = l_ *
				(x2 * y - x3 * y + x4 * y + x * y1 - 2 * x2 * y1 + x3 * y1 - x * y2 - x4 * y2 + x * y3 - x1 * (y - 2 * y2 + y3) - x * y4 + x2 * y4 +
				v_sqrt);

			///////////////////////////////////////////////////////////////////////////////////////////////
			double u1 = -1 * k *
				(-x2 * y + x3 * y - x * y1 - x3 * y1 + 2 * x4 * y1 + x * y2 - x4 * y2 - x * y3 + x1 * (y + y3 - 2 * y4) + x * y4 + x2 * y4 +
				u_sqrt);



			double v2 = -1 * l_ *
				(x1 * y + x3 * y - x4 * y - x * y1 - 2 * x3 * y1 + x * y2 - -2 * x1 * y2 + x4 * y2 - x * y3 + x1 * y3 + x * y4 - x2 * (y - 2 * y1 + y4) +
				v_sqrt);

			/////////////////////////////////////////////////////////////////////////////////////////////////
			double u2 = k *
				(x2 * y - x3 * y + x4 * y + x * y1 + x3 * y1 - 2 * x4 * y1 - x * y2 + x4 * y2 + x * y3 - x1 * (y + y3 - 2 * y4) - x * y4 - x2 * y4 +
				u_sqrt);


			var r= (
				v1>=0 && v1<=1?v1:v2
				,
				u1>=0 &&u1<=1?u1:u2
			);
			return r;
			//double u = r.Item2, v = r.Item1;
			//return (1 - u) * (1 - v) * new Point4dbl(0, 0)+ u*(1-v) * new Point4dbl(1,0) + (1-u)*v * new Point4dbl(0,1) + u*v* _newTip ;

			//throw new NotImplementedException();
		}
	}
}
