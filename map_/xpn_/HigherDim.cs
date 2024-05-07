using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.map_
{
	/// <summary>
	/// </summary>
	///
	
	[Obsolete("tackle this in 3d/4d/moreDim project")]

	[Serializable]
	public class ToHigherDimShallBePlacedInPrjOfHigherDimException : System.Exception
	{
		public ToHigherDimShallBePlacedInPrjOfHigherDimException() { }
		public ToHigherDimShallBePlacedInPrjOfHigherDimException(string message) : base(message) { }
		public ToHigherDimShallBePlacedInPrjOfHigherDimException(string message, System.Exception inner) : base(message, inner) { }
		protected ToHigherDimShallBePlacedInPrjOfHigherDimException(
		  System.Runtime.Serialization.SerializationInfo info,
		  System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
	}
}
