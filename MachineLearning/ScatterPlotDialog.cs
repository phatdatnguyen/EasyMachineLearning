using Accord.Math;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using ZedGraph;

namespace MachineLearning
{
    public partial class ScatterPlotDialog : Form
    {
        public ScatterPlotDialog(DataTable inputData, string xColumnName, string yColumnName, string groupColumnName)
        {
            InitializeComponent();

            try
            {
                double[] xAxis = inputData.Columns[xColumnName].ToArray();
                double[] yAxis = inputData.Columns[yColumnName].ToArray();
                string[] groupColumn = inputData.Columns[groupColumnName].ToArray<string>();
                string[] groups = groupColumn.ToList().Distinct().OrderBy(x => x).ToArray();

                GraphPane graphPane = zedGraphControl.GraphPane;
                graphPane.CurveList.Clear();

                // Set the titles
                graphPane.Title.IsVisible = false;
                graphPane.XAxis.Title.Text = xColumnName;
                graphPane.YAxis.Title.Text = yColumnName;

                // Classification problem
                PointPairList[] scatterplots = new PointPairList[groups.Count()];
                for (int groupIndex = 0; groupIndex < groups.Length; groupIndex++)
                    scatterplots[groupIndex] = new PointPairList();

                for (int rowIndex = 0; rowIndex < inputData.Rows.Count; rowIndex++)
                    for (int groupIndex = 0; groupIndex < groups.Length; groupIndex++)
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
                    LineItem curve = graphPane.AddCurve(groups[groupIndex], scatterplots[groupIndex], color, SymbolType.Square);
                    curve.Line.IsVisible = false;
                    curve.Symbol.Border.IsVisible = false;
                    curve.Symbol.Fill = new Fill(color);
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
