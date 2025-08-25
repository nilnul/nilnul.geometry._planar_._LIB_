using nilnul.num;
using R = nilnul.num.Real;

namespace nilnul.geometry.planar
{

	/// <summary>
	/// complex number represented by a visible point.
	/// </summary>
	/// <remarks>
	/// the vect and the point are both represented by the complex number. Hence they are tackled as the same.
	/// </remarks>
	public interface IPoint :
		//IConnected
		//	nilnul.geometry.linear.IPoint
		//,
		nilnul.num.IComplex
		,
		trip_.INilLength
		,

		tope_.IBoundaried, ICloze, IGrad, ILoop, ITend
	{

	}


}