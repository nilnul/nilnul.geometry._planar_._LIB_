using nilnul.geometry.planar.grad_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.geometry.planar.tend.vsPoint_.coline.be_
{
	static public  class _Has4DblX
	{


		/// <summary>
		/// 
		/// </summary>
		/// <param name="span"></param>
		/// <param name="p"> assume coline</param>
		/// <returns></returns>
		static public bool Has(
			planar.Tend4dblI span
			,
			Point4dblI p

		)
		{
			return planar.tend_.originated.vsPoint_.coline.be_._HasX._Has(
				vect.op_.binary_._MinusX.Point(
					span.points.component1 ,span.points.component)
				,
				vect.op_.binary_._MinusX.Point(

				p , span.points.component
				)
			);




		}

		public static bool _Has_assumeColine(Skid4dblI x, Point4dblI basis)
		{

			return Has(
				new planar.Tend4dbl(x.basis,x.finish)
				,
				basis
			);
		}

		public static bool _Has_assumeColine(Grad4dbl_byPoints span, Point4dblI p)
		{
			return planar.tend_.originated.vsPoint_.coline.be_._HasX._Has(
				vect.op_.binary_._MinusX.Point(
					span.points.component1 ,span.points.component)
				,
				vect.op_.binary_._MinusX.Point(

				p , span.points.component
				)
			);

		}

		public static bool _Has_assumeColine(Grad4dbl_byPointsI span, Point4dblI p)
		{
			return planar.tend_.originated.vsPoint_.coline.be_._HasX._Has(
				vect.op_.binary_._MinusX.Point(
					span.finish ,span.basis)
				,
				vect.op_.binary_._MinusX.Point(

				p , span.basis
				)
			);

		}
	}
}
