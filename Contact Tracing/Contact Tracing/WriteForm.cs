/*
 * Created by SharpDevelop.
 * User: John Rey B. Macascas
 * Date: 7/5/2021
 * Time: 3:26 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Contact_Tracing
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void reset(){
			TextBox[] textBoxArray = {textBoxDate, textBoxTime, textBoxFirstName,
			textBoxMiddleName, textBoxLastName, textBoxAge, textBoxGender, textBoxContactNumber, textBoxEmailAddress, textBoxAddress};
			Label[] labelArray = {labelDate, labelTime, labelFirstName,
			labelMiddleName, labelLastName, labelAge, labelGender, labelContactNumber, labelEmailAddress, labelAddress};
			for (byte i = 0; i < textBoxArray.Length; i++){
					textBoxArray[i].Text = "";
			}
		}
		
		void ButtonSaveClick(object sender, EventArgs e)
		{
			try {
				TextBox[] textBoxArray = {textBoxDate, textBoxTime, textBoxFirstName,
				textBoxMiddleName, textBoxLastName, textBoxAge, textBoxGender, textBoxContactNumber, textBoxEmailAddress, textBoxAddress};
				Label[] labelArray = {labelDate, labelTime, labelFirstName,
				labelMiddleName, labelLastName, labelAge, labelGender, labelContactNumber, labelEmailAddress, labelAddress};
				StreamWriter sw1 = new StreamWriter(Application.StartupPath + "\\Logs\\" + "Logs.txt", true);
				StreamWriter sw2 = new StreamWriter(Application.StartupPath + "\\Profiles\\" + textBoxArray[4].Text + ".txt");
				
				for (byte i = 0; i < textBoxArray.Length; i++){
					if (textBoxArray[i].Text != ""){
						sw1.WriteLine(labelArray[i].Text + " " + textBoxArray[i].Text);
						sw2.WriteLine(labelArray[i].Text + " " + textBoxArray[i].Text);
					} else {
						MessageBox.Show("Please fill up all the fields.", "Contact Tracing", MessageBoxButtons.OK, MessageBoxIcon.Information);
						reset();
						break;
					} if (i == 9) {
					sw1.WriteLine();
					sw1.Close();
					sw2.WriteLine();
					sw2.Close();
					MessageBox.Show("Your information has been recorded!", "Contact Tracing", MessageBoxButtons.OK, MessageBoxIcon.Information);
					reset();
					}
				}
			} catch (Exception err) {
				Application.Restart();
			}
		}
	}
}
