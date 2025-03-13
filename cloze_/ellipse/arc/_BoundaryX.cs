using nilnul.geometry.planar.curve_.elliptic_;
using nilnul.num.complex.dich_._ortho_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.cloze_.ellipse.arc
{

	///stackoverflow.com/questions/65433347/how-to-get-axis-aligned-bounding-box-of-an-ellipse-with-all-given-parameters#
	///<summary>
	/// 
	/// </summary>
	static  class _BoundaryX
	{



		/// <summary>
		/// imagine a large ellipse, with <paramref name="direction"/> is almost incident with the chord, the the ellipse will provide both the bound borders for the <see cref="planar.ICycle"/> which this is part of.
		/// </summary>
		/// <param name="direction"></param>
		/// <returns></returns>
		static  (double time4min, double time4max, double, double) Boundary(ellipse.Arc8dbl arc)
		{
			C startPoint = arc.ellipse.locus(0 + arc.startAngle);

			double minX = startPoint.Real
				, maxX = startPoint.Real
				, minY = startPoint.Imaginary
				, maxY = startPoint.Imaginary;


			if (arc.sweep == 0)
			{
				return (minX, maxX, minY, maxY);
			}

			var endPoint = arc.ellipse.locus(0 + arc.startAngle + arc.sweep);

			minX = Math.Min(minX, endPoint.Real);
			maxX = Math.Max(maxX, endPoint.Real);
			minY = Math.Min(minY, endPoint.Imaginary);
			maxY = Math.Max(maxY, endPoint.Imaginary);


			List<C> points = new List<Complex>();

			(double time4x, double time4y) extrem = ellipse_.central._boundary_.by_._TimeX.Extrema(
				new ellipse_.Centered8origin(
					arc.ellipse.radiusX
					,
					arc.ellipse.radiusY
					,
					arc.ellipse.rotated
				)
			);
			var time4x  = extrem.time4x;



			for (int i = 0; i < 4; i++)
			{

				var timeNormed = planar.rotation_.DirectionDbl._OfRotation(time4x + Math.PI / 2 * i);

				if (arc.sweep > 0)
				{
					num.real.bound_.Open4dbl open4dbl = new nilnul.num.real.bound_.Open4dbl(
					arc.startAngle, arc.sweep + arc.startAngle
										);
					if (open4dbl.has(timeNormed)
					||
					open4dbl.has(timeNormed + Math.PI * 2)
					)
					{
						double real = arc.ellipse.locus(timeNormed ).Real;

						minX = Math.Min(minX, real);
						maxY = Math.Max(maxX, real);

	
					}
				}
				else
				{
					num.real.bound_.Open4dbl open4dbl = new nilnul.num.real.bound_.Open4dbl(
						arc.startAngle+arc.sweep  
						,
						arc.startAngle
					);
					if (open4dbl.has(timeNormed)
					||
					open4dbl.has(timeNormed - Math.PI * 2)
					)
					{
						double real = arc.ellipse.locus(timeNormed ).Real;

						minX = Math.Min(minX, real);
						maxY = Math.Max(maxX, real);

					}

				}

			}

			var extrema4y = extrem.time4y;



			for (int i = 0; i < 4; i++)
			{

				var newAngle = planar.rotation_.DirectionDbl._OfRotation(extrema4y + Math.PI / 2 * i);

				if (arc.sweep > 0)
				{
					num.real.bound_.Open4dbl open4dbl = new nilnul.num.real.bound_.Open4dbl(
						arc.startAngle, arc.sweep + arc.startAngle
					);
					if (open4dbl.has(newAngle)
					||
					open4dbl.has(newAngle + Math.PI * 2)
					)
					{

						minY = Math.Min(minY, arc.ellipse.locus(newAngle ).Imaginary);
						maxY = Math.Max(maxY, arc.ellipse.locus(newAngle).Imaginary);

					}
				}
				else
				{
					num.real.bound_.Open4dbl open4dbl = new nilnul.num.real.bound_.Open4dbl(
						arc.sweep + arc.startAngle
						,
						arc.startAngle
					);
					if (open4dbl.has(newAngle)
					||
					open4dbl.has(newAngle - Math.PI * 2)
					)
					{
						minY = Math.Min(minY, arc.ellipse.locus(newAngle).Imaginary);
						maxY = Math.Max(maxY, arc.ellipse.locus(newAngle).Imaginary);


					}

				}

			}


			return (minX, maxX, minY, maxY);







		}

	}
}
