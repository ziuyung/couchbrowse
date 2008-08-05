// CouchBrowse
// Copyright 2007 Ciaran Gultnieks
//
// This program is free software; you can redistribute it and/or
// modify it under the terms of the GNU General Public License
// as published by the Free Software Foundation; either version 2
// of the License, or (at your option) any later version.
//
// This program is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU General Public License for more details.
//
// You should have received a copy of the GNU General Public License
// along with this program; if not, write to the Free Software
// Foundation, Inc., 51 Franklin Street, Fifth Floor, Boston, MA  02110-1301, USA.

namespace CouchBrowse
{
	partial class QueryForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.label1 = new System.Windows.Forms.Label();
			this.txtMapFunction = new System.Windows.Forms.TextBox();
			this.button2 = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.txtStartKey = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.txtEndKey = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.txtReduceFunction = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(326, 36);
			this.label1.TabIndex = 0;
			this.label1.Text = "The javascript function(s) you enter will be used to define a temporary view, and" +
			" the results will be returned in a new window...";
			// 
			// txtMapFunction
			// 
			this.txtMapFunction.AcceptsTab = true;
			this.txtMapFunction.Location = new System.Drawing.Point(12, 63);
			this.txtMapFunction.Multiline = true;
			this.txtMapFunction.Name = "txtMapFunction";
			this.txtMapFunction.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.txtMapFunction.Size = new System.Drawing.Size(326, 81);
			this.txtMapFunction.TabIndex = 1;
			// 
			// button2
			// 
			this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.button2.Location = new System.Drawing.Point(178, 307);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(75, 23);
			this.button2.TabIndex = 5;
			this.button2.Text = "Cancel";
			this.button2.UseVisualStyleBackColor = true;
			// 
			// button1
			// 
			this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.button1.Location = new System.Drawing.Point(97, 307);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 4;
			this.button1.Text = "OK";
			this.button1.UseVisualStyleBackColor = true;
			// 
			// txtStartKey
			// 
			this.txtStartKey.Location = new System.Drawing.Point(72, 271);
			this.txtStartKey.Name = "txtStartKey";
			this.txtStartKey.Size = new System.Drawing.Size(100, 20);
			this.txtStartKey.TabIndex = 6;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(12, 274);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(54, 23);
			this.label2.TabIndex = 7;
			this.label2.Text = "Start Key:";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(178, 274);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(54, 23);
			this.label3.TabIndex = 9;
			this.label3.Text = "End Key:";
			// 
			// txtEndKey
			// 
			this.txtEndKey.Location = new System.Drawing.Point(238, 271);
			this.txtEndKey.Name = "txtEndKey";
			this.txtEndKey.Size = new System.Drawing.Size(100, 20);
			this.txtEndKey.TabIndex = 8;
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(12, 39);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(100, 22);
			this.label4.TabIndex = 10;
			this.label4.Text = "Map Function:";
			this.label4.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(12, 151);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(149, 22);
			this.label5.TabIndex = 12;
			this.label5.Text = "Reduce Function: (optional)";
			this.label5.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
			// 
			// txtReduceFunction
			// 
			this.txtReduceFunction.AcceptsTab = true;
			this.txtReduceFunction.Location = new System.Drawing.Point(12, 175);
			this.txtReduceFunction.Multiline = true;
			this.txtReduceFunction.Name = "txtReduceFunction";
			this.txtReduceFunction.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.txtReduceFunction.Size = new System.Drawing.Size(326, 81);
			this.txtReduceFunction.TabIndex = 11;
			// 
			// QueryForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(350, 341);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.txtReduceFunction);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txtEndKey);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txtStartKey);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.txtMapFunction);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Name = "QueryForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Query database...";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.TextBox txtMapFunction;
		private System.Windows.Forms.TextBox txtReduceFunction;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtEndKey;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtStartKey;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Label label1;
	}
}
