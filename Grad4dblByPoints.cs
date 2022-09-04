using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.geometry.planar.point;

namespace nilnul.geometry.planar
{

	public class Grad4dbl_byPoints
		:
		nilnul.geometry.planar.point.CoD
		,
		Grad4dbl_byPointsI
	{
		public Grad4dbl_byPoints(point.CoD duo) : base(duo.component,duo.component1)
		{
		}

		public Grad4dbl_byPoints(Grad4dblI x):this(
			x.basis
			,
			grad_._StepX.End(x)

		)
		{
		}

		public Grad4dbl_byPoints((Point4dblI, Point4dblI) x):this(x.Item1,x.Item2)
		{
		}

		public Grad4dbl_byPoints(Vect4dbl v1):this(
			Point4dbl.Origin, v1.point
		)
		{
		}

		public Grad4dbl_byPoints(Point4dbl point, Point4dbl end) : base(point, end)
		{
		}

		public Grad4dbl_byPoints(Point4dblI point, Point4dblI end) : base(point, end)
		{
		}

		public Grad4dbl_byPoints(Point p1, Point p2):this(
			new Point4dbl(p1), new Point4dbl(p2)
		)
		{
		}

		//public GradD(PointI1 a, PointI1 b) : base(a, b)
		//{
		//}

		public CoD points => this;

		public Point4dblI basis => this.component;

		public Vect4dbl vect => new planar.Vect4dbl(
			
			this.component1.x-this.component.x
			,
			this.component1.y-this.component.y
		);


		public Point4dblI finish => this.component1;

		static public Grad4dbl_byPoints operator -(Grad4dbl_byPoints edge)
		{
			return new Grad4dbl_byPoints(edge.component1, edge.component);
		}

	}
}
