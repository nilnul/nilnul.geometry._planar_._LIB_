using nilnul.num.complex.of_.binary_.add.cumulator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using C = System.Numerics.Complex;
using nilnul.num;
using Complex = System.Numerics.Complex;
using nilnul.num.complex;
using nilnul.obj.str.op_;
using nilnul.obj.str;

namespace nilnul.geometry.planar.cloze_.gon_.nonshortcut.of_._points_.by_
{

	static public class _ByBisectX
	{

		/// <summary>
		/// same points are placed adjacently;
		/// </summary>
		/// <param name="points"></param>
		/// <returns>
		/// some redudant points might be removed.
		/// </returns>
		static public IEnumerable<Complex> _OfPoints_0dwelt(
				IEnumerable<Complex> points
		)
		{

			var leftLower = points.Aggregate(
					(a, c) =>
					{
						var comped = a.Real.CompareTo(c.Real);
						if (comped < 0)
						{
							return a;
						}
						if (comped > 0)
						{
							return c;
						}

						return c.Imaginary < a.Imaginary ? c : a;
					}
			);

			var max = points.Aggregate(
					(a, c) =>
					{
						var comped = a.Real.CompareTo(c.Real);
						if (comped < 0)
						{
							return c;
						}
						if (comped > 0)
						{
							return a;
						}
						return c.Imaginary < a.Imaginary ? a : c;
					}
			);

			var remained = points.Except(
				new[] { leftLower, max }
			);

			if (remained.Any())
			{


				/// above the line
				///

				var prowind = new List<C>();

				var nonpro = new List<C>();

				remained.Each(
					x =>
					{
						if (
						planar.lead.vsPoint.be_._ProWindX._Be_0skid(
								leftLower, max, x
							)
						)
						{
							prowind.Add(x);
						}
						else
						{
							nonpro.Add(x);
						}
					}
				);


				var nonproSorted = nilnul.obj.str.op_._SortX._Sort_1comp(
					nonpro
					,
					(x, y) =>
					{
						var c = x.Real.CompareTo(y.Real);

						if (c == 0)
						{
							return x.Imaginary.CompareTo(y.Imaginary);
						}
						return c;
					}
				);

				var proSorted = nilnul.obj.str.op_._SortX._Sort_1comp(
					prowind
					,
					(x, y) =>
					{
						var c = x.Real.CompareTo(y.Real);

						if (c == 0)
						{
							return -x.Imaginary.CompareTo(y.Imaginary);
						}
						return -c;
					}
				);

				return new[] { leftLower }.Concat(nonproSorted).Append(max).Concat(proSorted);

			}
			return [leftLower, max];




		}
	}
}
