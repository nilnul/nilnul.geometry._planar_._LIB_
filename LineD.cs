using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.geometry.planar
{
	public  class LineDbl:point.co.be_.dif.vow.EeDbl
		,
		line_._hinged_.AlignmentUnnormalI
	{

		public Point4dblI point
		{
			get { return ee.component; }
		}


		public Point4dblI point1
		{
			get { return ee.component1; }
		}

		public double alignmentUnnormal => nilnul.geometry.planar.vect._AzimuthX.GtNegPiLePi(
			nilnul.geometry.planar.vect.op_.binary_._MinusX.Op(point1,point)
		);

		public LineDbl(point.CoD pair):base(pair) {



			
		}

		public LineDbl(
			Point4dbl point,
			Point4dbl point1
		)
			:this(new point.CoD( point,point1))
		{
			

		}

		public LineDbl(
			Point4dblI point,
			Point4dblI point1
		)
			:this(new point.CoD( point,point1))
		{
			

		}


	

		public LineDbl(planar.grad_.skid_.ByPoints4Dbl  dir)
			:this(dir.begin,dir.end)
		
		{
			
		}

		public LineDbl(IRayDbl dir):this(
			planar.ray._ArrowX.Arrow(dir)
		)
		{
		}

		public bool containsPoint(Point4dbl x) {

			return (x.x - this.point.x)*(point1.y-point.y)==(x.y-point.y)*(point1.x-point.x);
		}

		public bool containsPoint_byNormalForm(Point4dbl p) {

			return p.x*(point1.y-point.y) + p.y*(point.x-point1.x) ==nilnul.num.real.matrix.square.Determinant._Eval_2x2( Point4dbl.ToArray( point),Point4dbl.ToArray( point1) );

		}



	


	}
}
