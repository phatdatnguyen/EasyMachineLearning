using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using ZedGraph;

namespace MachineLearning
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }

        private static Random random = new Random();

        public static bool IsNumericType(Type type)
        {
            switch (Type.GetTypeCode(type))
            {
                case TypeCode.Byte:
                case TypeCode.SByte:
                case TypeCode.UInt16:
                case TypeCode.UInt32:
                case TypeCode.UInt64:
                case TypeCode.Int16:
                case TypeCode.Int32:
                case TypeCode.Int64:
                case TypeCode.Decimal:
                case TypeCode.Double:
                case TypeCode.Single:
                    return true;
                default:
                    return false;
            }
        }

        public static Color[] DefaultColor
        {
            get
            {
                return new Color[] { Color.Blue, Color.Green, Color.Cyan, Color.Magenta, Color.Red, Color.Yellow,
            Color.Orange, Color.Pink, Color.Purple, Color.Brown, Color.Fuchsia, Color.Gold, Color.Gray, Color.Silver};
            }
        }

        public static Color RandomColor()
        {
            int redValue = (int)(255 * random.NextDouble());
            int greenValue = (int)(255 * random.NextDouble());
            int blueValue = (int)(255 * random.NextDouble());
            return Color.FromArgb(redValue, greenValue, blueValue);
        }

        public static void ShowScatterPlot(ZedGraphControl zedGraphControl, double[] xAxis, double[] yAxis, string[] groupColumn,
            string xTitle, string yTitle)
        {
            try
            {
                string[] groups = groupColumn.ToList().Distinct().OrderBy(x => x).ToArray();

                GraphPane graphPane = zedGraphControl.GraphPane;
                graphPane.CurveList.Clear();

                // Set the titles
                graphPane.Title.IsVisible = false;
                graphPane.XAxis.Title.Text = xTitle;
                graphPane.YAxis.Title.Text = yTitle;

                PointPairList[] scatterplots = new PointPairList[groups.Count()];
                for (int groupIndex = 0; groupIndex < groups.Count(); groupIndex++)
                    scatterplots[groupIndex] = new PointPairList();

                int numberOfPoints = xAxis.Length;
                for (int rowIndex = 0; rowIndex < numberOfPoints; rowIndex++)
                    for (int groupIndex = 0; groupIndex < groups.Count(); groupIndex++)
                        if (groupColumn[rowIndex] == groups[groupIndex])
                        {
                            scatterplots[groupIndex].Add(xAxis[rowIndex], yAxis[rowIndex]);
                            break;
                        }

                // Add the curve
                for (int groupIndex = 0; groupIndex < groups.Length; groupIndex++)
                {
                    Color color;
                    if (groupIndex < Program.DefaultColor.Length)
                        color = Program.DefaultColor[groupIndex];
                    else
                        color = Program.RandomColor();
                    LineItem myCurve = graphPane.AddCurve(groups[groupIndex].ToString(), scatterplots[groupIndex], color, SymbolType.Square);
                    myCurve.Line.IsVisible = false;
                    myCurve.Symbol.Border.IsVisible = false;
                    myCurve.Symbol.Fill = new Fill(color);
                }

                graphPane.Fill = new Fill(Color.WhiteSmoke);

                zedGraphControl.AxisChange();
                zedGraphControl.Invalidate();
            }
            catch
            {
                return;
            }
        }
    }
}
