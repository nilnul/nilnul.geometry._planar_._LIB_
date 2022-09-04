using nilnul.geometry.planar.point;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PointD = nilnul.geometry.planar.Point4dbl;



namespace nilnul.geometry.planar.tend_
{

	public  class EdgeD :nilnul.geometry.planar.point.twin.be_.dif.vow.EeD
		,
		planar.Tend4dblI
	{
		public EdgeD(point.CoD duo) :
			base(new point.TwinD( duo ))
		{

		}
		public EdgeD(Point4dbl begin, Point4dbl end)
			:base(
				 new point.TwinD(begin,end)
				 )

		{

		}

		public Point4dbl begin {
			get
			{
				return ee.component.ToOrthogonal();
			}
		}
		public Point4dbl end {
			get
			{
				return ee.component1.ToOrthogonal();//.end;
			}
		}

		public TwinD points => this;

		static public bool operator ==(EdgeD a, EdgeD b) {
			return point.co.EqD.Singleton.Equals(  a.ee , b.ee);
		}
		static public bool operator !=(EdgeD a, EdgeD b) {
			return !( a == b);
		}


		// override object.Equals
		public override bool Equals(object obj)
		{
			//       
			// See the full list of guidelines at
			//   http://go.microsoft.com/fwlink/?LinkID=85237  
			// and also the guidance for operator== at
			//   http://go.microsoft.com/fwlink/?LinkId=85238
			//

			if (obj == null || GetType() != obj.GetType())
			{
				return false;
			}



			// TODO: write your implementation of Equals() here
			throw new NotImplementedException();
			return base.Equals(obj);
		}

		// override object.GetHashCode
		public override int GetHashCode()
		{
			// TODO: write your implementation of GetHashCode() here
			throw new NotImplementedException();
			return base.GetHashCode();
		}

		
		[Obsolete("see Grad")]
		static public EdgeD operator -(EdgeD edge) {
			return new EdgeD( edge.end, edge.begin);
		}
	
		
	}
}
