/*
 * Created by SharpDevelop.
 * User: John Rey B. Macascas
 * Date: 7/6/2021
 * Time: 2:21 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Contact_Tracing
{
	partial class ReadForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label labelAppName;
		private System.Windows.Forms.Label labelViewLog;
		private System.Windows.Forms.Label label;
		private System.Windows.Forms.TextBox textBoxSearch;
		private System.Windows.Forms.Label labelSearch;
		private System.Windows.Forms.Button buttonView;
		private System.Windows.Forms.Button buttonViewAll;
		private System.Windows.Forms.TextBox textBoxLogs;
		private System.Windows.Forms.Button buttonAdd;
		
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
			this.labelAppName = new System.Windows.Forms.Label();
			this.labelViewLog = new System.Windows.Forms.Label();
			this.textBoxSearch = new System.Windows.Forms.TextBox();
			this.labelSearch = new System.Windows.Forms.Label();
			this.buttonView = new System.Windows.Forms.Button();
			this.buttonViewAll = new System.Windows.Forms.Button();
			this.textBoxLogs = new System.Windows.Forms.TextBox();
			this.buttonAdd = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// labelAppName
			// 
			this.labelAppName.Font = new System.Drawing.Font("Lucida Console", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelAppName.Location = new System.Drawing.Point(33, 20);
			this.labelAppName.Name = "labelAppName";
			this.labelAppName.Size = new System.Drawing.Size(220, 34);
			this.labelAppName.TabIndex = 0;
			this.labelAppName.Text = "Contract Tracing Form";
			this.labelAppName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// labelViewLog
			// 
			this.labelViewLog.Location = new System.Drawing.Point(33, 148);
			this.labelViewLog.Name = "labelViewLog";
			this.labelViewLog.Size = new System.Drawing.Size(100, 23);
			this.labelViewLog.TabIndex = 2;
			this.labelViewLog.Text = "Logs:";
			// 
			// textBoxSearch
			// 
			this.textBoxSearch.Location = new System.Drawing.Point(78, 75);
			this.textBoxSearch.Name = "textBoxSearch";
			this.textBoxSearch.Size = new System.Drawing.Size(115, 20);
			this.textBoxSearch.TabIndex = 3;
			this.textBoxSearch.Text = "Last Name";
			// 
			// labelSearch
			// 
			this.labelSearch.Location = new System.Drawing.Point(33, 78);
			this.labelSearch.Name = "labelSearch";
			this.labelSearch.Size = new System.Drawing.Size(48, 23);
			this.labelSearch.TabIndex = 4;
			this.labelSearch.Text = "Search:";
			// 
			// buttonView
			// 
			this.buttonView.Location = new System.Drawing.Point(33, 104);
			this.buttonView.Name = "buttonView";
			this.buttonView.Size = new System.Drawing.Size(68, 23);
			this.buttonView.TabIndex = 5;
			this.buttonView.Text = "View";
			this.buttonView.UseVisualStyleBackColor = true;
			this.buttonView.Click += new System.EventHandler(this.ButtonViewClick);
			// 
			// buttonViewAll
			// 
			this.buttonViewAll.Location = new System.Drawing.Point(106, 104);
			this.buttonViewAll.Name = "buttonViewAll";
			this.buttonViewAll.Size = new System.Drawing.Size(68, 23);
			this.buttonViewAll.TabIndex = 6;
			this.buttonViewAll.Text = "View All";
			this.buttonViewAll.UseVisualStyleBackColor = true;
			this.buttonViewAll.Click += new System.EventHandler(this.ButtonViewAllClick);
			// 
			// textBoxLogs
			// 
			this.textBoxLogs.Location = new System.Drawing.Point(33, 174);
			this.textBoxLogs.Multiline = true;
			this.textBoxLogs.Name = "textBoxLogs";
			this.textBoxLogs.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.textBoxLogs.Size = new System.Drawing.Size(215, 124);
			this.textBoxLogs.TabIndex = 7;
			// 
			// buttonAdd
			// 
			this.buttonAdd.Location = new System.Drawing.Point(180, 104);
			this.buttonAdd.Name = "buttonAdd";
			this.buttonAdd.Size = new System.Drawing.Size(68, 23);
			this.buttonAdd.TabIndex = 8;
			this.buttonAdd.Text = "Add";
			this.buttonAdd.UseVisualStyleBackColor = true;
			this.buttonAdd.Click += new System.EventHandler(this.ButtonAddClick);
			// 
			// ReadForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 331);
			this.Controls.Add(this.buttonAdd);
			this.Controls.Add(this.textBoxLogs);
			this.Controls.Add(this.buttonViewAll);
			this.Controls.Add(this.buttonView);
			this.Controls.Add(this.labelSearch);
			this.Controls.Add(this.textBoxSearch);
			this.Controls.Add(this.labelViewLog);
			this.Controls.Add(this.labelAppName);
			this.Name = "ReadForm";
			this.Text = "ReadForm";
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
