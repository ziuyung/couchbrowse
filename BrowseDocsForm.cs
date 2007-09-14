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
using System.Drawing;
using System.Windows.Forms;

namespace CouchBrowse
{
	/// <summary>
	/// Description of BrowseDocsForm.
	/// </summary>
	public partial class BrowseDocsForm : Form
	{
		private string mServer;
		private string mDB;
		private CouchWrap mCouchWrap=new CouchWrap();
		
		public BrowseDocsForm(string server,string db)
		{
			InitializeComponent();

			mServer=server;
			mDB=db;
		}
		
		void BtnCloseClick(object sender, EventArgs e)
		{
			Close();
		}
		
		void BtnRefreshClick(object sender, EventArgs e)
		{
			UpdateList();
			UpdateGreys();
		}
		
		void BrowseDocsFormLoad(object sender, EventArgs e)
		{
			UpdateList();
			UpdateGreys();
		}
		
		void BtnOpenClick(object sender, EventArgs e)
		{
			if(lstDocs.SelectedItems.Count!=1) return;
			string docid=lstDocs.SelectedItems[0].Text;
			try
			{
				string doc=mCouchWrap.GetDocument(mServer,mDB,docid);
				// This output really needs formatting, but for now we will just
				// replace the unix line breaks with windows ones...
				doc=doc.Replace("\n","\r\n");
				ResultForm f2=new ResultForm(doc);
				f2.Show();					
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.Message);
			}			
		}

		private void UpdateList()
		{
			lstDocs.Items.Clear();
			DocInfo[] docs=mCouchWrap.GetAllDocuments(mServer,mDB);
			foreach(DocInfo d in docs)
			{
				ListViewItem li=new ListViewItem(d.ID);
				li.SubItems.Add(new ListViewItem.ListViewSubItem(li,d.Revision));
				lstDocs.Items.Add(li);
			}
		}
		
		private void UpdateGreys()
		{
			btnOpen.Enabled=lstDocs.SelectedItems.Count==1;
		}
		
		void LstDocsSelectedIndexChanged(object sender, EventArgs e)
		{
			if(lstDocs.SelectedItems.Count==1)
			{
				try
				{
					txtDocument.Text=mCouchWrap.GetDocument(mServer,mDB,lstDocs.SelectedItems[0].Text);
				}
				catch(Exception ex)
				{
					MessageBox.Show(ex.Message);
				}
			}
			else
			{
				txtDocument.Clear();
			}
			UpdateGreys();
		}
	}
}
