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
			double x,double y
			,
			planar.tope_._bloc.SpreadDbl bloc
			,
			double strokeWidth = 1
		)
		{
			createDocument(x,y,bloc, strokeWidth);
			//addStyle();
		}

		public Builder(
			double x,double y
			,
			double width,double height
			,
			double strokeWidth = 1
		):this(
			x,y, new tope_._bloc.SpreadDbl(width,height),strokeWidth
		)
		{
		}


		public Builder(
			planar.tope_._bloc.SpreadDbl
bloc
			,
			double strokeWidth = 1)
			:this(0,0,bloc,strokeWidth)
		{
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


		static public Builder OfCentered(double width,double height) {
			return new Builder(
				-width/2
				,
				-height/2
				,
				width
				,
				height
			);
		}
		static public Builder OfCentered(double width,double height,double strokeWidth) {
			return new Builder(
				-width/2
				,
				-height/2
				,
				width
				,
				height
				,strokeWidth
			);
		}

		public Builder(double v1, double v2,
			double strokeWidth = 1) : this(
				new tope_._bloc.SpreadDbl(v1, v2)
				,
			 strokeWidth)
		{
		}

		private void createDocument(tope_._bloc.SpreadDbl bloc, double strokeWidth = 1)
		{
			createDocument(0,0,bloc, strokeWidth);
		}



		void createDocument(
		   double x, double y,
		   planar.tope_._bloc.SpreadDbl bloc
			,
		   double strokeWidth = 1
		){




			var xDoc = new XDocument(

			);



			XNamespace xn = "http://www.w3.org/2000/svg";

			var rtEle = new XElement(
xn + "svg"
				);

			xDoc.Add(
				rtEle
			);
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

