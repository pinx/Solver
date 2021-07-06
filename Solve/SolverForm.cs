using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Solve
{
    public partial class SolverForm : Form
    {
        public SolverForm()
        {
            InitializeComponent();
        }

        private void solveButton_Click(object sender, EventArgs e)
        {
            var solver = new Solver();
            var problem = new Problem();
            var rectangles = solver.Solve(problem);
            this.drawSolution(rectangles);
        }

        private void drawSolution(List<Rectangle> rectangles)
        {
            foreach (var rectangle in rectangles)
            {
                this.solutionPanel.Controls.Add(new Panel()
                {
                    BorderStyle = BorderStyle.FixedSingle,
                    Location = rectangle.Location,
                    Size = rectangle.Size
                });
            }
        }
    }
}
