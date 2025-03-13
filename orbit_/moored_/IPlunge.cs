namespace nilnul.geometry.planar.orbit_.moored_
{
	/// <summary>
	/// when time is in [a, inf), it's a fixed point.
	/// when time is in (-inf, a), it might be moving;
	/// </summary>
	/// alias:
	///		fall
	///		drop
	///		plummet
	///		retract
	interface IPlunge:orbit_.IInfiniteOnOneEndOnly { }
}
