namespace Televisao.Forms
{
    partial class frmPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            btnOnOff = new Button();
            lblInfo = new Label();
            groupBoxCanais = new GroupBox();
            lblCanal = new Label();
            btnAumentaCanal = new Button();
            btnDiminuiCanal = new Button();
            groupBoxVolume = new GroupBox();
            progressBarVolume = new ProgressBar();
            label1 = new Label();
            btnAumentaVolume = new Button();
            btnDiminuiVolume = new Button();
            menuStrip1 = new MenuStrip();
            toolStripMenuItem1 = new ToolStripMenuItem();
            groupBoxCanais.SuspendLayout();
            groupBoxVolume.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // btnOnOff
            // 
            resources.ApplyResources(btnOnOff, "btnOnOff");
            btnOnOff.Name = "btnOnOff";
            btnOnOff.UseVisualStyleBackColor = true;
            btnOnOff.Click += btnOnOff_Click;
            // 
            // lblInfo
            // 
            resources.ApplyResources(lblInfo, "lblInfo");
            lblInfo.Name = "lblInfo";
            // 
            // groupBoxCanais
            // 
            groupBoxCanais.Controls.Add(lblCanal);
            groupBoxCanais.Controls.Add(btnAumentaCanal);
            groupBoxCanais.Controls.Add(btnDiminuiCanal);
            resources.ApplyResources(groupBoxCanais, "groupBoxCanais");
            groupBoxCanais.Name = "groupBoxCanais";
            groupBoxCanais.TabStop = false;
            // 
            // lblCanal
            // 
            resources.ApplyResources(lblCanal, "lblCanal");
            lblCanal.Name = "lblCanal";
            // 
            // btnAumentaCanal
            // 
            resources.ApplyResources(btnAumentaCanal, "btnAumentaCanal");
            btnAumentaCanal.Name = "btnAumentaCanal";
            btnAumentaCanal.UseVisualStyleBackColor = true;
            btnAumentaCanal.Click += btnAumentaCanal_Click;
            // 
            // btnDiminuiCanal
            // 
            resources.ApplyResources(btnDiminuiCanal, "btnDiminuiCanal");
            btnDiminuiCanal.Name = "btnDiminuiCanal";
            btnDiminuiCanal.UseVisualStyleBackColor = true;
            btnDiminuiCanal.Click += btnDiminuiCanal_Click;
            // 
            // groupBoxVolume
            // 
            groupBoxVolume.Controls.Add(progressBarVolume);
            groupBoxVolume.Controls.Add(label1);
            groupBoxVolume.Controls.Add(btnAumentaVolume);
            groupBoxVolume.Controls.Add(btnDiminuiVolume);
            resources.ApplyResources(groupBoxVolume, "groupBoxVolume");
            groupBoxVolume.Name = "groupBoxVolume";
            groupBoxVolume.TabStop = false;
            // 
            // progressBarVolume
            // 
            resources.ApplyResources(progressBarVolume, "progressBarVolume");
            progressBarVolume.Name = "progressBarVolume";
            // 
            // label1
            // 
            resources.ApplyResources(label1, "label1");
            label1.Name = "label1";
            // 
            // btnAumentaVolume
            // 
            resources.ApplyResources(btnAumentaVolume, "btnAumentaVolume");
            btnAumentaVolume.Name = "btnAumentaVolume";
            btnAumentaVolume.UseVisualStyleBackColor = true;
            btnAumentaVolume.Click += btnAumentaVolume_Click;
            // 
            // btnDiminuiVolume
            // 
            resources.ApplyResources(btnDiminuiVolume, "btnDiminuiVolume");
            btnDiminuiVolume.Name = "btnDiminuiVolume";
            btnDiminuiVolume.UseVisualStyleBackColor = true;
            btnDiminuiVolume.Click += btnDiminuiVolume_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { toolStripMenuItem1 });
            resources.ApplyResources(menuStrip1, "menuStrip1");
            menuStrip1.Name = "menuStrip1";
            menuStrip1.ItemClicked += menuStrip1_ItemClicked;
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            resources.ApplyResources(toolStripMenuItem1, "toolStripMenuItem1");
            // 
            // frmPrincipal
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(groupBoxVolume);
            Controls.Add(groupBoxCanais);
            Controls.Add(lblInfo);
            Controls.Add(btnOnOff);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "frmPrincipal";
            groupBoxCanais.ResumeLayout(false);
            groupBoxCanais.PerformLayout();
            groupBoxVolume.ResumeLayout(false);
            groupBoxVolume.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnOnOff;
        private Label lblInfo;
        private GroupBox groupBoxCanais;
        private Button btnAumentaCanal;
        private Button btnDiminuiCanal;
        private Label lblCanal;
        private GroupBox groupBoxVolume;
        private ProgressBar progressBarVolume;
        private Label label1;
        private Button btnAumentaVolume;
        private Button btnDiminuiVolume;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem toolStripMenuItem1;
    }
}
