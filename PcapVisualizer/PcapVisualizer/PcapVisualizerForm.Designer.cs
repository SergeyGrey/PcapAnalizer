﻿namespace PcapVisualizer.UI
{
    partial class PcapVisualizerForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.visualizerLayout = new System.Windows.Forms.TableLayoutPanel();
            this.filterControl = new PcapVisualizer.FilterControl();
            this.visualizerLayout.SuspendLayout();
            this.SuspendLayout();
            // 
            // visualizerLayout
            // 
            this.visualizerLayout.ColumnCount = 1;
            this.visualizerLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.visualizerLayout.Controls.Add(this.filterControl, 0, 0);
            this.visualizerLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.visualizerLayout.Location = new System.Drawing.Point(0, 0);
            this.visualizerLayout.Name = "visualizerLayout";
            this.visualizerLayout.RowCount = 4;
            this.visualizerLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.visualizerLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.visualizerLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.visualizerLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.visualizerLayout.Size = new System.Drawing.Size(818, 414);
            this.visualizerLayout.TabIndex = 0;
            // 
            // filterControl
            // 
            this.filterControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.filterControl.Location = new System.Drawing.Point(3, 3);
            this.filterControl.MaximumSize = new System.Drawing.Size(0, 30);
            this.filterControl.MinimumSize = new System.Drawing.Size(550, 30);
            this.filterControl.Name = "filterControl";
            this.filterControl.Size = new System.Drawing.Size(812, 30);
            this.filterControl.TabIndex = 0;
            // 
            // PcapVisualizerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(818, 414);
            this.Controls.Add(this.visualizerLayout);
            this.MinimumSize = new System.Drawing.Size(600, 400);
            this.Name = "PcapVisualizerForm";
            this.Text = "PcapVisualizerForm";
            this.visualizerLayout.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel visualizerLayout;
        private FilterControl filterControl;

    }
}

