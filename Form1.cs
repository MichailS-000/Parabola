using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Parabola
{
	struct Parabola
    {
		public int a, b, c;
    }

	public partial class Form1 : Form
	{
		Parabola current;
		int trys, succsess;

		private bool IsRounded(float val)
		{
			return val - Math.Round(val) == 0;
		}

		private int Rand(int resolution)
		{
			Random r = new Random(DateTime.Now.Millisecond);

			int res = r.Next(-resolution, resolution);
			return res == 0 ? 1 : res;
		}

		private void NewData(object sender, EventArgs e)
		{
			numberA.BackColor = Color.White;
			numberB.BackColor = Color.White;
			numberC.BackColor = Color.White;

			numberA.Value = 0;
			numberB.Value = 0;
			numberC.Value = 0;

			newDataButton.Click += Test;
			newDataButton.Click -= NewData;
			newDataButton.Text = "Проверить";

			InitChart();
			DrawParabola(Rand(1), Rand(4), Rand(3));
		}

		private void SetAxis(Axis axis, int delta, int center)
		{
			axis.Minimum = center - delta;
			axis.Maximum = center + delta;
		}

		private void DrawParabola(int a, int b, int c)
		{
			current = new Parabola() { a = a, b = b, c = c };

			float
				x = -5,
				y,
				s = 1f,
				t = 5;

			while(x <= t)
			{
				y = a * x * x + b * x + c;

				Table.Rows.Add(x, y);

				chart1.Series[0].Points.AddXY(x, y);
				x += s;
			}
		}

		private void Test(object sender, EventArgs e)
		{
			trys++;
			bool succsesful = true;

			newDataButton.Click += NewData;
			newDataButton.Click -= Test;
			newDataButton.Text = "Новые данные";

			if (numberA.Value == current.a)
            {
				numberA.BackColor = Color.Green;
            }
            else
            {
				numberA.BackColor = Color.Red;
				succsesful = false;
            }

			if (numberB.Value == current.b)
            {
				numberB.BackColor = Color.Green;
            }
            else
            {
				numberB.BackColor = Color.Red;
				succsesful = false;
			}

			if (numberC.Value == current.c)
			{
				numberC.BackColor = Color.Green;
			}
			else
			{
				numberC.BackColor = Color.Red;
				succsesful = false;
			}

			if (succsesful)
            {
				succsess++;
				MessageBox.Show("Правильно!");
            }
            else
            {
				MessageBox.Show("Неправильно");
            }

			fullTryes.Text = trys.ToString();
			succsessfulTryes.Text = succsess.ToString();
		}

		private void InitChart()
		{
			chart1.Series[0].Points.Clear();

			SetDefaultChartAxis(chart1.ChartAreas[0].AxisX);
			SetDefaultChartAxis(chart1.ChartAreas[0].AxisY);
		}

		private void SetDefaultChartAxis(Axis axis)
		{
			SetAxis(axis, 3, 0);
			axis.Crossing = 0;
			axis.Interval = 0.5f;
			axis.ArrowStyle = AxisArrowStyle.Triangle;
		}

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
			if (trys == 0)
				return;

			string result = DateTime.Now.ToString();
			float score = succsess / (float)trys * 100f;
			result += string.Format("\n{0} of {1} {2}%", succsess, trys, float.IsNaN(score) ? "¯\\_(ツ)_/¯" : score.ToString());
			MessageBox.Show(result);
			using (FileStream stream = new FileStream(Environment.CurrentDirectory + "/results.res_secured", FileMode.Append))
            {
				WriteBytesString(stream, result);
				WriteBytesString(stream, "\n-------------------------------------------------\n");
            }
        }

		public static void WriteBytesString(FileStream stream, string str)
        {
			byte[] bytes = Encoding.UTF8.GetBytes(str);
			stream.Write(bytes, 0, bytes.Length);
        }

		public Form1()
		{
			InitializeComponent();
			InitChart();
		}
    }
}