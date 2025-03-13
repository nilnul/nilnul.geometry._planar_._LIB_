using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace nilnul.geometry.planar.drawable.draw_._svg._el.attrs_.guide_
{
	/// <summary>
	/// guides for assistant lines, not measures.
	/// </summary>
	public class Nonfill
	{
		public XAttribute[] attrs()
		{

			var color =
				//"gray"
				//"cyan"
				"green"
				;

			return new[]{ new XAttribute(
				"stroke-width"
				,
				1
			)
			,
			new XAttribute("stroke", color)
			,
			new XAttribute("stroke-dasharray", 3)
			,
			new XAttribute("stroke-opacity", 0.6)

			,
			new XAttribute("fill", "none")
			,
			new XAttribute("class", "noframe")
			//,
			//new XAttribute("fill-opacity", 0.4)

			 };

		}


		static public Nonfill Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<Nonfill>.Instance;
			}
		}

	}
}
