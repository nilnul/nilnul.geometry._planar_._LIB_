
namespace nilnul.geometry.planar.curve_.algebraic_.bezier_
{
	/// <summary>
	/// For AB, get the middle point. and when x moves from A to B, the mid point moves from A to B in half speed.
	/// </summary>
	/// <remarks>
	/// 
	/// </remarks>
	/// alias:
	///		lerp
	///			,lp
	class Linear4dbl
		:nilnul.geometry.planar._troll_.Fn4dblI

	{
		private C _a;

		public C a
		{
			get { return _a; }
			set { _a = value; }
		}

		private C _b;

		public C b
		{
			get { return _b; }
			set { _b = value; }
		}



		/// <summary>
		/// 
		/// </summary>
		/// <remarks>
		/// can be extended to 3d, 1d, 0d;
		/// </remarks>
		/// <param name="time">
		///  generally, it's a prob in [0,1].
		///  when it's unconfined, this becomes a line when a,b are different, and a point when ab are same
		/// </param>
		/// <returns>
		/// the moving point
		/// </returns>
		public C locus(double time)
		{
			return _a * (1 - time) + _b * time;
		}
	}
}
