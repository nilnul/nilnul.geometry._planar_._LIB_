using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace nilnul.geometry.planar.tend
{
	static public class _DrawX
	{

		static public XElement Draw(
			nilnul.geometry.planar.Point4dblI start

			,
			nilnul.geometry.planar.Point4dblI end
			,
			string color = "black"

		) {

			return new XElement(
				"line"
				,
				new XAttribute(
					"x1"
					,
					start.x
				)
				,
				new XAttribute(
					"y1"
					,
					start.y
				)
				,
				new XAttribute(
					"x2"
					,
					end.x
				)
				,
				new XAttribute(
					"y2"
					,
					end.y
				)
				,
				new XAttribute(
					"stroke"
					,
					color
				)
			);

		}

		static public XElement Draw(
			nilnul.geometry.planar.Point4dbl start

			,
			nilnul.geometry.planar.Point4dbl end
			,
			string color = "black"

		) {

			return Draw(
				(Point4dblI)start,
				(Point4dblI)end
				,
				color

			);

		}


		static public XElement Draw(
	nilnul.geometry.planar.grad_.Step4dblI start


	,
	string color = "black"

)
		{
			return Draw(
				start.basis
				,
				start.end
				,
				color
			);

		}

	}
}
