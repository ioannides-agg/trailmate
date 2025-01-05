namespace Trailmate
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
            this.TabMaster = new MaterialSkin.Controls.MaterialTabControl();
            this.setupPage = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.TabMaster.SuspendLayout();
            this.SuspendLayout();
            // 
            // TabMaster
            // 
            this.TabMaster.Controls.Add(this.setupPage);
            this.TabMaster.Controls.Add(this.tabPage2);
            this.TabMaster.Depth = 0;
            this.TabMaster.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabMaster.Location = new System.Drawing.Point(3, 64);
            this.TabMaster.MouseState = MaterialSkin.MouseState.HOVER;
            this.TabMaster.Multiline = true;
            this.TabMaster.Name = "TabMaster";
            this.TabMaster.SelectedIndex = 0;
            this.TabMaster.Size = new System.Drawing.Size(794, 383);
            this.TabMaster.TabIndex = 0;
            // 
            // setupPage
            // 
            this.setupPage.Location = new System.Drawing.Point(4, 22);
            this.setupPage.Name = "setupPage";
            this.setupPage.Padding = new System.Windows.Forms.Padding(3);
            this.setupPage.Size = new System.Drawing.Size(786, 357);
            this.setupPage.TabIndex = 0;
            this.setupPage.Text = "Setup";
            this.setupPage.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(786, 357);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TabMaster);
            this.Name = "Form1";
            this.Text = "TrailMate";
            this.TabMaster.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl TabMaster;
        private System.Windows.Forms.TabPage setupPage;
        private System.Windows.Forms.TabPage tabPage2;
    }
}

