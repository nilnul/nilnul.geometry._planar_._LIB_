using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.geometry.planar.point;

namespace nilnul.geometry.planar.grad_
{
	/// <summary>
	/// the arrow from one point to another; but the points can be the same. the pair forms a gradient which can be zero
	/// </summary>
	/// <remarks>
	/// alias:
	///		Step
	///			nomenclature:
	///				step is with a stop
	///		Move
	///		ByTwoPoints
	/// </remarks>
	///
	[Obsolete(nameof(planar.IGrad))]
	public interface IStep:IGrad {

	}
	[Obsolete(nameof(planar.Grad4dbl_byPointsI))]
	public interface Step4dblI:
		Grad4dblI
		,
		_skid_.End4dblInInterfaceI
		,
		IStep
	{
		//nilnul.geometry.planar.point.CoD points { get; }
	}

	[Obsolete(nameof(planar.Grad4dbl_byPointsI))]

	static public class _StepX
	{

		static public VectorDbl Vect(Point4dblI a, Point4dblI b) => new planar.VectorDbl(

			b.x - a.x
			,
			b.y - a.y
		);


		public static Vector4dblI Vect(CoD grad)
		{
			return Vect(grad.component, grad.component1)
			;// throw new NotImplementedException();
		}
		public static Point4dbl End(Point4dblI basis, Vector4dblI vect)
		{
			return  new Point4dbl(
				basis.x + vect.point.x
				,
				basis.y + vect.point.y
			) ;
			
		}
		public static Point4dblI End(Grad4dblI grad)
		{
			return  new Point4dbl(
				grad.basis.x + grad.vect.point.x
				,
				grad.basis.y + grad.vect.point.y
			) ;
			
		}



	}

	[Obsolete(nameof(planar.Grad4dbl_byPoints))]

	public class Step4dbl
		:
		nilnul.geometry.planar.point.CoD
		,
		Step4dblI
	{
		public Step4dbl(point.CoD duo) : base(duo.component,duo.component1)
		{
		}

		public Step4dbl(Grad4dblI x):this(
			x.basis
			,
			_StepX.End(x)

		)
		{
		}

		public Step4dbl(Point4dbl point, Point4dbl end) : base(point, end)
		{
		}

		public Step4dbl(Point4dblI point, Point4dblI end) : base(point, end)
		{
		}

		//public GradD(PointI1 a, PointI1 b) : base(a, b)
		//{
		//}

		public CoD points => this;

		public Point4dblI basis => this.component;

		public Vector4dblI vect => new planar.VectorDbl(
			
			this.component1.x-this.component.x
			,
			this.component1.y-this.component.y
		);


		public Point4dblI end => this.component1;

		static public Step4dbl operator -(Step4dbl edge)
		{
			return new Step4dbl(edge.component1, edge.component);
		}

	}
}
