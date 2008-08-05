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
	partial class MainForm
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
			this.txtServer = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.btnConnect = new System.Windows.Forms.Button();
			this.lstDatabases = new System.Windows.Forms.ListView();
			this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
			this.label2 = new System.Windows.Forms.Label();
			this.StatusBar = new System.Windows.Forms.StatusStrip();
			this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
			this.btnNewDB = new System.Windows.Forms.Button();
			this.btnDeleteDB = new System.Windows.Forms.Button();
			this.btnQueryDB = new System.Windows.Forms.Button();
			this.btnRefreshDB = new System.Windows.Forms.Button();
			this.btnGetDoc = new System.Windows.Forms.Button();
			this.btnNewDoc = new System.Windows.Forms.Button();
			this.btnBrowseDocs = new System.Windows.Forms.Button();
			this.btnDeleteDoc = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.StatusBar.SuspendLayout();
			this.SuspendLayout();
			// 
			// txtServer
			// 
			this.txtServer.Location = new System.Drawing.Point(80, 9);
			this.txtServer.Name = "txtServer";
			this.txtServer.Size = new System.Drawing.Size(237, 20);
			this.txtServer.TabIndex = 0;
			this.txtServer.Text = "http://192.168.0.21:5984";
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(12, 13);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(47, 17);
			this.label1.TabIndex = 1;
			this.label1.Text = "Server:";
			// 
			// btnConnect
			// 
			this.btnConnect.Location = new System.Drawing.Point(324, 9);
			this.btnConnect.Name = "btnConnect";
			this.btnConnect.Size = new System.Drawing.Size(75, 20);
			this.btnConnect.TabIndex = 2;
			this.btnConnect.Text = "Connect";
			this.btnConnect.UseVisualStyleBackColor = true;
			this.btnConnect.Click += new System.EventHandler(this.BtnConnectClick);
			// 
			// lstDatabases
			// 
			this.lstDatabases.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
									this.columnHeader1,
									this.columnHeader2});
			this.lstDatabases.FullRowSelect = true;
			this.lstDatabases.HideSelection = false;
			this.lstDatabases.Location = new System.Drawing.Point(80, 47);
			this.lstDatabases.MultiSelect = false;
			this.lstDatabases.Name = "lstDatabases";
			this.lstDatabases.Size = new System.Drawing.Size(319, 122);
			this.lstDatabases.TabIndex = 3;
			this.lstDatabases.UseCompatibleStateImageBehavior = false;
			this.lstDatabases.View = System.Windows.Forms.View.Details;
			this.lstDatabases.SelectedIndexChanged += new System.EventHandler(this.LstDatabasesSelectedIndexChanged);
			// 
			// columnHeader1
			// 
			this.columnHeader1.Text = "Name";
			this.columnHeader1.Width = 200;
			// 
			// columnHeader2
			// 
			this.columnHeader2.Text = "Documents";
			this.columnHeader2.Width = 115;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(12, 47);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(62, 23);
			this.label2.TabIndex = 4;
			this.label2.Text = "Databases:";
			// 
			// StatusBar
			// 
			this.StatusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.toolStripStatusLabel1});
			this.StatusBar.Location = new System.Drawing.Point(0, 260);
			this.StatusBar.Name = "StatusBar";
			this.StatusBar.Size = new System.Drawing.Size(408, 22);
			this.StatusBar.TabIndex = 5;
			this.StatusBar.Text = "statusStrip1";
			// 
			// toolStripStatusLabel1
			// 
			this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
			this.toolStripStatusLabel1.Size = new System.Drawing.Size(192, 17);
			this.toolStripStatusLabel1.Text = "Enter server address and click connect";
			this.toolStripStatusLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// btnNewDB
			// 
			this.btnNewDB.Location = new System.Drawing.Point(80, 176);
			this.btnNewDB.Name = "btnNewDB";
			this.btnNewDB.Size = new System.Drawing.Size(75, 23);
			this.btnNewDB.TabIndex = 6;
			this.btnNewDB.Text = "New...";
			this.btnNewDB.UseVisualStyleBackColor = true;
			this.btnNewDB.Click += new System.EventHandler(this.BtnNewDBClick);
			// 
			// btnDeleteDB
			// 
			this.btnDeleteDB.Location = new System.Drawing.Point(161, 176);
			this.btnDeleteDB.Name = "btnDeleteDB";
			this.btnDeleteDB.Size = new System.Drawing.Size(75, 23);
			this.btnDeleteDB.TabIndex = 7;
			this.btnDeleteDB.Text = "Delete";
			this.btnDeleteDB.UseVisualStyleBackColor = true;
			this.btnDeleteDB.Click += new System.EventHandler(this.BtnDeleteDBClick);
			// 
			// btnQueryDB
			// 
			this.btnQueryDB.Location = new System.Drawing.Point(242, 176);
			this.btnQueryDB.Name = "btnQueryDB";
			this.btnQueryDB.Size = new System.Drawing.Size(75, 23);
			this.btnQueryDB.TabIndex = 8;
			this.btnQueryDB.Text = "Query...";
			this.btnQueryDB.UseVisualStyleBackColor = true;
			this.btnQueryDB.Click += new System.EventHandler(this.BtnQueryDBClick);
			// 
			// btnRefreshDB
			// 
			this.btnRefreshDB.Location = new System.Drawing.Point(324, 176);
			this.btnRefreshDB.Name = "btnRefreshDB";
			this.btnRefreshDB.Size = new System.Drawing.Size(75, 23);
			this.btnRefreshDB.TabIndex = 9;
			this.btnRefreshDB.Text = "Refresh";
			this.btnRefreshDB.UseVisualStyleBackColor = true;
			this.btnRefreshDB.Click += new System.EventHandler(this.BtnRefreshDBClick);
			// 
			// btnGetDoc
			// 
			this.btnGetDoc.Location = new System.Drawing.Point(80, 223);
			this.btnGetDoc.Name = "btnGetDoc";
			this.btnGetDoc.Size = new System.Drawing.Size(75, 23);
			this.btnGetDoc.TabIndex = 10;
			this.btnGetDoc.Text = "Get...";
			this.btnGetDoc.UseVisualStyleBackColor = true;
			this.btnGetDoc.Click += new System.EventHandler(this.BtnGetDocClick);
			// 
			// btnNewDoc
			// 
			this.btnNewDoc.Location = new System.Drawing.Point(161, 223);
			this.btnNewDoc.Name = "btnNewDoc";
			this.btnNewDoc.Size = new System.Drawing.Size(75, 23);
			this.btnNewDoc.TabIndex = 11;
			this.btnNewDoc.Text = "New...";
			this.btnNewDoc.UseVisualStyleBackColor = true;
			this.btnNewDoc.Click += new System.EventHandler(this.BtnNewDocClick);
			// 
			// btnBrowseDocs
			// 
			this.btnBrowseDocs.Location = new System.Drawing.Point(324, 223);
			this.btnBrowseDocs.Name = "btnBrowseDocs";
			this.btnBrowseDocs.Size = new System.Drawing.Size(74, 23);
			this.btnBrowseDocs.TabIndex = 12;
			this.btnBrowseDocs.Text = "Browse...";
			this.btnBrowseDocs.UseVisualStyleBackColor = true;
			this.btnBrowseDocs.Click += new System.EventHandler(this.BtnBrowseDocsClick);
			// 
			// btnDeleteDoc
			// 
			this.btnDeleteDoc.Location = new System.Drawing.Point(242, 223);
			this.btnDeleteDoc.Name = "btnDeleteDoc";
			this.btnDeleteDoc.Size = new System.Drawing.Size(75, 23);
			this.btnDeleteDoc.TabIndex = 13;
			this.btnDeleteDoc.Text = "Delete...";
			this.btnDeleteDoc.UseVisualStyleBackColor = true;
			this.btnDeleteDoc.Click += new System.EventHandler(this.BtnDeleteDocClick);
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(12, 228);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(62, 23);
			this.label3.TabIndex = 14;
			this.label3.Text = "Docs:";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(408, 282);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.btnDeleteDoc);
			this.Controls.Add(this.btnBrowseDocs);
			this.Controls.Add(this.btnNewDoc);
			this.Controls.Add(this.btnGetDoc);
			this.Controls.Add(this.btnRefreshDB);
			this.Controls.Add(this.btnQueryDB);
			this.Controls.Add(this.btnDeleteDB);
			this.Controls.Add(this.btnNewDB);
			this.Controls.Add(this.StatusBar);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.lstDatabases);
			this.Controls.Add(this.btnConnect);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtServer);
			this.Name = "MainForm";
			this.Text = "CouchBrowse";
			this.Load += new System.EventHandler(this.MainFormLoad);
			this.StatusBar.ResumeLayout(false);
			this.StatusBar.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Button btnBrowseDocs;
		private System.Windows.Forms.Button btnNewDoc;
		private System.Windows.Forms.Button btnRefreshDB;
		private System.Windows.Forms.Button btnGetDoc;
		private System.Windows.Forms.Button btnDeleteDoc;
		private System.Windows.Forms.Button btnNewDB;
		private System.Windows.Forms.Button btnDeleteDB;
		private System.Windows.Forms.Button btnQueryDB;
		private System.Windows.Forms.ColumnHeader columnHeader2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.ListView lstDatabases;
		private System.Windows.Forms.StatusStrip StatusBar;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
		private System.Windows.Forms.Button btnConnect;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtServer;
	}
}
