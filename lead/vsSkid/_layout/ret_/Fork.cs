using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.geometry.planar.lead.vsArrow._layout.ret_
{



	public interface ForkI : ResultI
	{

		Point4dbl point
		{
			get;
		}

	}


	public interface ForkRealI : ResultI
	{

		planar.PointI1 point
		{
			get;
		}

	}

	public class ForkA : ForkI
	{
		private Point4dbl _point;

		public ForkA(Point4dbl point)
		{
			this._point = point;
		}

		public Point4dbl point
		{
			get
			{
				return _point;
				throw new NotImplementedException();
			}
			set { _point = value; }
		}
	}

	public class ForkRealA : ForkRealI
	{
		private PointI1 _point;

		public ForkRealA(PointI1 point)
		{
			this._point = point;
		}

		public PointI1 point
		{
			get
			{
				return _point;
			}
			set { _point = value; }
		}
	}


	namespace fork_
	{
		/// <summary>
		/// the lead from the leeway of the arrow
		/// </summary>
		public interface FroLeewayI :ForkI{
		}
		public interface FroLeewayRealI :ForkRealI{
		}


		public interface MiddleOrEndI : ForkI { }
		public interface MiddleOrEnd4RealI : ForkRealI { }

		public interface AtStopI:MiddleOrEndI { }

		public interface AtStop4RealI:MiddleOrEnd4RealI { }

		/// <summary>
		/// the intersection is at the lag of the arrow
		/// </summary>
		public class FroLeeway2Lag : ForkA,  FroLeewayI
		{
			public FroLeeway2Lag(Point4dbl point) : base(point)
			{
			}
		}

		/// <summary>
		/// arrow start from leeway, and the intersection point is at the lag of the arrow
		/// </summary>
		public class FroLeeway2Lag4Real : ForkRealA,  FroLeewayRealI
		{
			public FroLeeway2Lag4Real(PointI1 point) : base(point)
			{
			}
		}


		/// <summary>
		/// the intersection is at the start point of the arrow
		/// </summary>
		public class FroLeeway2Start : ForkA,  FroLeewayI
		{
			public FroLeeway2Start(Point4dbl point) : base(point)
			{

			}

		}

		public class FroLeeway2Start4Real : ForkRealA,  FroLeewayRealI
		{
			public FroLeeway2Start4Real(PointI1 point) : base(point)
			{

			}

		}

		/// <summary>
		/// the lead passes thru the middle of the arrow
		/// </summary>
		public class FroLeeway2Between : ForkA,  MiddleOrEndI, FroLeewayI
		{
			public FroLeeway2Between(Point4dbl point)
				: base(point)
			{
			}
		}

		public class FroLeeway2Between4Real : ForkRealA,  MiddleOrEnd4RealI, FroLeewayRealI
		{
			public FroLeeway2Between4Real(PointI1 point)
				: base(point)
			{
			}
		}


		/// <summary>
		/// the lead passes thru exactly the stop point of the arrow
		/// </summary>
		public class FroLeeway2Stop : ForkA, FroLeewayI, AtStopI		//,  MiddleOrEndI
		{
			public FroLeeway2Stop(Point4dbl point)
				: base(point)
			{
			}
		}

		public class FroLeeway2Stop4Real : ForkRealA, FroLeewayRealI, AtStop4RealI		//,  MiddleOrEndI
		{
			public FroLeeway2Stop4Real(PointI1 point)
				: base(point)
			{
			}
		}


		/// <summary>
		/// the lead passes thru  a point at the head of the arrow
		/// </summary>
		public class FroLeeway2Ahead : ForkA, ForkI, FroLeewayI
		{
			public FroLeeway2Ahead(Point4dbl point)
				: base(point)
			{
			}
		}

		public class FroLeeway2Ahead4Real : ForkRealA,  FroLeewayRealI
		{
			public FroLeeway2Ahead4Real(PointI1 point)
				: base(point)
			{
			}
		}

		/// <summary>
		/// the lead, from the restrict of the arrow, passes a point in the lag of the arrow
		/// </summary>
		public class FroRestrict2Lag : ForkA, ForkI
		{
			public FroRestrict2Lag(Point4dbl point)
				: base(point)
			{

			}
		}

		public class FroRestrict2Lag4Real : ForkRealA
		{
			public FroRestrict2Lag4Real(PointI1 point)
				: base(point)
			{

			}
		}


		public class FroRestrict2Start : ForkA, ForkI
		{
			public FroRestrict2Start(Point4dbl point)
				: base(point)
			{

			}

		}

		public class FroRestrict2Start4Real : ForkRealA //, ForkI
		{
			public FroRestrict2Start4Real(PointI1 point)
				: base(point)
			{

			}

		}


		public class FroRestrict2Between : ForkA, ForkI, MiddleOrEndI
		{
			public FroRestrict2Between(Point4dbl point)
				: base(point)
			{

			}
		}

		public class FroRestrict2Between4Real : ForkRealA, MiddleOrEnd4RealI
		{
			public FroRestrict2Between4Real(PointI1  point)
				: base(point)
			{

			}
		}

		public class FroRestrict2End : ForkA, ForkI, AtStopI	//, MiddleOrEndI
		{
			public FroRestrict2End(Point4dbl point)
				: base(point)
			{

			}
		}

		public class FroRestrict2End4Real : ForkRealA,AtStop4RealI	//, MiddleOrEndI
		{
			public FroRestrict2End4Real(PointI1  point)
				: base(point)
			{

			}
		}

		public class FroRestrict2Ahead : ForkA, ForkI
		{
			public FroRestrict2Ahead(Point4dbl point)
				: base(point)
			{

			}

		}

		public class FroRestrict2Ahead4Real : ForkRealA
		{
			public FroRestrict2Ahead4Real(PointI1 point)
				: base(point)
			{

			}

		}

	}

}





