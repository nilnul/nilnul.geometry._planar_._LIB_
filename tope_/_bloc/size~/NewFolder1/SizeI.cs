using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.way_.lap_.rect
{
	/// <summary>
	/// let the rect be parallel to x-axis and y-axis. the edge parralell to x is sized in width.
	/// or the first edge (started from the starting point) is called width
	/// </summary>
	public interface SizeI
	{
		nilnul.geometry._linear.LengthI1 width { get; }
		nilnul.geometry._linear.LengthI1 height { get; }
	}

	public class Size:SizeI

	{
		private nilnul.geometry._linear.LengthI1 _width;

		public nilnul.geometry._linear.LengthI1 width
		{
			get { return _width; }
			set { _width = value; }
		}

		private nilnul.geometry._linear.LengthI1 _height;

		public nilnul.geometry._linear.LengthI1 height
		{
			get { return _height; }
			set { _height = value; }
		}

		public Size(
			nilnul.geometry._linear.LengthI1 width
			,
			nilnul.geometry._linear.LengthI1 height
		)
		{
			_width = width;
			_height = height;
		}

		public Size CreateA4() {
			return new Size(
				nilnul.geometry._linear.Length.OvMm(210)
				,
				nilnul.geometry._linear.Length.OvMm(297)

			);
		}
	}
}
