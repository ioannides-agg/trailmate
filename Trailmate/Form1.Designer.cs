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
            this.energyPage = new System.Windows.Forms.TabPage();
            this.devicesLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.energyWeekCard = new MaterialSkin.Controls.MaterialCard();
            this.EcoEffHubCard = new MaterialSkin.Controls.MaterialCard();
            this.energyTodayCard = new MaterialSkin.Controls.MaterialCard();
            this.emergencyPage = new System.Windows.Forms.TabPage();
            this.explorePage = new System.Windows.Forms.TabPage();
            this.orderPage = new System.Windows.Forms.TabPage();
            this.eventsPage = new System.Windows.Forms.TabPage();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.groundInfoCard = new MaterialSkin.Controls.MaterialCard();
            this.groundInfoMainLabel = new MaterialSkin.Controls.MaterialLabel();
            this.groundInfoFlatness = new MaterialSkin.Controls.MaterialLabel();
            this.groundInfoAltitude = new MaterialSkin.Controls.MaterialLabel();
            this.groundInfoTexture = new MaterialSkin.Controls.MaterialLabel();
            this.groundInfoDensity = new MaterialSkin.Controls.MaterialLabel();
            this.groundInfoHumidity = new MaterialSkin.Controls.MaterialLabel();
            this.setHumidity = new MaterialSkin.Controls.MaterialLabel();
            this.setDensity = new MaterialSkin.Controls.MaterialLabel();
            this.setTexture = new MaterialSkin.Controls.MaterialLabel();
            this.setAltitude = new MaterialSkin.Controls.MaterialLabel();
            this.setFlatness = new MaterialSkin.Controls.MaterialLabel();
            this.finalSetupCard = new MaterialSkin.Controls.MaterialCard();
            this.groundInformationContinueBtn = new MaterialSkin.Controls.MaterialButton();
            this.TabMaster.SuspendLayout();
            this.setupPage.SuspendLayout();
            this.energyPage.SuspendLayout();
            this.groundInfoCard.SuspendLayout();
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
            this.homePage.Margin = new System.Windows.Forms.Padding(2);
            this.homePage.Name = "homePage";
            this.homePage.Size = new System.Drawing.Size(939, 448);
            this.homePage.TabIndex = 1;
            this.homePage.Text = "Home";
            this.homePage.UseVisualStyleBackColor = true;
            // 
            // setupPage
            // 
            this.setupPage.Controls.Add(this.groundInfoCard);
            this.setupPage.Controls.Add(this.finalSetupCard);
            this.setupPage.ImageKey = "icons8-tools-26.png";
            this.setupPage.Location = new System.Drawing.Point(4, 31);
            this.setupPage.Name = "setupPage";
            this.setupPage.Padding = new System.Windows.Forms.Padding(3);
            this.setupPage.Size = new System.Drawing.Size(939, 448);
            this.setupPage.TabIndex = 0;
            this.setupPage.Text = "Setup";
            this.setupPage.UseVisualStyleBackColor = true;
            // 
            // tentControlPage
            // 
            this.tentControlPage.ImageKey = "icons8-camping-tent-26.png";
            this.tentControlPage.Location = new System.Drawing.Point(4, 31);
            this.tentControlPage.Margin = new System.Windows.Forms.Padding(2);
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
            this.lightControlPage.Margin = new System.Windows.Forms.Padding(2);
            this.lightControlPage.Name = "lightControlPage";
            this.lightControlPage.Size = new System.Drawing.Size(939, 448);
            this.lightControlPage.TabIndex = 3;
            this.lightControlPage.Text = "Light Control";
            this.lightControlPage.UseVisualStyleBackColor = true;
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
            // devicesLabel1
            // 
            this.devicesLabel1.Depth = 0;
            this.devicesLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.devicesLabel1.Location = new System.Drawing.Point(29, 236);
            this.devicesLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.devicesLabel1.Name = "devicesLabel1";
            this.devicesLabel1.Size = new System.Drawing.Size(184, 44);
            this.devicesLabel1.TabIndex = 3;
            this.devicesLabel1.Text = "Devices";
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
            // emergencyPage
            // 
            this.emergencyPage.ImageKey = "icons8-siren-26.png";
            this.emergencyPage.Location = new System.Drawing.Point(4, 31);
            this.emergencyPage.Margin = new System.Windows.Forms.Padding(2);
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
            this.explorePage.Margin = new System.Windows.Forms.Padding(2);
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
            this.orderPage.Margin = new System.Windows.Forms.Padding(2);
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
            this.eventsPage.Margin = new System.Windows.Forms.Padding(2);
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
            // groundInfoCard
            // 
            this.groundInfoCard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.groundInfoCard.Controls.Add(this.groundInformationContinueBtn);
            this.groundInfoCard.Controls.Add(this.setHumidity);
            this.groundInfoCard.Controls.Add(this.setDensity);
            this.groundInfoCard.Controls.Add(this.setTexture);
            this.groundInfoCard.Controls.Add(this.setAltitude);
            this.groundInfoCard.Controls.Add(this.setFlatness);
            this.groundInfoCard.Controls.Add(this.groundInfoHumidity);
            this.groundInfoCard.Controls.Add(this.groundInfoDensity);
            this.groundInfoCard.Controls.Add(this.groundInfoTexture);
            this.groundInfoCard.Controls.Add(this.groundInfoAltitude);
            this.groundInfoCard.Controls.Add(this.groundInfoFlatness);
            this.groundInfoCard.Controls.Add(this.groundInfoMainLabel);
            this.groundInfoCard.Depth = 0;
            this.groundInfoCard.Dock = System.Windows.Forms.DockStyle.Right;
            this.groundInfoCard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.groundInfoCard.Location = new System.Drawing.Point(671, 3);
            this.groundInfoCard.Margin = new System.Windows.Forms.Padding(14);
            this.groundInfoCard.MouseState = MaterialSkin.MouseState.HOVER;
            this.groundInfoCard.Name = "groundInfoCard";
            this.groundInfoCard.Padding = new System.Windows.Forms.Padding(14);
            this.groundInfoCard.Size = new System.Drawing.Size(265, 442);
            this.groundInfoCard.TabIndex = 0;
            this.groundInfoCard.Visible = false;
            // 
            // groundInfoMainLabel
            // 
            this.groundInfoMainLabel.AutoSize = true;
            this.groundInfoMainLabel.Depth = 0;
            this.groundInfoMainLabel.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.groundInfoMainLabel.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            this.groundInfoMainLabel.Location = new System.Drawing.Point(17, 14);
            this.groundInfoMainLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.groundInfoMainLabel.Name = "groundInfoMainLabel";
            this.groundInfoMainLabel.Size = new System.Drawing.Size(210, 29);
            this.groundInfoMainLabel.TabIndex = 0;
            this.groundInfoMainLabel.Text = "Ground Information";
            // 
            // groundInfoFlatness
            // 
            this.groundInfoFlatness.AutoSize = true;
            this.groundInfoFlatness.Depth = 0;
            this.groundInfoFlatness.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.groundInfoFlatness.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.groundInfoFlatness.Location = new System.Drawing.Point(32, 114);
            this.groundInfoFlatness.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groundInfoFlatness.MouseState = MaterialSkin.MouseState.HOVER;
            this.groundInfoFlatness.Name = "groundInfoFlatness";
            this.groundInfoFlatness.Size = new System.Drawing.Size(82, 24);
            this.groundInfoFlatness.TabIndex = 1;
            this.groundInfoFlatness.Text = "Flatness:";
            // 
            // groundInfoAltitude
            // 
            this.groundInfoAltitude.AutoSize = true;
            this.groundInfoAltitude.Depth = 0;
            this.groundInfoAltitude.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.groundInfoAltitude.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.groundInfoAltitude.Location = new System.Drawing.Point(32, 52);
            this.groundInfoAltitude.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groundInfoAltitude.MouseState = MaterialSkin.MouseState.HOVER;
            this.groundInfoAltitude.Name = "groundInfoAltitude";
            this.groundInfoAltitude.Size = new System.Drawing.Size(76, 24);
            this.groundInfoAltitude.TabIndex = 2;
            this.groundInfoAltitude.Text = "Altitude:";
            // 
            // groundInfoTexture
            // 
            this.groundInfoTexture.AutoSize = true;
            this.groundInfoTexture.Depth = 0;
            this.groundInfoTexture.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.groundInfoTexture.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.groundInfoTexture.Location = new System.Drawing.Point(32, 82);
            this.groundInfoTexture.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groundInfoTexture.MouseState = MaterialSkin.MouseState.HOVER;
            this.groundInfoTexture.Name = "groundInfoTexture";
            this.groundInfoTexture.Size = new System.Drawing.Size(75, 24);
            this.groundInfoTexture.TabIndex = 3;
            this.groundInfoTexture.Text = "Texture:";
            // 
            // groundInfoDensity
            // 
            this.groundInfoDensity.AutoSize = true;
            this.groundInfoDensity.Depth = 0;
            this.groundInfoDensity.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.groundInfoDensity.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.groundInfoDensity.Location = new System.Drawing.Point(32, 146);
            this.groundInfoDensity.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groundInfoDensity.MouseState = MaterialSkin.MouseState.HOVER;
            this.groundInfoDensity.Name = "groundInfoDensity";
            this.groundInfoDensity.Size = new System.Drawing.Size(73, 24);
            this.groundInfoDensity.TabIndex = 4;
            this.groundInfoDensity.Text = "Density:";
            // 
            // groundInfoHumidity
            // 
            this.groundInfoHumidity.AutoSize = true;
            this.groundInfoHumidity.Depth = 0;
            this.groundInfoHumidity.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.groundInfoHumidity.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.groundInfoHumidity.Location = new System.Drawing.Point(32, 178);
            this.groundInfoHumidity.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groundInfoHumidity.MouseState = MaterialSkin.MouseState.HOVER;
            this.groundInfoHumidity.Name = "groundInfoHumidity";
            this.groundInfoHumidity.Size = new System.Drawing.Size(86, 24);
            this.groundInfoHumidity.TabIndex = 5;
            this.groundInfoHumidity.Text = "Humidity:";
            // 
            // setHumidity
            // 
            this.setHumidity.AutoSize = true;
            this.setHumidity.Depth = 0;
            this.setHumidity.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.setHumidity.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.setHumidity.Location = new System.Drawing.Point(128, 178);
            this.setHumidity.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.setHumidity.MouseState = MaterialSkin.MouseState.HOVER;
            this.setHumidity.Name = "setHumidity";
            this.setHumidity.Size = new System.Drawing.Size(36, 24);
            this.setHumidity.TabIndex = 10;
            this.setHumidity.Text = "test";
            // 
            // setDensity
            // 
            this.setDensity.AutoSize = true;
            this.setDensity.Depth = 0;
            this.setDensity.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.setDensity.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.setDensity.Location = new System.Drawing.Point(128, 146);
            this.setDensity.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.setDensity.MouseState = MaterialSkin.MouseState.HOVER;
            this.setDensity.Name = "setDensity";
            this.setDensity.Size = new System.Drawing.Size(36, 24);
            this.setDensity.TabIndex = 9;
            this.setDensity.Text = "test";
            // 
            // setTexture
            // 
            this.setTexture.AutoSize = true;
            this.setTexture.Depth = 0;
            this.setTexture.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.setTexture.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.setTexture.Location = new System.Drawing.Point(128, 82);
            this.setTexture.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.setTexture.MouseState = MaterialSkin.MouseState.HOVER;
            this.setTexture.Name = "setTexture";
            this.setTexture.Size = new System.Drawing.Size(36, 24);
            this.setTexture.TabIndex = 8;
            this.setTexture.Text = "test";
            // 
            // setAltitude
            // 
            this.setAltitude.AutoSize = true;
            this.setAltitude.Depth = 0;
            this.setAltitude.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.setAltitude.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.setAltitude.Location = new System.Drawing.Point(128, 52);
            this.setAltitude.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.setAltitude.MouseState = MaterialSkin.MouseState.HOVER;
            this.setAltitude.Name = "setAltitude";
            this.setAltitude.Size = new System.Drawing.Size(36, 24);
            this.setAltitude.TabIndex = 7;
            this.setAltitude.Text = "test";
            // 
            // setFlatness
            // 
            this.setFlatness.AutoSize = true;
            this.setFlatness.Depth = 0;
            this.setFlatness.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.setFlatness.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.setFlatness.Location = new System.Drawing.Point(128, 114);
            this.setFlatness.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.setFlatness.MouseState = MaterialSkin.MouseState.HOVER;
            this.setFlatness.Name = "setFlatness";
            this.setFlatness.Size = new System.Drawing.Size(36, 24);
            this.setFlatness.TabIndex = 6;
            this.setFlatness.Text = "test";
            // 
            // finalSetupCard
            // 
            this.finalSetupCard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.finalSetupCard.Depth = 0;
            this.finalSetupCard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.finalSetupCard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.finalSetupCard.Location = new System.Drawing.Point(3, 3);
            this.finalSetupCard.Margin = new System.Windows.Forms.Padding(14);
            this.finalSetupCard.MouseState = MaterialSkin.MouseState.HOVER;
            this.finalSetupCard.Name = "finalSetupCard";
            this.finalSetupCard.Padding = new System.Windows.Forms.Padding(14);
            this.finalSetupCard.Size = new System.Drawing.Size(933, 442);
            this.finalSetupCard.TabIndex = 1;
            this.finalSetupCard.Visible = false;
            // 
            // groundInformationContinueBtn
            // 
            this.groundInformationContinueBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groundInformationContinueBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.groundInformationContinueBtn.Depth = 0;
            this.groundInformationContinueBtn.HighEmphasis = true;
            this.groundInformationContinueBtn.Icon = null;
            this.groundInformationContinueBtn.Location = new System.Drawing.Point(60, 386);
            this.groundInformationContinueBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.groundInformationContinueBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.groundInformationContinueBtn.Name = "groundInformationContinueBtn";
            this.groundInformationContinueBtn.NoAccentTextColor = System.Drawing.Color.Empty;
            this.groundInformationContinueBtn.Size = new System.Drawing.Size(158, 36);
            this.groundInformationContinueBtn.TabIndex = 11;
            this.groundInformationContinueBtn.Text = "Continue";
            this.groundInformationContinueBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.groundInformationContinueBtn.UseAccentColor = false;
            this.groundInformationContinueBtn.UseVisualStyleBackColor = true;
            this.groundInformationContinueBtn.Click += new System.EventHandler(this.groundInformationContinueBtn_Click);
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
            this.Sizable = false;
            this.Text = "TrailMate";
            this.TabMaster.ResumeLayout(false);
            this.setupPage.ResumeLayout(false);
            this.energyPage.ResumeLayout(false);
            this.groundInfoCard.ResumeLayout(false);
            this.groundInfoCard.PerformLayout();
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
        private MaterialSkin.Controls.MaterialCard groundInfoCard;
        private MaterialSkin.Controls.MaterialLabel groundInfoFlatness;
        private MaterialSkin.Controls.MaterialLabel groundInfoMainLabel;
        private MaterialSkin.Controls.MaterialLabel groundInfoTexture;
        private MaterialSkin.Controls.MaterialLabel groundInfoAltitude;
        private MaterialSkin.Controls.MaterialLabel groundInfoHumidity;
        private MaterialSkin.Controls.MaterialLabel groundInfoDensity;
        private MaterialSkin.Controls.MaterialLabel setHumidity;
        private MaterialSkin.Controls.MaterialLabel setDensity;
        private MaterialSkin.Controls.MaterialLabel setTexture;
        private MaterialSkin.Controls.MaterialLabel setAltitude;
        private MaterialSkin.Controls.MaterialLabel setFlatness;
        private MaterialSkin.Controls.MaterialCard finalSetupCard;
        private MaterialSkin.Controls.MaterialButton groundInformationContinueBtn;
    }
}

