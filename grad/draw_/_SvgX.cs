using System;
using System.Xml.Linq;

namespace nilnul.geometry.planar.grad.draw_
{
	static public class _SvgX
	{
		static public XElement Draw2el(
			 double a
			,double b
			,double c
			,double d

		)
		{
			return new XElement(
				"line"
				,
				new XAttribute("x1", a)
				,
				new XAttribute("y1", b)
				,
				new XAttribute("x2", c)
				,
				new XAttribute("y2", d)

			);
		}

		static public XElement Draw2el(
			 Point4dblI a
			,
			 Point4dblI b
		)
		{
			return new XElement(
				"line"
				,
				new XAttribute("x1", a.x)
				,
				new XAttribute("y1", a.y)
				,
				new XAttribute("x2", b.x)
				,
				new XAttribute("y2", b.y)

			);
		}

		static public XElement Draw2el(
			this nilnul.geometry.planar.Grad4dbl_byPoints grad
		)
		{
			return new XElement(
				"line"
				,
				new XAttribute("x1", grad.component.x)
				,
				new XAttribute("y1", grad.component.y)
				,
				new XAttribute("x2", grad.component1.x)
				,
				new XAttribute("y2", grad.component1.y)

			);
		}

	}
}
