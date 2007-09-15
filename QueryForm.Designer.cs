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
			this.txtViewDef = new System.Windows.Forms.TextBox();
			this.button2 = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.txtStartKey = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.txtEndKey = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(326, 36);
			this.label1.TabIndex = 0;
			this.label1.Text = "The javascript function you enter will be used to define a temporary view, and th" +
			"e results will be returned in a new window...";
			// 
			// txtViewDef
			// 
			this.txtViewDef.AcceptsTab = true;
			this.txtViewDef.Location = new System.Drawing.Point(12, 48);
			this.txtViewDef.Multiline = true;
			this.txtViewDef.Name = "txtViewDef";
			this.txtViewDef.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.txtViewDef.Size = new System.Drawing.Size(326, 139);
			this.txtViewDef.TabIndex = 1;
			// 
			// button2
			// 
			this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.button2.Location = new System.Drawing.Point(178, 229);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(75, 23);
			this.button2.TabIndex = 5;
			this.button2.Text = "Cancel";
			this.button2.UseVisualStyleBackColor = true;
			// 
			// button1
			// 
			this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.button1.Location = new System.Drawing.Point(97, 229);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 4;
			this.button1.Text = "OK";
			this.button1.UseVisualStyleBackColor = true;
			// 
			// txtStartKey
			// 
			this.txtStartKey.Location = new System.Drawing.Point(72, 193);
			this.txtStartKey.Name = "txtStartKey";
			this.txtStartKey.Size = new System.Drawing.Size(100, 20);
			this.txtStartKey.TabIndex = 6;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(12, 196);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(54, 23);
			this.label2.TabIndex = 7;
			this.label2.Text = "Start Key:";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(178, 196);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(54, 23);
			this.label3.TabIndex = 9;
			this.label3.Text = "End Key:";
			// 
			// txtEndKey
			// 
			this.txtEndKey.Location = new System.Drawing.Point(238, 193);
			this.txtEndKey.Name = "txtEndKey";
			this.txtEndKey.Size = new System.Drawing.Size(100, 20);
			this.txtEndKey.TabIndex = 8;
			// 
			// QueryForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(350, 262);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txtEndKey);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txtStartKey);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.txtViewDef);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Name = "QueryForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Query database...";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.TextBox txtEndKey;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtStartKey;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.TextBox txtViewDef;
		private System.Windows.Forms.Label label1;
	}
}
