namespace nilnul.geometry.planar.vwer_
{
	/// <summary>
	/// for a vwer:
	///
	///		the y axis might be pointing upward or downward.
	///	no matter what orientation the y is, the measure shown in text, shall point upward.
	///	So measure denotation shall be not part of geometry, but part of a higher layer, that is the vwer layer which shall contain the appended measuring data.
	/// </summary>
	/// <see cref="planar_.IMeasured"/>
	interface IMeasured { }
}
