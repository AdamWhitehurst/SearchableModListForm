namespace SearchableModListForm
{
	partial class SearchableModListForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose (bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose ();
			}
			base.Dispose (disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent ()
		{
			this.getModBtn = new System.Windows.Forms.Button ();
			this.modInfoLabel = new System.Windows.Forms.Label ();
			this.modListBox = new System.Windows.Forms.ListBox ();
			this.modSearchBox = new System.Windows.Forms.TextBox ();
			this.SuspendLayout ();
			// 
			// getModBtn
			// 
			this.getModBtn.Location = new System.Drawing.Point (12, 256);
			this.getModBtn.Name = "getModBtn";
			this.getModBtn.Size = new System.Drawing.Size (260, 23);
			this.getModBtn.TabIndex = 3;
			this.getModBtn.Text = "Get Full Mod Info";
			this.getModBtn.UseVisualStyleBackColor = true;
			this.getModBtn.Click += new System.EventHandler (this.getModBtn_Click);
			// 
			// modInfoLabel
			// 
			this.modInfoLabel.AutoSize = true;
			this.modInfoLabel.Location = new System.Drawing.Point (12, 152);
			this.modInfoLabel.Name = "modInfoLabel";
			this.modInfoLabel.Size = new System.Drawing.Size (72, 13);
			this.modInfoLabel.TabIndex = 4;
			this.modInfoLabel.Text = "call ToString()";
			this.modInfoLabel.Click += new System.EventHandler (this.label1_Click);
			// 
			// modListBox
			// 
			this.modListBox.FormattingEnabled = true;
			this.modListBox.HorizontalScrollbar = true;
			this.modListBox.Location = new System.Drawing.Point (12, 54);
			this.modListBox.Name = "modListBox";
			this.modListBox.Size = new System.Drawing.Size (259, 95);
			this.modListBox.TabIndex = 5;
			// 
			// modSearchBox
			// 
			this.modSearchBox.AcceptsReturn = true;
			this.modSearchBox.AcceptsTab = true;
			this.modSearchBox.AllowDrop = true;
			this.modSearchBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
			this.modSearchBox.Location = new System.Drawing.Point (12, 13);
			this.modSearchBox.Name = "modSearchBox";
			this.modSearchBox.Size = new System.Drawing.Size (260, 20);
			this.modSearchBox.TabIndex = 6;
			this.modSearchBox.Text = "Search...";
			this.modSearchBox.TextChanged += new System.EventHandler (this.modSearchBox_TextChanged);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF (6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size (284, 291);
			this.Controls.Add (this.modSearchBox);
			this.Controls.Add (this.modListBox);
			this.Controls.Add (this.modInfoLabel);
			this.Controls.Add (this.getModBtn);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler (this.Form1_Load);
			this.ResumeLayout (false);
			this.PerformLayout ();

		}

		#endregion
		private System.Windows.Forms.Button getModBtn;
		private System.Windows.Forms.Label modInfoLabel;
		public System.Windows.Forms.ListBox modListBox;
		private System.Windows.Forms.TextBox modSearchBox;
	}
}

