/*
 * Created by SharpDevelop.
 * User: Mateusz Ratajczak
 * Date: 05.01.2018
 * Time: 22:08
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Analizator_skladniowy
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
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
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// textBox1
			// 
			this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.textBox1.Location = new System.Drawing.Point(150, 40);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(354, 34);
			this.textBox1.TabIndex = 0;
			this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(150, 10);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(354, 23);
			this.label1.TabIndex = 1;
			this.label1.Text = "Wpisz wyrażenie";
			this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// textBox2
			// 
			this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.textBox2.Location = new System.Drawing.Point(150, 130);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(354, 34);
			this.textBox2.TabIndex = 2;
			this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(150, 170);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(354, 41);
			this.button1.TabIndex = 3;
			this.button1.Text = "Sprawdź";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(663, 228);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.textBox1);
			this.Name = "MainForm";
			this.Text = "Analizator_skladniowy";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textBox1;
	}
}
