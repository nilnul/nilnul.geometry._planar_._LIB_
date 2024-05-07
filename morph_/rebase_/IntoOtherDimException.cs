using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.morph_.matrixed_
{
	/******************
	 * 
	 * Matrix Class

Namespace:
System.Drawing.Drawing2D
Assembly:
System.Drawing.Common.dll

	*/
	/// <summary>
	/// 
	/// </summary>
	///
	[Obsolete("shall be placed in map, as this may map to different dimension while trans is expected to map into only same 2d . ")]

	[Serializable]
	public class IntoOtherDimException : Exception
	{
		public IntoOtherDimException() { }
		public IntoOtherDimException(string message) : base(message) { }
		public IntoOtherDimException(string message, Exception inner) : base(message, inner) { }
		protected IntoOtherDimException(
		  System.Runtime.Serialization.SerializationInfo info,
		  System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
	}
}
