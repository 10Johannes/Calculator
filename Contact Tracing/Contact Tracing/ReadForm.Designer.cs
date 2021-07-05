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
		private System.Windows.Forms.Panel panelViewLog;
		private System.Windows.Forms.Label labelViewLog;
		private System.Windows.Forms.Label label
		
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
			this.panelViewLog = new System.Windows.Forms.Panel();
			this.labelViewLog = new System.Windows.Forms.Label();
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
			// panelViewLog
			// 
			this.panelViewLog.AutoScroll = true;
			this.panelViewLog.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.panelViewLog.Location = new System.Drawing.Point(33, 101);
			this.panelViewLog.Name = "panelViewLog";
			this.panelViewLog.Size = new System.Drawing.Size(220, 126);
			this.panelViewLog.TabIndex = 1;
			// 
			// labelViewLog
			// 
			this.labelViewLog.Location = new System.Drawing.Point(33, 75);
			this.labelViewLog.Name = "labelViewLog";
			this.labelViewLog.Size = new System.Drawing.Size(100, 23);
			this.labelViewLog.TabIndex = 2;
			this.labelViewLog.Text = "Logs:";
			// 
			// ReadForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 262);
			this.Controls.Add(this.labelViewLog);
			this.Controls.Add(this.panelViewLog);
			this.Controls.Add(this.labelAppName);
			this.Name = "ReadForm";
			this.Text = "ReadForm";
			this.ResumeLayout(false);

		}
	}
}
