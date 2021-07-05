/*
 * Created by SharpDevelop.
 * User: John Rey B. Macascas
 * Date: 7/5/2021
 * Time: 3:26 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Contact_Tracing
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.TextBox textBoxFirstName;
		private System.Windows.Forms.Label labelFirstName;
		private System.Windows.Forms.Label labelMiddleName;
		private System.Windows.Forms.TextBox textBoxMiddleName;
		private System.Windows.Forms.Label labelLastName;
		private System.Windows.Forms.TextBox textBoxLastName;
		private System.Windows.Forms.Label labelContactNumber;
		private System.Windows.Forms.TextBox textBoxContactNumber;
		private System.Windows.Forms.Label labelGender;
		private System.Windows.Forms.TextBox textBoxGender;
		private System.Windows.Forms.Label labelAge;
		private System.Windows.Forms.TextBox textBoxAge;
		private System.Windows.Forms.Label labelAddress;
		private System.Windows.Forms.TextBox textBoxAddress;
		private System.Windows.Forms.Label labelEmailAddress;
		private System.Windows.Forms.TextBox textBoxEmailAddress;
		private System.Windows.Forms.Label labelTime;
		private System.Windows.Forms.TextBox textBoxTime;
		private System.Windows.Forms.Label labelDate;
		private System.Windows.Forms.TextBox textBoxDate;
		private System.Windows.Forms.Button buttonSave;
		private System.Windows.Forms.Button View;
		private System.Windows.Forms.Label labelAppName;
		
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
			this.textBoxFirstName = new System.Windows.Forms.TextBox();
			this.labelFirstName = new System.Windows.Forms.Label();
			this.labelMiddleName = new System.Windows.Forms.Label();
			this.textBoxMiddleName = new System.Windows.Forms.TextBox();
			this.labelLastName = new System.Windows.Forms.Label();
			this.textBoxLastName = new System.Windows.Forms.TextBox();
			this.labelContactNumber = new System.Windows.Forms.Label();
			this.textBoxContactNumber = new System.Windows.Forms.TextBox();
			this.labelGender = new System.Windows.Forms.Label();
			this.textBoxGender = new System.Windows.Forms.TextBox();
			this.labelAge = new System.Windows.Forms.Label();
			this.textBoxAge = new System.Windows.Forms.TextBox();
			this.labelAddress = new System.Windows.Forms.Label();
			this.textBoxAddress = new System.Windows.Forms.TextBox();
			this.labelEmailAddress = new System.Windows.Forms.Label();
			this.textBoxEmailAddress = new System.Windows.Forms.TextBox();
			this.labelTime = new System.Windows.Forms.Label();
			this.textBoxTime = new System.Windows.Forms.TextBox();
			this.labelDate = new System.Windows.Forms.Label();
			this.textBoxDate = new System.Windows.Forms.TextBox();
			this.labelAppName = new System.Windows.Forms.Label();
			this.buttonSave = new System.Windows.Forms.Button();
			this.View = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// textBoxFirstName
			// 
			this.textBoxFirstName.Location = new System.Drawing.Point(34, 180);
			this.textBoxFirstName.Name = "textBoxFirstName";
			this.textBoxFirstName.Size = new System.Drawing.Size(100, 20);
			this.textBoxFirstName.TabIndex = 2;
			// 
			// labelFirstName
			// 
			this.labelFirstName.Location = new System.Drawing.Point(34, 154);
			this.labelFirstName.Name = "labelFirstName";
			this.labelFirstName.Size = new System.Drawing.Size(100, 23);
			this.labelFirstName.TabIndex = 1;
			this.labelFirstName.Text = "First Name:";
			// 
			// labelMiddleName
			// 
			this.labelMiddleName.Location = new System.Drawing.Point(34, 217);
			this.labelMiddleName.Name = "labelMiddleName";
			this.labelMiddleName.Size = new System.Drawing.Size(100, 23);
			this.labelMiddleName.TabIndex = 3;
			this.labelMiddleName.Text = "Middle Name:";
			// 
			// textBoxMiddleName
			// 
			this.textBoxMiddleName.Location = new System.Drawing.Point(34, 243);
			this.textBoxMiddleName.Name = "textBoxMiddleName";
			this.textBoxMiddleName.Size = new System.Drawing.Size(100, 20);
			this.textBoxMiddleName.TabIndex = 3;
			// 
			// labelLastName
			// 
			this.labelLastName.Location = new System.Drawing.Point(34, 281);
			this.labelLastName.Name = "labelLastName";
			this.labelLastName.Size = new System.Drawing.Size(100, 23);
			this.labelLastName.TabIndex = 5;
			this.labelLastName.Text = "Last Name:";
			// 
			// textBoxLastName
			// 
			this.textBoxLastName.Location = new System.Drawing.Point(34, 307);
			this.textBoxLastName.Name = "textBoxLastName";
			this.textBoxLastName.Size = new System.Drawing.Size(100, 20);
			this.textBoxLastName.TabIndex = 4;
			// 
			// labelContactNumber
			// 
			this.labelContactNumber.Location = new System.Drawing.Point(153, 281);
			this.labelContactNumber.Name = "labelContactNumber";
			this.labelContactNumber.Size = new System.Drawing.Size(100, 23);
			this.labelContactNumber.TabIndex = 11;
			this.labelContactNumber.Text = "Contact Number:";
			// 
			// textBoxContactNumber
			// 
			this.textBoxContactNumber.Location = new System.Drawing.Point(153, 307);
			this.textBoxContactNumber.Name = "textBoxContactNumber";
			this.textBoxContactNumber.Size = new System.Drawing.Size(100, 20);
			this.textBoxContactNumber.TabIndex = 7;
			// 
			// labelGender
			// 
			this.labelGender.Location = new System.Drawing.Point(153, 217);
			this.labelGender.Name = "labelGender";
			this.labelGender.Size = new System.Drawing.Size(100, 23);
			this.labelGender.TabIndex = 9;
			this.labelGender.Text = "Gender:";
			// 
			// textBoxGender
			// 
			this.textBoxGender.Location = new System.Drawing.Point(153, 243);
			this.textBoxGender.Name = "textBoxGender";
			this.textBoxGender.Size = new System.Drawing.Size(100, 20);
			this.textBoxGender.TabIndex = 6;
			// 
			// labelAge
			// 
			this.labelAge.Location = new System.Drawing.Point(153, 154);
			this.labelAge.Name = "labelAge";
			this.labelAge.Size = new System.Drawing.Size(100, 23);
			this.labelAge.TabIndex = 7;
			this.labelAge.Text = "Age:";
			// 
			// textBoxAge
			// 
			this.textBoxAge.Location = new System.Drawing.Point(153, 180);
			this.textBoxAge.Name = "textBoxAge";
			this.textBoxAge.Size = new System.Drawing.Size(100, 20);
			this.textBoxAge.TabIndex = 5;
			// 
			// labelAddress
			// 
			this.labelAddress.Location = new System.Drawing.Point(34, 408);
			this.labelAddress.Name = "labelAddress";
			this.labelAddress.Size = new System.Drawing.Size(100, 23);
			this.labelAddress.TabIndex = 15;
			this.labelAddress.Text = "Address:";
			// 
			// textBoxAddress
			// 
			this.textBoxAddress.Location = new System.Drawing.Point(34, 434);
			this.textBoxAddress.Margin = new System.Windows.Forms.Padding(0);
			this.textBoxAddress.Name = "textBoxAddress";
			this.textBoxAddress.Size = new System.Drawing.Size(219, 20);
			this.textBoxAddress.TabIndex = 9;
			// 
			// labelEmailAddress
			// 
			this.labelEmailAddress.Location = new System.Drawing.Point(34, 345);
			this.labelEmailAddress.Name = "labelEmailAddress";
			this.labelEmailAddress.Size = new System.Drawing.Size(100, 23);
			this.labelEmailAddress.TabIndex = 13;
			this.labelEmailAddress.Text = "E-mail Address:";
			// 
			// textBoxEmailAddress
			// 
			this.textBoxEmailAddress.Location = new System.Drawing.Point(34, 371);
			this.textBoxEmailAddress.Name = "textBoxEmailAddress";
			this.textBoxEmailAddress.Size = new System.Drawing.Size(219, 20);
			this.textBoxEmailAddress.TabIndex = 8;
			// 
			// labelTime
			// 
			this.labelTime.Location = new System.Drawing.Point(153, 74);
			this.labelTime.Name = "labelTime";
			this.labelTime.Size = new System.Drawing.Size(100, 23);
			this.labelTime.TabIndex = 19;
			this.labelTime.Text = "Time:";
			// 
			// textBoxTime
			// 
			this.textBoxTime.Location = new System.Drawing.Point(153, 100);
			this.textBoxTime.Name = "textBoxTime";
			this.textBoxTime.Size = new System.Drawing.Size(100, 20);
			this.textBoxTime.TabIndex = 1;
			// 
			// labelDate
			// 
			this.labelDate.Location = new System.Drawing.Point(34, 74);
			this.labelDate.Name = "labelDate";
			this.labelDate.Size = new System.Drawing.Size(100, 23);
			this.labelDate.TabIndex = 17;
			this.labelDate.Text = "Date:";
			// 
			// textBoxDate
			// 
			this.textBoxDate.Location = new System.Drawing.Point(34, 100);
			this.textBoxDate.Name = "textBoxDate";
			this.textBoxDate.Size = new System.Drawing.Size(100, 20);
			this.textBoxDate.TabIndex = 0;
			// 
			// labelAppName
			// 
			this.labelAppName.Font = new System.Drawing.Font("Lucida Console", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelAppName.Location = new System.Drawing.Point(33, 20);
			this.labelAppName.Name = "labelAppName";
			this.labelAppName.Size = new System.Drawing.Size(220, 34);
			this.labelAppName.TabIndex = 20;
			this.labelAppName.Text = "Contact Tracing Form";
			this.labelAppName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// buttonSave
			// 
			this.buttonSave.Location = new System.Drawing.Point(56, 475);
			this.buttonSave.Name = "buttonSave";
			this.buttonSave.Size = new System.Drawing.Size(75, 23);
			this.buttonSave.TabIndex = 10;
			this.buttonSave.Text = "Save";
			this.buttonSave.UseVisualStyleBackColor = true;
			this.buttonSave.Click += new System.EventHandler(this.ButtonSaveClick);
			// 
			// View
			// 
			this.View.Location = new System.Drawing.Point(149, 475);
			this.View.Name = "View";
			this.View.Size = new System.Drawing.Size(75, 23);
			this.View.TabIndex = 22;
			this.View.Text = "View";
			this.View.UseVisualStyleBackColor = true;
			this.View.Click += new System.EventHandler(this.ViewClick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoScroll = true;
			this.ClientSize = new System.Drawing.Size(284, 262);
			this.Controls.Add(this.View);
			this.Controls.Add(this.buttonSave);
			this.Controls.Add(this.labelAppName);
			this.Controls.Add(this.labelTime);
			this.Controls.Add(this.textBoxTime);
			this.Controls.Add(this.labelDate);
			this.Controls.Add(this.textBoxDate);
			this.Controls.Add(this.labelAddress);
			this.Controls.Add(this.textBoxAddress);
			this.Controls.Add(this.labelEmailAddress);
			this.Controls.Add(this.textBoxEmailAddress);
			this.Controls.Add(this.labelContactNumber);
			this.Controls.Add(this.textBoxContactNumber);
			this.Controls.Add(this.labelGender);
			this.Controls.Add(this.textBoxGender);
			this.Controls.Add(this.labelAge);
			this.Controls.Add(this.textBoxAge);
			this.Controls.Add(this.labelLastName);
			this.Controls.Add(this.textBoxLastName);
			this.Controls.Add(this.labelMiddleName);
			this.Controls.Add(this.textBoxMiddleName);
			this.Controls.Add(this.labelFirstName);
			this.Controls.Add(this.textBoxFirstName);
			this.Name = "MainForm";
			this.Text = "Contact Tracing";
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
