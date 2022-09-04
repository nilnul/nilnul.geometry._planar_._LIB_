using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace nilnul.geometry.planar.cloze_.gon
{
	/// <summary>
	/// all polygon, including nilgon and monogon, can be drawn in the same algorithms.
	/// </summary>
	static public class _DrawX
	{
		static public XElement El(IEnumerable<Point4dblI> points)
		{

			return new XElement(
				"polygon"
				,
				new XAttribute(
					"points"	//default ""
					,
					nilnul.characters.map_.xmL_.attr_._White2spaceX.White2space(
						
						string.Join(
								" "
								,
								points.Select(
									p =>  p.ToTxt_bare()
								)
						)
						
					)
				)
			);
		}
		static public XElement El(sub_.directed_.connected_._polygon_.Vertexes4dblI points)
		{

			return El(points.vertexes);
		}

	}
}
