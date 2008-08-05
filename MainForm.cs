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

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using SharpCouch;

namespace CouchBrowse
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		
		private DB mDB;
		private bool mConnected;
		private string mSavedMap="function(doc) { emit(null,doc); }";
		private string mSavedReduce="";
		
		public MainForm()
		{
			InitializeComponent();

		}
		
		void MainFormLoad(object sender, EventArgs e)
		{
			mDB=new DB();
			mConnected=false;
			txtServer.Focus();
			UpdateGreys();
		}
		
		void BtnConnectClick(object sender, EventArgs e)
		{
			RefreshDatabaseList();
			UpdateGreys();
			if(mConnected)
				StatusBar.Items[0].Text="Connected...";
		}
		
		void BtnNewDBClick(object sender, EventArgs e)
		{
			try
			{
				NewDBForm f=new NewDBForm();
				if(f.ShowDialog()==DialogResult.OK)
				{
					mDB.CreateDatabase(txtServer.Text,f.DBName);
					StatusBar.Items[0].Text="Created database '"+f.DBName+"'";
				}
			}
			catch(Exception ex)
			{
				StatusBar.Items[0].Text=ex.Message;
			}
			RefreshDatabaseList();
			UpdateGreys();

		}

		void BtnDeleteDBClick(object sender, EventArgs e)
		{
			string db=GetSelectedDB();
			if(db!="")
			{
				try
				{
					mDB.DeleteDatabase(txtServer.Text,db);
					StatusBar.Items[0].Text="Deleted database '"+db+"'";
				}
				catch(Exception ex)
				{
					StatusBar.Items[0].Text=ex.Message;
				}
			}
			RefreshDatabaseList();
			UpdateGreys();
		}
		
		
		void BtnRefreshDBClick(object sender, EventArgs e)
		{
			RefreshDatabaseList();
			UpdateGreys();
			if(mConnected)
				StatusBar.Items[0].Text="Database list refreshed";
		}

		void BtnGetDocClick(object sender, EventArgs e)
		{
			string db=GetSelectedDB();
			if(db=="") return;
			DocIDForm f=new DocIDForm();
			if(f.ShowDialog()==DialogResult.OK)
			{
				try
				{
					string doc=mDB.GetDocument(txtServer.Text,db,f.DocID);
					// This output really needs formatting, but for now we will just
					// replace the unix line breaks with windows ones...
					doc=doc.Replace("\n","\r\n");
					ResultForm f2=new ResultForm(doc);
					f2.Show();					
				}
				catch(Exception ex)
				{
					StatusBar.Items[0].Text=ex.Message;
				}
			}
		}		
		
		void BtnDeleteDocClick(object sender, EventArgs e)
		{
			string db=GetSelectedDB();
			if(db=="") return;
			DocIDForm f=new DocIDForm();
			if(f.ShowDialog()==DialogResult.OK)
			{
				try
				{
					mDB.DeleteDocument(txtServer.Text,db,f.DocID);
					StatusBar.Items[0].Text="Document deleted";
				}
				catch(Exception ex)
				{
					StatusBar.Items[0].Text=ex.Message;
				}
			}
			UpdateDocCount();
		}
		
		
		void BtnNewDocClick(object sender, EventArgs e)
		{
			string db=GetSelectedDB();
			if(db=="") return;
			NewDocForm f=new NewDocForm();
			if(f.ShowDialog()==DialogResult.OK)
			{
				try
				{
					mDB.CreateDocument(txtServer.Text,db,f.Content);
					StatusBar.Items[0].Text="Document created";
				}
				catch(Exception ex)
				{
					StatusBar.Items[0].Text=ex.Message;
				}
			}
			UpdateDocCount();
		}

		
		void BtnBrowseDocsClick(object sender, EventArgs e)
		{
			string db=GetSelectedDB();
			if(db=="") return;
			BrowseDocsForm f=new BrowseDocsForm(txtServer.Text,db);
			f.Show();
		}
		
		
		void BtnQueryDBClick(object sender, EventArgs e)
		{
			string db=GetSelectedDB();
			if(db=="") return;
			QueryForm f=new QueryForm(mSavedMap,mSavedReduce);
			if(f.ShowDialog()==DialogResult.OK)
			{
				try
				{
					mSavedMap=f.MapFunction;
					mSavedReduce=f.ReduceFunction;
					string result=mDB.ExecTempView(txtServer.Text,db,mSavedMap,mSavedReduce==""?null:mSavedReduce,f.StartKey,f.EndKey);
					// This output really needs formatting, but for now we will just
					// replace the unix line breaks with windows ones...
					result=result.Replace("\n","\r\n");
					ResultForm f2=new ResultForm(result);
					f2.Show();					
				}
				catch(Exception ex)
				{
					StatusBar.Items[0].Text=ex.Message;
				}
			}
		}
		

		void LstDatabasesSelectedIndexChanged(object sender, EventArgs e)
		{
			UpdateGreys();
		}
		
		
		/// <summary>
		/// Get the currently selected database.
		/// </summary>
		/// <returns>The database name or an empty string for no
		/// selection.</returns>
		private string GetSelectedDB()
		{
			if(!mConnected || lstDatabases.SelectedItems.Count!=1)
				return("");
			return lstDatabases.SelectedItems[0].Text;
		}
		
		/// <summary>
		/// Enable/disable buttons according to the current status
		/// </summary>
		private void UpdateGreys()
		{
			bool dbsel=!(GetSelectedDB()=="");

			btnNewDB.Enabled=mConnected;
			btnRefreshDB.Enabled=mConnected;
			
			btnQueryDB.Enabled=dbsel;
			btnDeleteDB.Enabled=dbsel;
			btnDeleteDoc.Enabled=dbsel;
			btnBrowseDocs.Enabled=dbsel;
			btnNewDoc.Enabled=dbsel;
			btnGetDoc.Enabled=dbsel;
		}
		
		/// <summary>
		/// Update the document count in the list for the selected
		/// database. Used, for example, when we know we have just
		/// added or removed a document.
		/// </summary>
		private void UpdateDocCount()
		{
			string db=GetSelectedDB();
			if(db=="") return;
			int count=mDB.CountDocuments(txtServer.Text,db);
			lstDatabases.SelectedItems[0].SubItems[1].Text=count.ToString();
		}

		/// <summary>
		/// Refresh the database list. If an error occurs, a message
		/// is placed in the status bar, otherwise it doesn't touch
		/// it.
		/// </summary>
		private void RefreshDatabaseList()
		{
			try
			{
				string[] dbs=mDB.GetDatabases(txtServer.Text);
				lstDatabases.Items.Clear();
				foreach(string s in dbs)
				{
					ListViewItem li=new ListViewItem(s);
					int count=mDB.CountDocuments(txtServer.Text,s);
					li.SubItems.Add(new ListViewItem.ListViewSubItem(li,count.ToString()));
					lstDatabases.Items.Add(li);
				}
				mConnected=true;
			}
			catch(Exception ex)
			{
				StatusBar.Items[0].Text=ex.Message;
				mConnected=false;
			}
		}
		
		
	}
}
