﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.curve.fill.sierpinski
{

	public class SierpinskyCurve
	{


		private SimpleGraphics sg = null;
		private int dist0 = 128, dist;
		private Image offscrBuf;
		private Graphics offscrGfx;

		public void init()
		{
			sg = new SimpleGraphics(getGraphics());
			dist0 = 100;
			resize(4 * dist0, 4 * dist0);
		}

		public void update(Graphics g)
		{
			paint(g);
		}

		public void paint(Graphics g)
		{

			if (g == null)
				throw new NullReferenceException();

			if (offscrBuf == null)
			{
				offscrBuf = createImage(this.getWidth(), this.getHeight());
				offscrGfx = offscrBuf.getGraphics();
				sg.setGraphics(offscrGfx);
			}

			int level = 3;
			dist = dist0;
			for (int i = level; i > 0; i--)
				dist /= 2;
			sg.goToXY(2 * dist, dist);
			sierpA(level); // start recursion
			sg.lineRel('X', +dist, +dist);
			sierpB(level); // start recursion
			sg.lineRel('X', -dist, +dist);
			sierpC(level); // start recursion
			sg.lineRel('X', -dist, -dist);
			sierpD(level); // start recursion
			sg.lineRel('X', +dist, -dist);

			g.drawImage(offscrBuf, 0, 0, this);

		}

		private void sierpA(int level)
		{
			if (level > 0)
			{
				sierpA(level - 1);
				sg.lineRel('A', +dist, +dist);
				sierpB(level - 1);
				sg.lineRel('A', +2 * dist, 0);
				sierpD(level - 1);
				sg.lineRel('A', +dist, -dist);
				sierpA(level - 1);
			}
		}

		private void sierpB(int level)
		{
			if (level > 0)
			{
				sierpB(level - 1);
				sg.lineRel('B', -dist, +dist);
				sierpC(level - 1);
				sg.lineRel('B', 0, +2 * dist);
				sierpA(level - 1);
				sg.lineRel('B', +dist, +dist);
				sierpB(level - 1);
			}
		}

		private void sierpC(int level)
		{
			if (level > 0)
			{
				sierpC(level - 1);
				sg.lineRel('C', -dist, -dist);
				sierpD(level - 1);
				sg.lineRel('C', -2 * dist, 0);
				sierpB(level - 1);
				sg.lineRel('C', -dist, +dist);
				sierpC(level - 1);
			}
		}

		private void sierpD(int level)
		{
			if (level > 0)
			{
				sierpD(level - 1);
				sg.lineRel('D', +dist, -dist);
				sierpA(level - 1);
				sg.lineRel('D', 0, -2 * dist);
				sierpC(level - 1);
				sg.lineRel('D', -dist, -dist);
				sierpD(level - 1);
			}
		}
	}

	class SimpleGraphics
	{
		private Graphics g = null;
		private int x = 0, y = 0;

		public SimpleGraphics(Graphics g)
		{
			setGraphics(g);
		}

		public void setGraphics(Graphics g)
		{
			this.g = g;
		}

		public void goToXY(int x, int y)
		{
			this.x = x;
			this.y = y;
		}

		public void lineRel(char s, int deltaX, int deltaY)
		{
			g.DrawLine( Pens.AliceBlue,x, y, x + deltaX, y + deltaY);
			x += deltaX;
			y += deltaY;
		}
	}
}
