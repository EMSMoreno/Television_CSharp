namespace Televisao.Forms
{
    partial class frmNovaBox
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
            label1 = new Label();
            numericUpDownCanais = new NumericUpDown();
            btnOk = new Button();
            btnCancelar = new Button();
            ((System.ComponentModel.ISupportInitialize)numericUpDownCanais).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(44, 141);
            label1.Name = "label1";
            label1.Size = new Size(105, 15);
            label1.TabIndex = 0;
            label1.Text = "Numero de Canais";
            // 
            // numericUpDownCanais
            // 
            numericUpDownCanais.Location = new Point(200, 139);
            numericUpDownCanais.Name = "numericUpDownCanais";
            numericUpDownCanais.Size = new Size(152, 23);
            numericUpDownCanais.TabIndex = 1;
            // 
            // btnOk
            // 
            btnOk.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnOk.Location = new Point(386, 250);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(93, 56);
            btnOk.TabIndex = 2;
            btnOk.Text = "Ok";
            btnOk.UseVisualStyleBackColor = true;
            btnOk.Click += btnOk_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancelar.Location = new Point(259, 250);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(93, 56);
            btnCancelar.TabIndex = 3;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // frmNovaBox
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(509, 320);
            Controls.Add(btnCancelar);
            Controls.Add(btnOk);
            Controls.Add(numericUpDownCanais);
            Controls.Add(label1);
            Name = "frmNovaBox";
            Text = "Nova Box";
            ((System.ComponentModel.ISupportInitialize)numericUpDownCanais).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private NumericUpDown numericUpDownCanais;
        private Button btnOk;
        private Button btnCancelar;
    }
}