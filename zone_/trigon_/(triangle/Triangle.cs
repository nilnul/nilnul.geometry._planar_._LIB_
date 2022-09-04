using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.geometry._2d.triangle
{
	[Obsolete("point.trio.be.Distinct.En")]
	public partial class Triangle : point.Triple
	{
		static public void Assert(ThreePoints threePoints) {
			nilnul.Assert.True(Be(threePoints));
		}
		static public void Assert(point.Triple threePoints) {
			nilnul.Assert.True(Be(threePoints));
		}
		static public bool Be(
			point.Triple threePoints) { 

			return Be(threePoints.A, threePoints.B, threePoints.C);
		
		}
		static public bool Be(
			ThreePoints threePoints

		)
		{
			return Be(threePoints.A, threePoints.B, threePoints.C);
		}


		protected Triangle(ThreePoints threePoints)
			: base(threePoints.A, threePoints.B, threePoints.C)
		{
			Assert(threePoints);
			

		}

		public Triangle(point.Triple pointTriple)
			:base(pointTriple.A,pointTriple.B,pointTriple.C)
		{
			Assert(pointTriple);
		}

		public Triangle(double a,double ay,double bx,double by,double cx,double cy)
			:this(
				new point.Triple(a,ay,bx,by,cx,cy)
			)
			
		{


		}
		static public Triangle Create(point.PointInDouble a, point.PointInDouble b, point.PointInDouble c) {
			return Create(
				new ThreePoints(a,b,c)	
			);
		}
		static public Triangle Create(ThreePoints threePoints) {

			nilnul.Assert.True(
				Be(threePoints)
				
			);

			return new Triangle(threePoints);
		
		}

		


	

		





	}
}
