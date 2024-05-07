using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.morph_.matrixed_.xpn_
{
	/// <summary>
	/// translation is not linear transformation of vector space, as you would add a constant vector while constant has an exponent of 0, which is not linear line, but trivia point
	/// </summary>
	///
	[Serializable]
	public class TranslateIsNotLinearException : Exception
	{
		public TranslateIsNotLinearException() { }
		public TranslateIsNotLinearException(string message) : base(message) { }
		public TranslateIsNotLinearException(string message, Exception inner) : base(message, inner) { }
		protected TranslateIsNotLinearException(
		  System.Runtime.Serialization.SerializationInfo info,
		  System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
	}
}
