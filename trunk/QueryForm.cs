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
	/// Description of QueryForm.
	/// </summary>
	public partial class QueryForm : Form
	{
		
		public string MapFunction
		{
			get { return txtMapFunction.Text; }
		}		

		public string ReduceFunction
		{
			get { return txtReduceFunction.Text; }
		}

		public string StartKey
		{
			get
			{
				if(txtStartKey.Text=="")
					return null;
				else
					return txtStartKey.Text;
			}
		}

		public string EndKey
		{
			get
			{
				if(txtEndKey.Text=="")
					return null;
				else
					return txtEndKey.Text;
			}
		}		
		
		public QueryForm(string initialmap,string initialreduce)
		{
			InitializeComponent();
			txtMapFunction.Text=initialmap;
			txtReduceFunction.Text=initialreduce;
			
		}
	}
}
