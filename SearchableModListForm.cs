using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace SearchableModListForm
{
	/// <summary>
	/// 
	/// A Windows Application Form that contains a searchable listbox of Mod objects.
	/// Automatically updates the listbox as the user searches for the
	/// field specified by the CompareTo function of class Mod. The search is not case sensitive.
	/// 
	/// </summary>
	public partial class SearchableModListForm : Form
	{
		private Exception MissingModListException;
		private List<Mod> modList;
		public SearchableModListForm ()
		{
			throw MissingModListException;
		}
		public SearchableModListForm (List<Mod> ml)
		{
			InitializeComponent ();
			modList = ml;
			modListBox.DataSource = modList;
			modListBox.DisplayMember = "modName";
		}
		private void Form1_Load (object sender, EventArgs e)
		{

		}

		private void modInfoBox_TextChanged (object sender, EventArgs e)
		{

		}

		private void label1_Click (object sender, EventArgs e)
		{

		}

		private void getModBtn_Click (object sender, EventArgs e)
		{
			Mod mod = (Mod)modListBox.SelectedItem;
			if (mod != null)
				modInfoLabel.Text = mod.ToString ();
		}

		private void modSearchBox_TextChanged (object sender, EventArgs e)
		{
			SearchModList (modSearchBox.Text);
		}
		public void SearchModList (string sort)
		{
			List<Mod> list = new List<Mod> ();
			foreach (Mod m in modList)
			{
				if (m.modName.ToLower ().Contains (sort.ToLower ()))
				{
					list.Add (m);
				}
			}
			modListBox.DataSource = list;
		}
	}
}
