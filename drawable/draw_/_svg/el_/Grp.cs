using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace nilnul.geometry.planar.drawable.draw_._svg.el_
{
	/// <summary>
	/// for the main frame of an img.
	/// guides, measures, comments, etc, are not included.
	/// </summary>
	static public class _GrpX
	{


		static public XElement Grp(double strokeWidth)
		{


			var g = new XElement("g"
				,
new XAttribute("stroke-width", strokeWidth)
,
new XAttribute("stroke", "black")
,
new XAttribute("fill", "none")


			);

			return g;
		}
	}
}

