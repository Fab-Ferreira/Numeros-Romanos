/*
 * Created by SharpDevelop.
 * User: fabri
 * Date: 11/05/2022
 * Time: 17:35
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace numeros_romanos
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Button convertRoman;
		private System.Windows.Forms.TextBox textDecToRom;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label labelDecToRom;
		
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
			this.convertRoman = new System.Windows.Forms.Button();
			this.textDecToRom = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.labelDecToRom = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// convertRoman
			// 
			this.convertRoman.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
			this.convertRoman.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.convertRoman.ForeColor = System.Drawing.Color.White;
			this.convertRoman.Location = new System.Drawing.Point(167, 153);
			this.convertRoman.Name = "convertRoman";
			this.convertRoman.Size = new System.Drawing.Size(166, 67);
			this.convertRoman.TabIndex = 0;
			this.convertRoman.Text = "Converter para Romano";
			this.convertRoman.UseVisualStyleBackColor = false;
			this.convertRoman.Click += new System.EventHandler(this.ConvertRomanClick);
			// 
			// textDecToRom
			// 
			this.textDecToRom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
			this.textDecToRom.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textDecToRom.ForeColor = System.Drawing.Color.White;
			this.textDecToRom.Location = new System.Drawing.Point(275, 79);
			this.textDecToRom.Name = "textDecToRom";
			this.textDecToRom.Size = new System.Drawing.Size(151, 30);
			this.textDecToRom.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(22, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(472, 40);
			this.label1.TabIndex = 2;
			this.label1.Text = "CONVERSOR DE NÚMEROS ROMANOS";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.White;
			this.label2.Location = new System.Drawing.Point(22, 55);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(223, 79);
			this.label2.TabIndex = 3;
			this.label2.Text = "Número (em algarismos decimais):";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.White;
			this.label3.Location = new System.Drawing.Point(22, 258);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(247, 56);
			this.label3.TabIndex = 3;
			this.label3.Text = "Número (em algarismos romanos):";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// labelDecToRom
			// 
			this.labelDecToRom.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelDecToRom.ForeColor = System.Drawing.Color.White;
			this.labelDecToRom.Location = new System.Drawing.Point(275, 258);
			this.labelDecToRom.Name = "labelDecToRom";
			this.labelDecToRom.Size = new System.Drawing.Size(219, 56);
			this.labelDecToRom.TabIndex = 4;
			this.labelDecToRom.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
			this.ClientSize = new System.Drawing.Size(506, 345);
			this.Controls.Add(this.labelDecToRom);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.textDecToRom);
			this.Controls.Add(this.convertRoman);
			this.Name = "MainForm";
			this.Text = "numeros romanos";
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
