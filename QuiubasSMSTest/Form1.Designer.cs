﻿namespace QuiubasSMSTest
{
  partial class Form1
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null)) {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.txtDestino = new System.Windows.Forms.TextBox();
      this.txtResponse = new System.Windows.Forms.TextBox();
      this.label1 = new System.Windows.Forms.Label();
      this.btnEnviar = new System.Windows.Forms.Button();
      this.txtMensaje = new System.Windows.Forms.TextBox();
      this.label2 = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // txtDestino
      // 
      this.txtDestino.Location = new System.Drawing.Point(102, 12);
      this.txtDestino.Name = "txtDestino";
      this.txtDestino.Size = new System.Drawing.Size(158, 20);
      this.txtDestino.TabIndex = 0;
      this.txtDestino.Text = "+5218113727364";
      // 
      // txtResponse
      // 
      this.txtResponse.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.txtResponse.Location = new System.Drawing.Point(15, 83);
      this.txtResponse.Multiline = true;
      this.txtResponse.Name = "txtResponse";
      this.txtResponse.ScrollBars = System.Windows.Forms.ScrollBars.Both;
      this.txtResponse.Size = new System.Drawing.Size(471, 299);
      this.txtResponse.TabIndex = 1;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(12, 15);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(84, 13);
      this.label1.TabIndex = 2;
      this.label1.Text = "Numero destino:";
      // 
      // btnEnviar
      // 
      this.btnEnviar.Location = new System.Drawing.Point(411, 10);
      this.btnEnviar.Name = "btnEnviar";
      this.btnEnviar.Size = new System.Drawing.Size(75, 23);
      this.btnEnviar.TabIndex = 3;
      this.btnEnviar.Text = "Enviar!!!";
      this.btnEnviar.UseVisualStyleBackColor = true;
      this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
      // 
      // txtMensaje
      // 
      this.txtMensaje.Location = new System.Drawing.Point(102, 38);
      this.txtMensaje.MaxLength = 160;
      this.txtMensaje.Multiline = true;
      this.txtMensaje.Name = "txtMensaje";
      this.txtMensaje.ScrollBars = System.Windows.Forms.ScrollBars.Both;
      this.txtMensaje.Size = new System.Drawing.Size(302, 39);
      this.txtMensaje.TabIndex = 4;
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(12, 41);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(50, 13);
      this.label2.TabIndex = 5;
      this.label2.Text = "Mensaje:";
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(498, 394);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.txtMensaje);
      this.Controls.Add(this.btnEnviar);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.txtResponse);
      this.Controls.Add(this.txtDestino);
      this.Name = "Form1";
      this.Text = "Form1";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.TextBox txtDestino;
    private System.Windows.Forms.TextBox txtResponse;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Button btnEnviar;
    private System.Windows.Forms.TextBox txtMensaje;
    private System.Windows.Forms.Label label2;
  }
}

