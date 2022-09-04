using nilnul.geometry.planar.point.co.band_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace nilnul.geometry.planar.drawable_.tape.projected_.quad
{
	public class _DrawX
	{

	
		static public XElement Draw(projected_.Quad tape, int sizeOfTxt, string colorForGuides="black")
		{


			var g4all = new XElement("g");

			g4all.Add(
				///first guid
				///
				planar.tend._DrawX.Draw(
					tape.guidFirst,colorForGuides
				)
				,

				planar.tend._DrawX.Draw(
					tape.guidSecond,colorForGuides
				)
				,
				planar.drawable_.tape._DrawX.Draw(
					tape.boxed
					,
					sizeOfTxt
				)

			);



			return g4all;



		}
	}
}
