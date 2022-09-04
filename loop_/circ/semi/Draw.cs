using nilnul.geometry.planar.point.co.band_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace nilnul.geometry.planar.cloze_.circular_.semi
{
	public class _DrawX
	{

	
		static public XElement Draw(curve_.circular_.Semi convexRounded)
		{
			return 
new XElement(
					"path"
					,
					new XAttribute(
						"d"
						,
						nilnul.characters.map_.xmL_.attr_._White2spaceX.White2space(
							$@"M {
								convexRounded.start.ToTxt_bare()
							}
							
							A {
								convexRounded.radius

							}							{
								convexRounded.radius

							} {0}
							{0} {bit.to_.Int.Singleton.to(convexRounded.clockwise)}

							{convexRounded.end.ToTxt_bare(",")}
							

Z


							"
						)
					)

				)
;
			
			



		}
	}
}
