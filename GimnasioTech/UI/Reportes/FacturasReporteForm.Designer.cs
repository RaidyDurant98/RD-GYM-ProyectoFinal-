﻿namespace GimnasioTech.UI.Reportes
{
    partial class FacturasReporteForm
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
            this.FacturareportViewer = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // FacturareportViewer
            // 
            this.FacturareportViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FacturareportViewer.Location = new System.Drawing.Point(0, 0);
            this.FacturareportViewer.Name = "FacturareportViewer";
            this.FacturareportViewer.Size = new System.Drawing.Size(752, 333);
            this.FacturareportViewer.TabIndex = 0;
            // 
            // FacturasReporteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 333);
            this.Controls.Add(this.FacturareportViewer);
            this.Name = "FacturasReporteForm";
            this.Text = "Reporte de facturas";
            this.Load += new System.EventHandler(this.FacturasReporteForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer FacturareportViewer;
    }
}