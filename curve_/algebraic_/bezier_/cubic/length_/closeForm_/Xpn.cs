using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.curve_.algebraic_.bezier_.cubic.length_.closeForm_
{

	/// <summary>
	/// www.planetclegg.com/projects/WarpingTextToSplines.html
	/// there is apparently no closed form solution to this problem
	/// There are a number of ways of approximating the arc-length, some involving moderately complex calculus. Even the most sophisticated and accurate solutions involve an iterative approach.
	/// </summary>
	[System.Serializable]
	public class NoneException : Exception
	{
		public NoneException() { }
		public NoneException(string message) : base(message) { }
		public NoneException(string message, Exception inner) : base(message, inner) { }
		protected NoneException(
		  System.Runtime.Serialization.SerializationInfo info,
		  System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
	}
	
}
