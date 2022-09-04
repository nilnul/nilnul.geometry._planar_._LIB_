using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num
{
	public class Complex4dbl
		:
		Complex4dblI
	{
		private double _x;
		public double x {
			get=>_x;
			set => _x = value;
		}

		public double y { get; set; }

		public Complex4dbl(double x, double y)
		{
			this._x = x;
			this.y = y;
		}
		static public  implicit operator Complex4dbl(double a) {
			return new Complex4dbl(
				a 
				,
				0
			);
		}
		static public Complex4dbl operator ~(Complex4dbl a) {
			return new Complex4dbl(
				a.x 
				,
				-a.y
			);
		}

		static public Complex4dbl operator -(Complex4dbl a) {
			return new Complex4dbl(
				-a.x 
				,
				-a.y
			);
		}

		static public Complex4dbl operator +(Complex4dbl a, Complex4dbl b) {
			return new Complex4dbl(
				a.x+b.x 
				,
				a.y+b.y
			);
		}
		static public Complex4dbl operator +(Complex4dbl a, Complex4dblI b) {
			return new Complex4dbl(
				a.x+b.x 
				,
				a.y+b.y
			);
		}


		static public Complex4dbl operator +(Complex4dblI a, Complex4dbl b) {
			return new Complex4dbl(
				a.x+b.x 
				,
				a.y+b.y
			);
		}

		static public Complex4dbl operator -(Complex4dbl a, Complex4dbl b) {
			return new Complex4dbl(
				a.x-b.x 
				,
				a.y-b.y
			);
		}

		static public Complex4dbl operator -(Complex4dbl a, Complex4dblI b) {
			return new Complex4dbl(
				a.x-b.x 
				,
				a.y-b.y
			);
		}

		static public Complex4dbl operator -(Complex4dblI a, Complex4dbl b) {
			return a+-b;
		}

		static public Complex4dbl operator *(Complex4dbl a, Complex4dblI b) {
			return new Complex4dbl(
				a.x*b.x -a.y*b.y
				,
				a.x*b.y +a.y*b.x
			);
		}
		static public Complex4dbl operator *(Complex4dblI a, Complex4dbl b) {
			return b * a;
		}



	}
}
