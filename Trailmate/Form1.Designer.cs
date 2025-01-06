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
            this.homePage = new System.Windows.Forms.TabPage();
            this.tentControlPage = new System.Windows.Forms.TabPage();
            this.lightControlPage = new System.Windows.Forms.TabPage();
            this.energyPage = new System.Windows.Forms.TabPage();
            this.emergencyPage = new System.Windows.Forms.TabPage();
            this.explorePage = new System.Windows.Forms.TabPage();
            this.orderPage = new System.Windows.Forms.TabPage();
            this.eventsPage = new System.Windows.Forms.TabPage();
            this.TabMaster.SuspendLayout();
            this.SuspendLayout();
            // 
            // TabMaster
            // 
            this.TabMaster.Controls.Add(this.homePage);
            this.TabMaster.Controls.Add(this.setupPage);
            this.TabMaster.Controls.Add(this.tentControlPage);
            this.TabMaster.Controls.Add(this.lightControlPage);
            this.TabMaster.Controls.Add(this.energyPage);
            this.TabMaster.Controls.Add(this.emergencyPage);
            this.TabMaster.Controls.Add(this.explorePage);
            this.TabMaster.Controls.Add(this.orderPage);
            this.TabMaster.Controls.Add(this.eventsPage);
            this.TabMaster.Depth = 0;
            this.TabMaster.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabMaster.Location = new System.Drawing.Point(4, 79);
            this.TabMaster.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TabMaster.MouseState = MaterialSkin.MouseState.HOVER;
            this.TabMaster.Multiline = true;
            this.TabMaster.Name = "TabMaster";
            this.TabMaster.SelectedIndex = 0;
            this.TabMaster.Size = new System.Drawing.Size(1059, 471);
            this.TabMaster.TabIndex = 0;
            // 
            // setupPage
            // 
            this.setupPage.Location = new System.Drawing.Point(4, 25);
            this.setupPage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.setupPage.Name = "setupPage";
            this.setupPage.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.setupPage.Size = new System.Drawing.Size(1051, 442);
            this.setupPage.TabIndex = 0;
            this.setupPage.Text = "Setup";
            this.setupPage.UseVisualStyleBackColor = true;
            // 
            // homePage
            // 
            this.homePage.Location = new System.Drawing.Point(4, 25);
            this.homePage.Name = "homePage";
            this.homePage.Size = new System.Drawing.Size(1051, 442);
            this.homePage.TabIndex = 1;
            this.homePage.Text = "Home";
            this.homePage.UseVisualStyleBackColor = true;
            // 
            // tentControlPage
            // 
            this.tentControlPage.Location = new System.Drawing.Point(4, 25);
            this.tentControlPage.Name = "tentControlPage";
            this.tentControlPage.Size = new System.Drawing.Size(1051, 442);
            this.tentControlPage.TabIndex = 2;
            this.tentControlPage.Text = "Tent Control";
            this.tentControlPage.UseVisualStyleBackColor = true;
            // 
            // lightControlPage
            // 
            this.lightControlPage.Location = new System.Drawing.Point(4, 25);
            this.lightControlPage.Name = "lightControlPage";
            this.lightControlPage.Size = new System.Drawing.Size(1051, 442);
            this.lightControlPage.TabIndex = 3;
            this.lightControlPage.Text = "Light Control";
            this.lightControlPage.UseVisualStyleBackColor = true;
            // 
            // energyPage
            // 
            this.energyPage.Location = new System.Drawing.Point(4, 25);
            this.energyPage.Name = "energyPage";
            this.energyPage.Size = new System.Drawing.Size(1051, 442);
            this.energyPage.TabIndex = 4;
            this.energyPage.Text = "Energy";
            this.energyPage.UseVisualStyleBackColor = true;
            // 
            // emergencyPage
            // 
            this.emergencyPage.Location = new System.Drawing.Point(4, 25);
            this.emergencyPage.Name = "emergencyPage";
            this.emergencyPage.Size = new System.Drawing.Size(1051, 442);
            this.emergencyPage.TabIndex = 5;
            this.emergencyPage.Text = "Emergency";
            this.emergencyPage.UseVisualStyleBackColor = true;
            // 
            // explorePage
            // 
            this.explorePage.Location = new System.Drawing.Point(4, 25);
            this.explorePage.Name = "explorePage";
            this.explorePage.Size = new System.Drawing.Size(1051, 442);
            this.explorePage.TabIndex = 6;
            this.explorePage.Text = "Explore";
            this.explorePage.UseVisualStyleBackColor = true;
            // 
            // orderPage
            // 
            this.orderPage.Location = new System.Drawing.Point(4, 25);
            this.orderPage.Name = "orderPage";
            this.orderPage.Size = new System.Drawing.Size(1051, 442);
            this.orderPage.TabIndex = 7;
            this.orderPage.Text = "Order";
            this.orderPage.UseVisualStyleBackColor = true;
            // 
            // eventsPage
            // 
            this.eventsPage.Location = new System.Drawing.Point(4, 25);
            this.eventsPage.Name = "eventsPage";
            this.eventsPage.Size = new System.Drawing.Size(1051, 442);
            this.eventsPage.TabIndex = 8;
            this.eventsPage.Text = "Events";
            this.eventsPage.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.TabMaster);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(4, 79, 4, 4);
            this.Text = "TrailMate";
            this.TabMaster.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl TabMaster;
        private System.Windows.Forms.TabPage setupPage;
        private System.Windows.Forms.TabPage homePage;
        private System.Windows.Forms.TabPage tentControlPage;
        private System.Windows.Forms.TabPage lightControlPage;
        private System.Windows.Forms.TabPage energyPage;
        private System.Windows.Forms.TabPage emergencyPage;
        private System.Windows.Forms.TabPage explorePage;
        private System.Windows.Forms.TabPage orderPage;
        private System.Windows.Forms.TabPage eventsPage;
    }
}

