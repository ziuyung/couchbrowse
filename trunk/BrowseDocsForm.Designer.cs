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
	partial class BrowseDocsForm
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
			this.lstDocs = new System.Windows.Forms.ListView();
			this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
			this.txtDocument = new System.Windows.Forms.TextBox();
			this.btnClose = new System.Windows.Forms.Button();
			this.btnRefresh = new System.Windows.Forms.Button();
			this.btnOpen = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// lstDocs
			// 
			this.lstDocs.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
									this.columnHeader1,
									this.columnHeader2});
			this.lstDocs.FullRowSelect = true;
			this.lstDocs.HideSelection = false;
			this.lstDocs.Location = new System.Drawing.Point(13, 13);
			this.lstDocs.Name = "lstDocs";
			this.lstDocs.Size = new System.Drawing.Size(387, 169);
			this.lstDocs.TabIndex = 0;
			this.lstDocs.UseCompatibleStateImageBehavior = false;
			this.lstDocs.View = System.Windows.Forms.View.Details;
			this.lstDocs.SelectedIndexChanged += new System.EventHandler(this.LstDocsSelectedIndexChanged);
			// 
			// columnHeader1
			// 
			this.columnHeader1.Text = "Document ID";
			this.columnHeader1.Width = 250;
			// 
			// columnHeader2
			// 
			this.columnHeader2.Text = "Revision";
			this.columnHeader2.Width = 133;
			// 
			// txtDocument
			// 
			this.txtDocument.Location = new System.Drawing.Point(12, 188);
			this.txtDocument.Multiline = true;
			this.txtDocument.Name = "txtDocument";
			this.txtDocument.ReadOnly = true;
			this.txtDocument.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.txtDocument.Size = new System.Drawing.Size(388, 138);
			this.txtDocument.TabIndex = 1;
			// 
			// btnClose
			// 
			this.btnClose.Location = new System.Drawing.Point(89, 332);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(75, 23);
			this.btnClose.TabIndex = 2;
			this.btnClose.Text = "Close";
			this.btnClose.UseVisualStyleBackColor = true;
			this.btnClose.Click += new System.EventHandler(this.BtnCloseClick);
			// 
			// btnRefresh
			// 
			this.btnRefresh.Location = new System.Drawing.Point(170, 332);
			this.btnRefresh.Name = "btnRefresh";
			this.btnRefresh.Size = new System.Drawing.Size(75, 23);
			this.btnRefresh.TabIndex = 3;
			this.btnRefresh.Text = "Refresh";
			this.btnRefresh.UseVisualStyleBackColor = true;
			this.btnRefresh.Click += new System.EventHandler(this.BtnRefreshClick);
			// 
			// btnOpen
			// 
			this.btnOpen.Location = new System.Drawing.Point(251, 332);
			this.btnOpen.Name = "btnOpen";
			this.btnOpen.Size = new System.Drawing.Size(75, 23);
			this.btnOpen.TabIndex = 4;
			this.btnOpen.Text = "Open...";
			this.btnOpen.UseVisualStyleBackColor = true;
			this.btnOpen.Click += new System.EventHandler(this.BtnOpenClick);
			// 
			// BrowseDocsForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(412, 360);
			this.Controls.Add(this.btnOpen);
			this.Controls.Add(this.btnRefresh);
			this.Controls.Add(this.btnClose);
			this.Controls.Add(this.txtDocument);
			this.Controls.Add(this.lstDocs);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Name = "BrowseDocsForm";
			this.Text = "Browse Documents";
			this.Load += new System.EventHandler(this.BrowseDocsFormLoad);
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Button btnOpen;
		private System.Windows.Forms.Button btnRefresh;
		private System.Windows.Forms.Button btnClose;
		private System.Windows.Forms.TextBox txtDocument;
		private System.Windows.Forms.ColumnHeader columnHeader2;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.ListView lstDocs;
	}
}
