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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.TabMaster = new MaterialSkin.Controls.MaterialTabControl();
            this.homePage = new System.Windows.Forms.TabPage();
            this.setupPage = new System.Windows.Forms.TabPage();
            this.tentControlPage = new System.Windows.Forms.TabPage();
            this.lightControlPage = new System.Windows.Forms.TabPage();
            this.emergencyPage = new System.Windows.Forms.TabPage();
            this.explorePage = new System.Windows.Forms.TabPage();
            this.orderPage = new System.Windows.Forms.TabPage();
            this.eventsPage = new System.Windows.Forms.TabPage();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.energyTodayCard = new MaterialSkin.Controls.MaterialCard();
            this.EcoEffHubCard = new MaterialSkin.Controls.MaterialCard();
            this.energyWeekCard = new MaterialSkin.Controls.MaterialCard();
            this.devicesLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.energyPage = new System.Windows.Forms.TabPage();
            this.TabMaster.SuspendLayout();
            this.energyPage.SuspendLayout();
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
            this.TabMaster.ImageList = this.imageList1;
            this.TabMaster.Location = new System.Drawing.Point(3, 64);
            this.TabMaster.MouseState = MaterialSkin.MouseState.HOVER;
            this.TabMaster.Multiline = true;
            this.TabMaster.Name = "TabMaster";
            this.TabMaster.SelectedIndex = 0;
            this.TabMaster.Size = new System.Drawing.Size(947, 483);
            this.TabMaster.TabIndex = 0;
            // 
            // homePage
            // 
            this.homePage.ImageKey = "icons8-home-26.png";
            this.homePage.Location = new System.Drawing.Point(4, 31);
            this.homePage.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.homePage.Name = "homePage";
            this.homePage.Size = new System.Drawing.Size(939, 448);
            this.homePage.TabIndex = 1;
            this.homePage.Text = "Home";
            this.homePage.UseVisualStyleBackColor = true;
            // 
            // setupPage
            // 
            this.setupPage.ImageKey = "icons8-tools-26.png";
            this.setupPage.Location = new System.Drawing.Point(4, 31);
            this.setupPage.Name = "setupPage";
            this.setupPage.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.setupPage.Size = new System.Drawing.Size(939, 448);
            this.setupPage.TabIndex = 0;
            this.setupPage.Text = "Setup";
            this.setupPage.UseVisualStyleBackColor = true;
            // 
            // tentControlPage
            // 
            this.tentControlPage.ImageKey = "icons8-camping-tent-26.png";
            this.tentControlPage.Location = new System.Drawing.Point(4, 31);
            this.tentControlPage.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tentControlPage.Name = "tentControlPage";
            this.tentControlPage.Size = new System.Drawing.Size(939, 448);
            this.tentControlPage.TabIndex = 2;
            this.tentControlPage.Text = "Tent Control";
            this.tentControlPage.UseVisualStyleBackColor = true;
            // 
            // lightControlPage
            // 
            this.lightControlPage.ImageKey = "icons8-idea-26.png";
            this.lightControlPage.Location = new System.Drawing.Point(4, 31);
            this.lightControlPage.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lightControlPage.Name = "lightControlPage";
            this.lightControlPage.Size = new System.Drawing.Size(939, 448);
            this.lightControlPage.TabIndex = 3;
            this.lightControlPage.Text = "Light Control";
            this.lightControlPage.UseVisualStyleBackColor = true;
            // 
            // emergencyPage
            // 
            this.emergencyPage.ImageKey = "icons8-siren-26.png";
            this.emergencyPage.Location = new System.Drawing.Point(4, 31);
            this.emergencyPage.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.emergencyPage.Name = "emergencyPage";
            this.emergencyPage.Size = new System.Drawing.Size(939, 448);
            this.emergencyPage.TabIndex = 5;
            this.emergencyPage.Text = "Emergency";
            this.emergencyPage.UseVisualStyleBackColor = true;
            // 
            // explorePage
            // 
            this.explorePage.ImageKey = "icons8-compass-26.png";
            this.explorePage.Location = new System.Drawing.Point(4, 31);
            this.explorePage.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.explorePage.Name = "explorePage";
            this.explorePage.Size = new System.Drawing.Size(939, 448);
            this.explorePage.TabIndex = 6;
            this.explorePage.Text = "Explore";
            this.explorePage.UseVisualStyleBackColor = true;
            // 
            // orderPage
            // 
            this.orderPage.ImageKey = "icons8-restaurant-26.png";
            this.orderPage.Location = new System.Drawing.Point(4, 31);
            this.orderPage.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.orderPage.Name = "orderPage";
            this.orderPage.Size = new System.Drawing.Size(939, 448);
            this.orderPage.TabIndex = 7;
            this.orderPage.Text = "Order";
            this.orderPage.UseVisualStyleBackColor = true;
            // 
            // eventsPage
            // 
            this.eventsPage.ImageKey = "icons8-schedule-26.png";
            this.eventsPage.Location = new System.Drawing.Point(4, 31);
            this.eventsPage.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.eventsPage.Name = "eventsPage";
            this.eventsPage.Size = new System.Drawing.Size(939, 448);
            this.eventsPage.TabIndex = 8;
            this.eventsPage.Text = "Events";
            this.eventsPage.UseVisualStyleBackColor = true;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "icons8-schedule-26.png");
            this.imageList1.Images.SetKeyName(1, "icons8-restaurant-26.png");
            this.imageList1.Images.SetKeyName(2, "icons8-compass-26.png");
            this.imageList1.Images.SetKeyName(3, "icons8-siren-26.png");
            this.imageList1.Images.SetKeyName(4, "icons8-leaf-26.png");
            this.imageList1.Images.SetKeyName(5, "icons8-tools-26.png");
            this.imageList1.Images.SetKeyName(6, "icons8-idea-26.png");
            this.imageList1.Images.SetKeyName(7, "icons8-camping-tent-26.png");
            this.imageList1.Images.SetKeyName(8, "icons8-home-26.png");
            // 
            // energyTodayCard
            // 
            this.energyTodayCard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.energyTodayCard.Depth = 0;
            this.energyTodayCard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.energyTodayCard.Location = new System.Drawing.Point(32, 39);
            this.energyTodayCard.Margin = new System.Windows.Forms.Padding(14);
            this.energyTodayCard.MouseState = MaterialSkin.MouseState.HOVER;
            this.energyTodayCard.Name = "energyTodayCard";
            this.energyTodayCard.Padding = new System.Windows.Forms.Padding(14);
            this.energyTodayCard.Size = new System.Drawing.Size(288, 161);
            this.energyTodayCard.TabIndex = 0;
            // 
            // EcoEffHubCard
            // 
            this.EcoEffHubCard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.EcoEffHubCard.Depth = 0;
            this.EcoEffHubCard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.EcoEffHubCard.Location = new System.Drawing.Point(668, 14);
            this.EcoEffHubCard.Margin = new System.Windows.Forms.Padding(14);
            this.EcoEffHubCard.MouseState = MaterialSkin.MouseState.HOVER;
            this.EcoEffHubCard.Name = "EcoEffHubCard";
            this.EcoEffHubCard.Padding = new System.Windows.Forms.Padding(14);
            this.EcoEffHubCard.Size = new System.Drawing.Size(204, 455);
            this.EcoEffHubCard.TabIndex = 1;
            // 
            // energyWeekCard
            // 
            this.energyWeekCard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.energyWeekCard.Depth = 0;
            this.energyWeekCard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.energyWeekCard.Location = new System.Drawing.Point(352, 39);
            this.energyWeekCard.Margin = new System.Windows.Forms.Padding(14);
            this.energyWeekCard.MouseState = MaterialSkin.MouseState.HOVER;
            this.energyWeekCard.Name = "energyWeekCard";
            this.energyWeekCard.Padding = new System.Windows.Forms.Padding(14);
            this.energyWeekCard.Size = new System.Drawing.Size(288, 161);
            this.energyWeekCard.TabIndex = 2;
            // 
            // devicesLabel1
            // 
            this.devicesLabel1.Depth = 0;
            this.devicesLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.devicesLabel1.Location = new System.Drawing.Point(29, 236);
            this.devicesLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.devicesLabel1.Name = "devicesLabel1";
            this.devicesLabel1.Size = new System.Drawing.Size(184, 44);
            this.devicesLabel1.TabIndex = 3;
            this.devicesLabel1.Text = "Devices";
            // 
            // energyPage
            // 
            this.energyPage.Controls.Add(this.devicesLabel1);
            this.energyPage.Controls.Add(this.energyWeekCard);
            this.energyPage.Controls.Add(this.EcoEffHubCard);
            this.energyPage.Controls.Add(this.energyTodayCard);
            this.energyPage.ImageKey = "icons8-leaf-26.png";
            this.energyPage.Location = new System.Drawing.Point(4, 31);
            this.energyPage.Margin = new System.Windows.Forms.Padding(2);
            this.energyPage.Name = "energyPage";
            this.energyPage.Size = new System.Drawing.Size(939, 448);
            this.energyPage.TabIndex = 4;
            this.energyPage.Text = "Energy";
            this.energyPage.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(953, 550);
            this.Controls.Add(this.TabMaster);
            this.DrawerShowIconsWhenHidden = true;
            this.DrawerTabControl = this.TabMaster;
            this.Name = "Form1";
            this.Text = "TrailMate";
            this.TabMaster.ResumeLayout(false);
            this.energyPage.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl TabMaster;
        private System.Windows.Forms.TabPage setupPage;
        private System.Windows.Forms.TabPage homePage;
        private System.Windows.Forms.TabPage tentControlPage;
        private System.Windows.Forms.TabPage lightControlPage;
        private System.Windows.Forms.TabPage emergencyPage;
        private System.Windows.Forms.TabPage explorePage;
        private System.Windows.Forms.TabPage orderPage;
        private System.Windows.Forms.TabPage eventsPage;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.TabPage energyPage;
        private MaterialSkin.Controls.MaterialLabel devicesLabel1;
        private MaterialSkin.Controls.MaterialCard energyWeekCard;
        private MaterialSkin.Controls.MaterialCard EcoEffHubCard;
        private MaterialSkin.Controls.MaterialCard energyTodayCard;
    }
}

