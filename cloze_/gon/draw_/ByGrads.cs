using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace nilnul.geometry.planar.zone_.gon.draw_
{
	/// <summary>
	/// all polygon, including nilgon and monogon, can be drawn in the same algorithms.
	/// </summary>
	static public class _ByGradsX
	{
		static public XElement El_assumeStarted(IEnumerable<Point4dblI> points)
		{

			//var d = $@"		M {points.First().ToTxt_bare()}" +
			//	string.Join(
			//		" "
			//		,
			//		points.Skip(1).Select(
			//			p => "L " + p.ToTxt_bare()
			//		)
			//	)
			//	+
			//	" Z"
			//;

			return new XElement(
				"path"
				,
				new XAttribute(
					"d"
					,
					nilnul.characters.map_.xmL_.attr_._White2spaceX.White2space(
						$@"M {points.First().ToTxt_bare()}"
						+
						string.Join(
								" "
								,
								points.Skip(1).Select(
									p => "L " + p.ToTxt_bare()
								)
						)
						+
						" Z"
					)
				)
			);
		}

		static public XElement El_assumeStarted(IEnumerable<Point4dbl> points)
		{

			//var d = $@"		M {points.First().ToTxt_bare()}" +
			//	string.Join(
			//		" "
			//		,
			//		points.Skip(1).Select(
			//			p => "L " + p.ToTxt_bare()
			//		)
			//	)
			//	+
			//	" Z"
			//;

			return new XElement(
				"path"
				,
				new XAttribute(
					"d"
					,
					nilnul.characters.map_.xmL_.attr_._White2spaceX.White2space(
						$@"M {points.First().ToTxt_bare()}"
						+
						string.Join(
								" "
								,
								points.Skip(1).Select(
									p => "L " + p.ToTxt_bare()
								)
						)
						+
						" Z"
					)
				)
			);
		}
	}
}
