namespace AppRever
{
    partial class TeleForm
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
            if (disposing && (components != null))
            {
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
            lbl = new Label();
            txt_valor1 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txt_valor2 = new TextBox();
            txt_valor3 = new TextBox();
            Btn_calculo = new Button();
            lbl_resultado = new Label();
            Btn_limpar = new Button();
            lblresultado = new Label();
            SuspendLayout();
            // 
            // lbl
            // 
            lbl.AutoSize = true;
            lbl.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            lbl.Location = new Point(94, 32);
            lbl.Name = "lbl";
            lbl.Size = new Size(314, 37);
            lbl.TabIndex = 0;
            lbl.Text = "Sistema de maior Valor";
            // 
            // txt_valor1
            // 
            txt_valor1.Location = new Point(243, 121);
            txt_valor1.Name = "txt_valor1";
            txt_valor1.Size = new Size(232, 23);
            txt_valor1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(38, 112);
            label1.Name = "label1";
            label1.Size = new Size(187, 32);
            label1.TabIndex = 2;
            label1.Text = "Primeiro Valor:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(36, 158);
            label2.Name = "label2";
            label2.Size = new Size(189, 32);
            label2.TabIndex = 3;
            label2.Text = "Segundo Valor:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(38, 205);
            label3.Name = "label3";
            label3.Size = new Size(180, 32);
            label3.TabIndex = 4;
            label3.Text = "Terceiro Valor:";
            // 
            // txt_valor2
            // 
            txt_valor2.Location = new Point(243, 167);
            txt_valor2.Name = "txt_valor2";
            txt_valor2.Size = new Size(232, 23);
            txt_valor2.TabIndex = 5;
            // 
            // txt_valor3
            // 
            txt_valor3.Location = new Point(243, 214);
            txt_valor3.Name = "txt_valor3";
            txt_valor3.Size = new Size(232, 23);
            txt_valor3.TabIndex = 6;
            // 
            // Btn_calculo
            // 
            Btn_calculo.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            Btn_calculo.Location = new Point(36, 280);
            Btn_calculo.Name = "Btn_calculo";
            Btn_calculo.Size = new Size(439, 38);
            Btn_calculo.TabIndex = 7;
            Btn_calculo.Text = "Calcular";
            Btn_calculo.UseVisualStyleBackColor = true;
            Btn_calculo.Click += Btn_calculo_Click_1;
            // 
            // lbl_resultado
            // 
            lbl_resultado.Location = new Point(0, 0);
            lbl_resultado.Name = "lbl_resultado";
            lbl_resultado.Size = new Size(100, 23);
            lbl_resultado.TabIndex = 0;
            // 
            // Btn_limpar
            // 
            Btn_limpar.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            Btn_limpar.Location = new Point(36, 333);
            Btn_limpar.Name = "Btn_limpar";
            Btn_limpar.Size = new Size(439, 38);
            Btn_limpar.TabIndex = 9;
            Btn_limpar.Text = "Limpar";
            Btn_limpar.UseVisualStyleBackColor = true;
            Btn_limpar.Click += Btn_limpar_Click;
            // 
            // lblresultado
            // 
            lblresultado.BackColor = SystemColors.ActiveCaption;
            lblresultado.ForeColor = SystemColors.ButtonFace;
            lblresultado.Location = new Point(36, 385);
            lblresultado.Name = "lblresultado";
            lblresultado.Size = new Size(439, 157);
            lblresultado.TabIndex = 10;
            // 
            // TeleForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(518, 563);
            Controls.Add(lblresultado);
            Controls.Add(Btn_limpar);
            Controls.Add(Btn_calculo);
            Controls.Add(txt_valor3);
            Controls.Add(txt_valor2);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txt_valor1);
            Controls.Add(lbl);
            MaximizeBox = false;
            Name = "TeleForm";
            ShowIcon = false;
            Text = "Sistema de Valor";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl;
        private TextBox txt_valor1;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txt_valor2;
        private TextBox txt_valor3;
        private Button Btn_calculo;
        private Label lbl_resultado;
        private Button Btn_limpar;
        private Label lblresultado;
    }
}