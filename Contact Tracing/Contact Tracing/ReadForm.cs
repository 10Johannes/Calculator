/*
 * Created by SharpDevelop.
 * User: John Rey B. Macascas
 * Date: 7/6/2021
 * Time: 2:21 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Contact_Tracing
{
	/// <summary>
	/// Description of ReadForm.
	/// </summary>
	public partial class ReadForm : Form
	{
		public ReadForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void ButtonViewClick(object sender, EventArgs e)
		{
			try {
				long length = new System.IO.FileInfo(Application.StartupPath + "\\Profiles\\" + textBoxSearch.Text + ".txt").Length;
				if (length != 0){
					textBoxLogs.Text = " ";
					String text = System.IO.File.ReadAllText(Application.StartupPath + "\\Profiles\\" + textBoxSearch.Text + ".txt");
					textBoxLogs.Text = text;
				} else {
					MessageBox.Show("The file does not exist.", "Contact Tracing", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
			} catch (Exception err) {
				MessageBox.Show("The file does not exist.", "Contact Tracing", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
		}
		void ButtonViewAllClick(object sender, EventArgs e)
		{
			try {
				long length = new System.IO.FileInfo(Application.StartupPath + "\\Logs\\" + "Logs.txt").Length;
				if (length != 0){
					textBoxLogs.Text = " ";
					String text = System.IO.File.ReadAllText(Application.StartupPath + "\\Logs\\" + "Logs.txt");
					textBoxLogs.Text = text;
				} else {
					MessageBox.Show("The file does not exist.", "Contact Tracing", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
			} catch (Exception err) {
				MessageBox.Show("The file does not exist."), "Contact Tracing", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
		}
		void ButtonAddClick(object sender, EventArgs e)
		{
			this.Hide();
		    var MainForm = new MainForm();
		    MainForm.Closed += (s, args) => this.Close(); 
		    MainForm.Show();
		}
	}
}
