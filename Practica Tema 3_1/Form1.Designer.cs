namespace Practica_Tema_3_1
{
	partial class Form1
	{
		/// <summary>
		/// Variable del diseñador necesaria.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Limpiar los recursos que se estén usando.
		/// </summary>
		/// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Código generado por el Diseñador de Windows Forms

		/// <summary>
		/// Método necesario para admitir el Diseñador. No se puede modificar
		/// el contenido de este método con el editor de código.
		/// </summary>
		private void InitializeComponent()
		{
			this.label1 = new System.Windows.Forms.Label();
			this.txtTelegrama = new System.Windows.Forms.TextBox();
			this.bCalcular = new System.Windows.Forms.Button();
			this.cbUrgente = new System.Windows.Forms.CheckBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txtPrecio = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(92, 47);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(39, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Texto";

			// 
			// txtTelegrama
			// 
			this.txtTelegrama.Location = new System.Drawing.Point(95, 63);
			this.txtTelegrama.Multiline = true;
			this.txtTelegrama.Name = "txtTelegrama";
			this.txtTelegrama.Size = new System.Drawing.Size(461, 253);
			this.txtTelegrama.TabIndex = 1;
			// 
			// bCalcular
			// 
			this.bCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.bCalcular.Location = new System.Drawing.Point(498, 375);
			this.bCalcular.Name = "bCalcular";
			this.bCalcular.Size = new System.Drawing.Size(75, 23);
			this.bCalcular.TabIndex = 2;
			this.bCalcular.Text = "Calcular";
			this.bCalcular.UseVisualStyleBackColor = true;
			this.bCalcular.Click += new System.EventHandler(this.button1_Click);
			// 
			// cbUrgente
			// 
			this.cbUrgente.AutoSize = true;
			this.cbUrgente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbUrgente.Location = new System.Drawing.Point(95, 363);
			this.cbUrgente.Name = "cbUrgente";
			this.cbUrgente.Size = new System.Drawing.Size(78, 17);
			this.cbUrgente.TabIndex = 4;
			this.cbUrgente.Text = "Urgente?";
			this.cbUrgente.UseVisualStyleBackColor = true;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(95, 410);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(43, 13);
			this.label2.TabIndex = 5;
			this.label2.Text = "Coste:";
			// 
			// txtPrecio
			// 
			this.txtPrecio.Location = new System.Drawing.Point(144, 407);
			this.txtPrecio.Name = "txtPrecio";
			this.txtPrecio.Size = new System.Drawing.Size(100, 20);
			this.txtPrecio.TabIndex = 6;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.txtPrecio);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.cbUrgente);
			this.Controls.Add(this.bCalcular);
			this.Controls.Add(this.txtTelegrama);
			this.Controls.Add(this.label1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtTelegrama;
		private System.Windows.Forms.Button bCalcular;
		private System.Windows.Forms.CheckBox cbUrgente;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtPrecio;
	}
}

