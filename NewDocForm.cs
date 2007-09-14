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
	/// Description of NewDocForm.
	/// </summary>
	public partial class NewDocForm : Form
	{
		public string Content
		{
			get { return txtContent.Text; }
		}
		public NewDocForm()
		{
			InitializeComponent();
		}
		
		void BtnExampleClick(object sender, EventArgs e)
		{
			txtContent.Text=@"
{
  ""Name"":""Sample Document"",
  ""Author"":""Ciaran"",
  ""Created"":""2007-09-10T18:00:00Z"",
  ""Tags"":[""sample"", ""example""],
  ""Content"":""This is a sample document"",
  ""Help"":""Add an _id field if you don't want it auto-generated!""
}";
		
		}
	}
}
