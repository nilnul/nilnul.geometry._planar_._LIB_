using nilnul.geometry.planar.curve_.algebraic_;
using nilnul.geometry.planar.point.co.band_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace nilnul.geometry.planar.cloze_.ellipse.arc.draw_
{
	/// <summary>
	/// </summary>
	/// 
	/// <see cref="nilnul.geometry.planar.ellipse.Extensions"/>
	/// <see cref="nilnul.geometry.planar.curve_.elliptic_.arc._DrawX"/>
	public class _SvgX
	{

		static public string AsArc(nilnul.geometry.planar.curve_.elliptic_.Arc8dbl convexRounded)
		{
			return 						nilnul.characters.map_.xmL_.attr_._White2spaceX.White2space(
							$@"
							A {
								convexRounded.major
							} {
								convexRounded.minor
							} {
								convexRounded.rotation
							}
							{nilnul.bit.to_.Int.Singleton.to(convexRounded.large)} {bit.to_.Int.Singleton.to(convexRounded.sweep)}

							{convexRounded.end.ToTxt_bare(",")}
							




							"
						)
					
;
			
			



		}
	
		static public string AsMoveArc(nilnul.geometry.planar.curve_.elliptic_.Arc8dbl convexRounded)
		{
			return 						nilnul.characters.map_.xmL_.attr_._White2spaceX.White2space(
							$@"
							M {convexRounded.start.ToTxt_bare(",")}
							{AsArc(convexRounded)}
							




							"
						)
					
;
			
			



		}


	}
}
