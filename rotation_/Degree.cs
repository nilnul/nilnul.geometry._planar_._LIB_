﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using N = nilnul._num.bigint.be.Natural.Asserted;
using Q1 = nilnul.num.Quotient1;
using Qr = nilnul.num.real_.Quotient;
using R = nilnul.num.Real;
using Rx = nilnul.num.RealIX;



namespace nilnul.geometry.planar.rotation_
{
		/// <summary>
		/// another way to express rotation.
		/// </summary>
	public class Degree : RotationI1
	{

		public const char Symbol = '°';
		private R _val;

		public R val
		{
			get { return _val; }
			set { _val = value; }
		}


		public Degree(R val)
		{
			_val = val;
		}
		public R quantity
		{
			get
			{

				return _val / new nilnul.num.real_.Tau();
				//throw new NotImplementedException();
			}
		}

		public _rotation.UnitI unit => _rotation.unit_.Degree.Singleton;

		public override string ToString()
		{
			return $"{_val}{Symbol}";
		}

		static public Degree CreateZero() {
			return new Degree(0);
		}

		static public Degree Create30() {
			return new Degree(30);
		}

		static public Degree Create15() {
			return new Degree(15);
		}
		static public Degree Create45() {
			return new Degree(45);
		}
		static public Degree Create60() {
			return new Degree(60);
		}

		public const double RADIAN_PER_DEGREE = nilnul.num.real_.TauX.IntoDouble/360;

		static public float ToRadian(float degree) {
			return degree / 180 * (float)Math.PI;
		}

		static public double ToRadian(double degree) {
			return degree *RADIAN_PER_DEGREE;// / 180 * Math.PI;
		}


		static public float FroRadian(float radian) {
			return radian / nilnul.num.real_.tau.Pi.AsFloat *180;
		}


	}
}
