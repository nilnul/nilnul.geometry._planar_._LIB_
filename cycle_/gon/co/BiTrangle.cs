using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.geometry._2d.polygon
{
	/// <summary>
	/// given two triangles, compute their union.
	/// </summary>
	public partial class BiTrangle
	{
		//

		private triangle.Triangle _triangle;

		public triangle.Triangle triangle
		{
			get { return _triangle; }
			set { _triangle = value; }
		}

		private triangle.Triangle _triangle1;

		public triangle.Triangle triangle1
		{
			get { return _triangle1; }
			set { _triangle1 = value; }
		}

		public double intersetionArea() {

			var triangle1antiClockwise = triangle1.toAntiClockwiseDirectionS();



			throw new NotImplementedException();
		}
		
		

	}
}
