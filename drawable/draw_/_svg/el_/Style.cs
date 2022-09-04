using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace nilnul.geometry.planar.drawable.draw_._svg.el_
{
	/// <summary>
	/// </summary>
	static public class _StyleX
	{


		static public XElement Style(double strokeWidth)
		{


			var g = new XElement("style"
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

