using nilnul.num;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.geometry.planar.line_
{
	/// <summary>
	/// Ax+By+C=0, where A and B cannot be both nil.
	/// </summary>
	public  class VectorProduct
	{
		/// <summary>
		/// the normal vector of the line. carries the partial (together with the product) information of the circle with which the line will be tangent, and the two or zero tanget points
		/// </summary>
		private nilnul.geometry.planar.vect_.Nonnil _vector;

		public nilnul.geometry.planar.vect_.Nonnil vector
		{
			get { return _vector; }
			set { _vector = value; }
		}

		/// <summary>
		/// the product of the varied vector and the given vector. any vector(from origin to a point of the line) will be projected onto the normal vector, and the projection(can be zero, negative) will be multiplied with the length of the normal vector.
		///
		/// the product of the length of vector and the projection of the vector of line point. the projection can be nil, negative, or positive. this in fact stipulates the foot.
		/// 
		/// if the product is zero, the line will pass thru origin. 
		/// if the product is positive, the line will cross the normal vector within the positive part
		/// if the product is negative, the line will cross the normal vector within the negative part
		///		
		/// </summary>
		private nilnul.num.RealI _product;

		public nilnul.num.RealI product
		{
			get { return _product; }
			set { _product = value; }
		}

		public VectorProduct(
			nilnul.geometry.planar.vect_.Nonnil vector
			,
			nilnul.num.RealI product
			
		)
		{
			_vector = vector;
			_product = product;
		}

		public planar.Point1 foot {
			get {
				return 
				new planar.vect_.DirectionLength(
					planar.vect_.nonnil._DirectionX.ToLtTau(_vector)
					,
					_product.ToReal() / planar.vect._MagnitudeX.Magnitude(_vector)
				).point;
			}
		}
	}
}
