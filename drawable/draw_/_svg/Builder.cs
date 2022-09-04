using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace nilnul.geometry.planar.drawable.draw_._svg
{
	public class Builder
	{


		XDocument _document;
		/// <summary>
		/// use this to add element.
		/// </summary>
		public XDocument document
		{
			get { return _document; }
		}
		public Builder(
			planar.tope_._bloc.SpreadDbl
bloc
			,
			double strokeWidth = 1)
		{
			createDocument(bloc, strokeWidth);
			//addStyle();
		}

//		void addStyle()
//		{
//			_document.Root.Add(
//new nilnul.web.css.Style(
//				 web.css.rule_.sel_._ClassOfCssX.OfClassNameNoDot(
//					"noframe"
//					,
//					new web.css.Props(
//						new web.css.Prop(
//						"display"
//						,
//						"invalidVal")


//					)

//				)
//			).toEl()
//			);



//		}

		public Builder(double v1, double v2,
			double strokeWidth = 1) : this(
				new tope_._bloc.SpreadDbl(v1, v2)
				,
			 strokeWidth)
		{
		}

		void createDocument(
		   planar.tope_._bloc.SpreadDbl
bloc
			, double strokeWidth = 1
	   )
		{






			var xDoc = new XDocument(

			);



			XNamespace xn = "http://www.w3.org/2000/svg";

			var rtEle = new XElement(
xn + "svg"
				);

			xDoc.Add(
				rtEle
			);




			var x = 0;
			var y = 0;
			var w = bloc.width;
			var h = bloc.height;

			rtEle.Add(
				new XAttribute("viewBox", $"{x - strokeWidth / 2} {y - strokeWidth / 2} {w.realee + strokeWidth} {h.realee + strokeWidth }")
			);


			this._document = xDoc;
		}



		/// <summary>
		/// before rendering, use this to clean empty ns.
		/// </summary>
		public void removeEmptyNs()
		{
			var xDoc = this._document;
			foreach (var node in xDoc.Root.Descendants())
			{
				// If we have an empty namespace...
				if (node.Name.NamespaceName == "")
				{
					// Remove the xmlns='' attribute. Note the use of
					// Attributes rather than Attribute, in case the
					// attribute doesn't exist (which it might not if we'd
					// created the document "manually" instead of loading
					// it from a file.)
					node.Attributes("xmlns").Remove();
					// Inherit the parent namespace instead
					node.Name = node.Parent.Name.Namespace + node.Name.LocalName;
				}
			}


		}

	}
}

