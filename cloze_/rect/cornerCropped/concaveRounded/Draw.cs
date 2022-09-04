using nilnul.geometry.planar.point.co.band_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace nilnul.geometry.planar.cloze_.rect.cornerCropped.concaveRounded
{
	public class _DrawX
	{

	
		static public XElement Draw(ConcaveRounded convexRounded)
		{
			var points = new cornerCropped.concaveRounded.Points(convexRounded);


			var path =
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
							V {points.topRightArc_up.y}
							A {
								convexRounded.radius

							}							{
								convexRounded.radius

							} 0
							0 0
							{points.topRightArc_down.ToTxt_bare(",")}
							
							H{points.rightTop.x}
							V{points.rightDown.y}
							H{points.downRightArcStart.x}

							A {
								convexRounded.radius

							}							{
								convexRounded.radius

							} 0
							0 0
							{points.downRightArcEnd.ToTxt_bare(",")}


V{points.downRight.y}
H{points.downLeft.x}
V{points.downLeftArc_down.y}

							A {
								convexRounded.radius

							}							{
								convexRounded.radius

							} 0
							0 0
							{points.downLeftArc_up.ToTxt_bare(",")}

H{points.leftDown.x}
V{points.leftUp.y}
H{points.topLeftArc_down.x}

							A {
								convexRounded.radius

							}							{
								convexRounded.radius

							} 0
							0 0
							{points.topLeftArc_up.ToTxt_bare(",")}


Z
							"
						)
					)

				)
;
			return path;
			



		}
	}
}
