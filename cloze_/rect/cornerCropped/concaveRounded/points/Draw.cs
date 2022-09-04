using nilnul.geometry.planar.point.co.band_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace nilnul.geometry.planar.closure_.rect.cornerCropped.convexRounded.points
{
	public class _DrawX
	{

	
		static public XElement Draw(convexRounded.Points points)
		{

			var g4all = new XElement("g");

			g4all.Add(
				new XElement(
					"path"
					,
					new XAttribute(
						"d"
						,
						nilnul.characters.map_.xmL_.attr_._White2spaceX.White2space(
							$@"M {
								points.topLeft.ToTxt_bare()
							}
							H {points.topRight.x}
							V {points.topLeftArc_up.y}
							A {

							}
							
Z
							"
						)
					)

				)

			);



			return g4all;



		}
	}
}
