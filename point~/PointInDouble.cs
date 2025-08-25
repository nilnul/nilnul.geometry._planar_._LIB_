using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace nilnul.geometry._2d.point
{
	[Obsolete()]
	public  class PointInDouble

	{
		private double _x;

		public double x
		{
			get { return _x; }
			set { _x = value; }
		}

		private double _y;

		public double y
		{
			get { return _y; }
			set { _y = value; }
		}

		public PointInDouble(double x, double y)
		{
			this._x = x;
			this._y = y;

		}

		public double[] toArray() {
			return new double[] {x,y };
		}
		public PointF toPointF() {
			return new PointF(
				(float)x,(float)y
				);
		}

		public override string ToString()
		{
			return string.Format("({0})", string.Join(",",x,y));
		}


		public string ToTxt_bare(string separator=",")
		{
			return string.Format("{0}{1}{2}",x,separator,y);


		}

		static public bool operator ==(PointInDouble x, PointInDouble y){

			return x.x == y.x && x.y == y.y;
		
		}

		static public bool operator !=(PointInDouble x, PointInDouble y){
			return !(x == y);
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
			var objAsPoint = obj as PointInDouble;
			if (objAsPoint.x==this.x && objAsPoint.y==this.y)
			{
				return true;
				
			}
			return false;

			// TODO: write your implementation of Equals() here
			throw new NotImplementedException();
			return base.Equals(obj);
		}

		// override object.GetHashCode
		public override int GetHashCode()
		{

			return x.GetHashCode() ^ y.GetHashCode();
			// TODO: write your implementation of GetHashCode() here
			throw new NotImplementedException();
			return base.GetHashCode();
		}


	

		public class Eq
			:IEqualityComparer<PointInDouble>
		{

			static public Eq Singleton = SingletonByDefault<Eq>.Instance;
			static public bool Eval(PointInDouble x, PointInDouble y) {
				return x.x == y.x && x.y == y.y;
			}


			public bool Equals(PointInDouble x, PointInDouble y)
			{
				return Eval(x, y);
				throw new NotImplementedException();
			}

			public int GetHashCode(PointInDouble obj)
			{
				return obj.x.GetHashCode() ^ obj.y.GetHashCode();

				throw new NotImplementedException();
			}
		}
		
		
	}
}
