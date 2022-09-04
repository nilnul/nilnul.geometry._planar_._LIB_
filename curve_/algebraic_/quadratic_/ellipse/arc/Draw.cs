using nilnul.geometry.planar.point.co.band_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace nilnul.geometry.planar.curve_.elliptic_.arc
{
	public class _DrawX
	{

	
		static public XElement Draw(elliptic_.Arc convexRounded)
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
								convexRounded.major

							}							{
								convexRounded.minor

							} {convexRounded.rotation}
							{nilnul.bit.to_.Int.Singleton.to(convexRounded.large)} {bit.to_.Int.Singleton.to(convexRounded.clockwise)}

							{convexRounded.end.ToTxt_bare(",")}
							




							"
						)
					)

				)
;
			
			



		}
	}
}
