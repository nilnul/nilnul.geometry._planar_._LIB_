using nilnul.geometry.planar.tope_._bloc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace nilnul.geometry.planar.cloze_.convex_.arch_.vault_
{
	public class OfBlocSize
		:
		nilnul.obj.Box1<
			geometry.planar.tope_._bloc.SpreadDbl
		>
	{
		public OfBlocSize(SpreadDbl val) : base(val)
		{
		}

		public OfBlocSize(double width, double furtherness)
			:this(new SpreadDbl(width,furtherness))
		{
		}

		public Point4dbl leftLower {
			get {
				return new Point4dbl();
			}
		}

		public Point4dbl rightLower {
			get {
				return new Point4dbl(
					boxed.width.realee,0
				);
			}
		}

		public Point4dbl rectLeftUpper{
			get {
				return new Point4dbl(
					0
					,
					boxed.height.realee
				);
			}
		}

		public Point4dbl rectrightUpper{
			get {
				return new Point4dbl(
					boxed.width.realee
					,
					boxed.height.realee
				);
			}
		}

		public double radius{
			get {
				return boxed.width.realee.ee/2;
			}
		}

		public nilnul.geometry.planar.tope_._bloc.SpreadDbl BoundingSize {
			get {
				return new SpreadDbl(
					this.boxed.width.realee.ee
					,
					this.boxed.height.realee.ee + this.radius
					);
			}
		}

		public XElement draw()
		{
			var r = new XElement("path");

			var s = $@"M {leftLower.ToTxt_bare()}						L {rightLower.ToTxt_bare()}
						L {rectrightUpper.ToTxt_bare()}
						A {radius } {radius} 0 0 1 {rectLeftUpper.ToTxt_bare()}
						Z

";
			s = s.Replace(
				'\t',' '
			).Replace('\r', ' ').Replace('\n',' ');

			r.SetAttributeValue(
				"d"
				,
				s
			);
			return r;

			return new XElement(
				"path"
				,
				new XAttribute(
					"d"
					,
					$@"M {leftLower.ToTxt_bare()}						L {rightLower.ToTxt_bare()}
						L {rectrightUpper.ToTxt_bare()}
						A {radius } {radius} 0 0 {rectLeftUpper.ToTxt_bare()}
						Z

"

				)

			);
		}

		static public OfBlocSize OfBoundingSize(double width, double height) {
			return new OfBlocSize(
				width
				,
				height-width/2
			);
		}

	}
}
