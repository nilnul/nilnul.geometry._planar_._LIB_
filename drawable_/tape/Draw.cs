using nilnul.geometry.planar.point.co.band_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace nilnul.geometry.planar.drawable_.tape
{
	public class _DrawX
	{

		/*
The textLength attribute, available on SVG <text> and <tspan> elements, lets you specify the width of the space into which the text will draw. The user agent will ensure that the text does not extend farther than that distance, using the method or methods specified by the lengthAdjust attribute. By default, only the spacing between characters is adjusted, but the glyph size can also be adjusted if you change lengthAdjust.

The lengthAdjust attribute controls how the text is stretched into the length defined by the textLength attribute.			
		 */
		static public XElement Draw(Tape4dbl tape, int sizeOfTxt)
		{

			var g = new XElement("g");


			//calc the size of the txt
			//No this is not possible, SVG elements do not have background-.
			///draw the doubleArrow
			///
			var biArrow = cloze_.gon._DrawX.El(
				tape.arrow
			);
			g.Add(biArrow);

			var id = Guid.NewGuid().ToString("N");


			var mask = new XElement(
					"mask"
					,
					new XAttribute(
						"id"
						,
						id
					)
				)
			{

			};

			var tapeDirection = tape.arrow.grad.direction;


			var maskRectStart = new Point4dbl( tape.arrow.grad.begin) + new planar.vect_.Polar4dbl(
				tapeDirection
				,
				(tape.arrow.grad.length - sizeOfTxt) / 2
			);

			var maskRectEnd =new Point4dbl(  tape.arrow.grad.end) - new planar.vect_.Polar4dbl(
				tapeDirection
				,
				(tape.arrow.grad.length - sizeOfTxt) / 2
			);

			var maskRect = new planar.cloze_.gon_.Di4dbl(
				maskRectStart, maskRectEnd
			);



			mask.Add(
				cloze_.gon._DrawX.El(
					maskRect
				)

			);

			g.Add(
				mask
			); ;

			//g.Add(
			//	new XAttribute(
			//		"mask-image"
			//		,
			//		$"linear-gradient({tape.arrow.grad.direction}rad, black,black)"
			//	)
			//	,
			//	new XAttribute(
			//		"mask-size"
			//		,
			//		sizeOfTxt
			//	)
			//);

			var txtAnchor = tape.arrow.grad.ee.Mid();

			g.Add(
				new XElement(
					"text"
					,
					new XAttribute(
						"x",
						txtAnchor.x
					)
					,
					new XAttribute(
						"y",
						txtAnchor.y
					)
					,
					new XAttribute(
						"text-anchor", "middle"
					)
					,
					new XAttribute(
						"dominant-baseline", "central"
					)
					,
					new XAttribute(
						"alignment-baseline", "middle"
					)

					,
					tape.caption

				)
			);

			///mask
			///
			return g;

		}
	}
}
