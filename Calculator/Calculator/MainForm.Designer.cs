﻿/*
 * Created by SharpDevelop.
 * User: www.rica.com
 * Date: 5/21/2021
 * Time: 11:36 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Calculator
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Button button5;
		private System.Windows.Forms.Button button6;
		private System.Windows.Forms.Button button7;
		private System.Windows.Forms.Button button8;
		private System.Windows.Forms.Button button9;
		private System.Windows.Forms.Button button0;
		private System.Windows.Forms.Button buttonPoint;
		private System.Windows.Forms.Button buttonAdd;
		private System.Windows.Forms.Button buttonDivide;
		private System.Windows.Forms.Button buttonMultiply;
		private System.Windows.Forms.Button buttonSubtract;
		private System.Windows.Forms.Button buttonEqual;
		private System.Windows.Forms.Button buttonPercent;
		private System.Windows.Forms.Button buttonReciprocate;
		private System.Windows.Forms.Button buttonSquareRoot;
		private System.Windows.Forms.Button buttonClear;
		private System.Windows.Forms.Button buttonClearEntry;
		private System.Windows.Forms.Button buttonDelete;
		private System.Windows.Forms.TextBox textBox1;
		
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
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.button5 = new System.Windows.Forms.Button();
			this.button6 = new System.Windows.Forms.Button();
			this.button7 = new System.Windows.Forms.Button();
			this.button8 = new System.Windows.Forms.Button();
			this.button9 = new System.Windows.Forms.Button();
			this.button0 = new System.Windows.Forms.Button();
			this.buttonPoint = new System.Windows.Forms.Button();
			this.buttonAdd = new System.Windows.Forms.Button();
			this.buttonDivide = new System.Windows.Forms.Button();
			this.buttonMultiply = new System.Windows.Forms.Button();
			this.buttonSubtract = new System.Windows.Forms.Button();
			this.buttonEqual = new System.Windows.Forms.Button();
			this.buttonPercent = new System.Windows.Forms.Button();
			this.buttonReciprocate = new System.Windows.Forms.Button();
			this.buttonSquareRoot = new System.Windows.Forms.Button();
			this.buttonClear = new System.Windows.Forms.Button();
			this.buttonClearEntry = new System.Windows.Forms.Button();
			this.buttonDelete = new System.Windows.Forms.Button();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(16, 178);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(33, 27);
			this.button1.TabIndex = 0;
			this.button1.Text = "1";
			this.button1.UseVisualStyleBackColor = true;
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(54, 178);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(33, 27);
			this.button2.TabIndex = 1;
			this.button2.Text = "2";
			this.button2.UseVisualStyleBackColor = true;
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(93, 178);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(33, 27);
			this.button3.TabIndex = 2;
			this.button3.Text = "3";
			this.button3.UseVisualStyleBackColor = true;
			// 
			// button4
			// 
			this.button4.Location = new System.Drawing.Point(16, 146);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(33, 27);
			this.button4.TabIndex = 3;
			this.button4.Text = "4";
			this.button4.UseVisualStyleBackColor = true;
			// 
			// button5
			// 
			this.button5.Location = new System.Drawing.Point(54, 146);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(33, 27);
			this.button5.TabIndex = 4;
			this.button5.Text = "5";
			this.button5.UseVisualStyleBackColor = true;
			// 
			// button6
			// 
			this.button6.Location = new System.Drawing.Point(93, 146);
			this.button6.Name = "button6";
			this.button6.Size = new System.Drawing.Size(33, 27);
			this.button6.TabIndex = 5;
			this.button6.Text = "6";
			this.button6.UseVisualStyleBackColor = true;
			// 
			// button7
			// 
			this.button7.Location = new System.Drawing.Point(16, 114);
			this.button7.Name = "button7";
			this.button7.Size = new System.Drawing.Size(33, 27);
			this.button7.TabIndex = 6;
			this.button7.Text = "7";
			this.button7.UseVisualStyleBackColor = true;
			this.button7.Click += new System.EventHandler(this.Button7Click);
			// 
			// button8
			// 
			this.button8.Location = new System.Drawing.Point(54, 114);
			this.button8.Name = "button8";
			this.button8.Size = new System.Drawing.Size(33, 27);
			this.button8.TabIndex = 7;
			this.button8.Text = "8";
			this.button8.UseVisualStyleBackColor = true;
			// 
			// button9
			// 
			this.button9.Location = new System.Drawing.Point(93, 114);
			this.button9.Name = "button9";
			this.button9.Size = new System.Drawing.Size(33, 27);
			this.button9.TabIndex = 8;
			this.button9.Text = "9";
			this.button9.UseVisualStyleBackColor = true;
			// 
			// button0
			// 
			this.button0.Location = new System.Drawing.Point(15, 210);
			this.button0.Name = "button0";
			this.button0.Size = new System.Drawing.Size(72, 27);
			this.button0.TabIndex = 9;
			this.button0.Text = "0";
			this.button0.UseVisualStyleBackColor = true;
			// 
			// buttonPoint
			// 
			this.buttonPoint.Location = new System.Drawing.Point(93, 210);
			this.buttonPoint.Name = "buttonPoint";
			this.buttonPoint.Size = new System.Drawing.Size(33, 27);
			this.buttonPoint.TabIndex = 10;
			this.buttonPoint.Text = ".";
			this.buttonPoint.UseVisualStyleBackColor = true;
			// 
			// buttonAdd
			// 
			this.buttonAdd.Location = new System.Drawing.Point(132, 210);
			this.buttonAdd.Name = "buttonAdd";
			this.buttonAdd.Size = new System.Drawing.Size(33, 27);
			this.buttonAdd.TabIndex = 14;
			this.buttonAdd.Text = "+";
			this.buttonAdd.UseVisualStyleBackColor = true;
			// 
			// buttonDivide
			// 
			this.buttonDivide.Location = new System.Drawing.Point(132, 114);
			this.buttonDivide.Name = "buttonDivide";
			this.buttonDivide.Size = new System.Drawing.Size(33, 27);
			this.buttonDivide.TabIndex = 13;
			this.buttonDivide.Text = "/";
			this.buttonDivide.UseVisualStyleBackColor = true;
			// 
			// buttonMultiply
			// 
			this.buttonMultiply.Location = new System.Drawing.Point(132, 146);
			this.buttonMultiply.Name = "buttonMultiply";
			this.buttonMultiply.Size = new System.Drawing.Size(33, 27);
			this.buttonMultiply.TabIndex = 12;
			this.buttonMultiply.Text = "*";
			this.buttonMultiply.UseVisualStyleBackColor = true;
			// 
			// buttonSubtract
			// 
			this.buttonSubtract.Location = new System.Drawing.Point(132, 178);
			this.buttonSubtract.Name = "buttonSubtract";
			this.buttonSubtract.Size = new System.Drawing.Size(33, 27);
			this.buttonSubtract.TabIndex = 11;
			this.buttonSubtract.Text = "-";
			this.buttonSubtract.UseVisualStyleBackColor = true;
			// 
			// buttonEqual
			// 
			this.buttonEqual.Location = new System.Drawing.Point(171, 178);
			this.buttonEqual.Name = "buttonEqual";
			this.buttonEqual.Size = new System.Drawing.Size(33, 59);
			this.buttonEqual.TabIndex = 15;
			this.buttonEqual.Text = "=";
			this.buttonEqual.UseVisualStyleBackColor = true;
			// 
			// buttonPercent
			// 
			this.buttonPercent.Location = new System.Drawing.Point(171, 112);
			this.buttonPercent.Name = "buttonPercent";
			this.buttonPercent.Size = new System.Drawing.Size(33, 27);
			this.buttonPercent.TabIndex = 17;
			this.buttonPercent.Text = "%";
			this.buttonPercent.UseVisualStyleBackColor = true;
			// 
			// buttonReciprocate
			// 
			this.buttonReciprocate.Location = new System.Drawing.Point(171, 145);
			this.buttonReciprocate.Name = "buttonReciprocate";
			this.buttonReciprocate.Size = new System.Drawing.Size(33, 27);
			this.buttonReciprocate.TabIndex = 16;
			this.buttonReciprocate.Text = "1/x";
			this.buttonReciprocate.UseVisualStyleBackColor = true;
			// 
			// buttonSquareRoot
			// 
			this.buttonSquareRoot.Location = new System.Drawing.Point(171, 81);
			this.buttonSquareRoot.Name = "buttonSquareRoot";
			this.buttonSquareRoot.Size = new System.Drawing.Size(33, 27);
			this.buttonSquareRoot.TabIndex = 22;
			this.buttonSquareRoot.Text = "√";
			this.buttonSquareRoot.UseVisualStyleBackColor = true;
			// 
			// buttonClear
			// 
			this.buttonClear.Location = new System.Drawing.Point(133, 81);
			this.buttonClear.Name = "buttonClear";
			this.buttonClear.Size = new System.Drawing.Size(33, 27);
			this.buttonClear.TabIndex = 20;
			this.buttonClear.Text = "C";
			this.buttonClear.UseVisualStyleBackColor = true;
			// 
			// buttonClearEntry
			// 
			this.buttonClearEntry.Location = new System.Drawing.Point(94, 81);
			this.buttonClearEntry.Name = "buttonClearEntry";
			this.buttonClearEntry.Size = new System.Drawing.Size(33, 27);
			this.buttonClearEntry.TabIndex = 19;
			this.buttonClearEntry.Text = "CE";
			this.buttonClearEntry.UseVisualStyleBackColor = true;
			// 
			// buttonDelete
			// 
			this.buttonDelete.Location = new System.Drawing.Point(16, 81);
			this.buttonDelete.Name = "buttonDelete";
			this.buttonDelete.Size = new System.Drawing.Size(71, 27);
			this.buttonDelete.TabIndex = 18;
			this.buttonDelete.Text = "←";
			this.buttonDelete.UseVisualStyleBackColor = true;
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(15, 17);
			this.textBox1.Multiline = true;
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(188, 58);
			this.textBox1.TabIndex = 23;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(220, 253);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.buttonSquareRoot);
			this.Controls.Add(this.buttonClear);
			this.Controls.Add(this.buttonClearEntry);
			this.Controls.Add(this.buttonDelete);
			this.Controls.Add(this.buttonPercent);
			this.Controls.Add(this.buttonReciprocate);
			this.Controls.Add(this.buttonEqual);
			this.Controls.Add(this.buttonAdd);
			this.Controls.Add(this.buttonDivide);
			this.Controls.Add(this.buttonMultiply);
			this.Controls.Add(this.buttonSubtract);
			this.Controls.Add(this.buttonPoint);
			this.Controls.Add(this.button0);
			this.Controls.Add(this.button9);
			this.Controls.Add(this.button8);
			this.Controls.Add(this.button7);
			this.Controls.Add(this.button6);
			this.Controls.Add(this.button5);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Name = "MainForm";
			this.Text = "Calculator";
			this.Load += new System.EventHandler(this.MainFormLoad);
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
