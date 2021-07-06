
namespace Solve
{
    partial class SolverForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.solutionPanel = new System.Windows.Forms.Panel();
            this.solveButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // solutionPanel
            // 
            this.solutionPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.solutionPanel.Location = new System.Drawing.Point(12, 12);
            this.solutionPanel.Name = "solutionPanel";
            this.solutionPanel.Size = new System.Drawing.Size(500, 500);
            this.solutionPanel.TabIndex = 0;
            // 
            // solveButton
            // 
            this.solveButton.AutoSize = true;
            this.solveButton.Location = new System.Drawing.Point(518, 485);
            this.solveButton.Name = "solveButton";
            this.solveButton.Size = new System.Drawing.Size(59, 27);
            this.solveButton.TabIndex = 1;
            this.solveButton.Text = "Solve";
            this.solveButton.UseVisualStyleBackColor = true;
            this.solveButton.Click += new System.EventHandler(this.solveButton_Click);
            // 
            // SolverForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(587, 521);
            this.Controls.Add(this.solveButton);
            this.Controls.Add(this.solutionPanel);
            this.Name = "SolverForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel solutionPanel;
        private System.Windows.Forms.Button solveButton;
    }
}

