using GMap.NET.MapProviders;
using GMap.NET;
using GMap.NET.WindowsForms;
using MaterialSkin;
using MaterialSkin.Controls;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using GMap.NET.WindowsForms.Markers;
using Trailmate.Classes;
using System;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;
using System.Reflection;
using System.Drawing;
using System.Collections;
using System.Collections.Generic;
using System.Data.Entity.Core.Metadata.Edm;
using System.Linq;
using static GMap.NET.Entity.OpenStreetMapGraphHopperGeocodeEntity;
using System.Runtime.Remoting.Contexts;
using System.Data.Entity;
using MaterialSkin.Properties;
using System.Diagnostics;

namespace Trailmate
{
    public partial class Form1 : MaterialForm
    {
        public static Form1 instance;

        int psi1, angle1 = 0;
        int psi2, angle2 = 0;
        int psi3, angle3 = 0;
        int psi4, angle4 = 0;

        int energySaving = 0;
        int energyConsumption = 0;

        public static CampMarker selectedCampsite;
        map Map;

        map EmergencyMap;
        GMarkerGoogle shelter;

        map ExploreMap;

        int initialInterval;

        double orderTotal;

        List<MaterialLabel> materialLabels = new List<MaterialLabel>();

        List<Event> events = new List<Event>();

        TouristSpot selectedSpot;

        Color clr;
        Color internalColor;
        Color clrPicked;

        double lightIntensity = 1.0;

        double lightWarmth = 0;

        Color[] rainbowEffect = { Color.Red, Color.Orange, Color.Yellow, Color.Green, Color.Blue, Color.Purple };
        int rainbowIndex = 0;

        Fabric loadedFabric;
        bool mouseDownHold;
        List<Fabric> fabrics = new List<Fabric>();

        public Form1()
        {
            InitializeComponent();
            instance = this;

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Teal900, Primary.Teal800, Primary.Teal700, Accent.Teal700, TextShade.WHITE);

            Map = new map(setupPage);
            initialInterval = timer1.Interval;

            FoodItem Latte = new FoodItem("Latte", 4.5, latteAddButton);
            FoodItem Cappuccino = new FoodItem("Cappuccino", 4, cappuccinoAddButton);
            FoodItem Espresso = new FoodItem("Espresso", 3.5, espressoAddButton);
            FoodItem Americano = new FoodItem("Americano", 4.5, americanoAddButton);

            FoodItem Water = new FoodItem("Water", 0.5, waterAddButton);
            FoodItem Lemonade = new FoodItem("Lemonade", 2.5, lemonadeAddButton);
            FoodItem Orangade = new FoodItem("Orangade", 2.5, orangadeAddButton);
            FoodItem Cocktail = new FoodItem("Cocktail", 10.5, cocktailAddButton);

            FoodItem Burger = new FoodItem("Burger", 13, burgerAddButton);
            FoodItem Pizza = new FoodItem("Pizza", 12, pizzaAddButton);
            FoodItem Sandwich = new FoodItem("Sandwich", 6.5, sandwichAddButton);
            FoodItem Fries = new FoodItem("French fries", 5, frenchFriesAddButton);

            Event celineConcert = new Event(eventType.Concert, "Celine Dion", "9:00 pm", "2 hours", "At the central stage of the camping, near the cafe", concertInfoButton, concertGoingButton, eventGoingCheck1);
            Event dayTrip = new Event(eventType.Trip, "Trip at ...", "9:30 am", "7 hours", "At the camping lobby", dayTripInfoButton, imGoingDayTripButton, eventGoingCheck2);
            Event workshop = new Event(eventType.Workshop, "Programming workshop", "5:00 pm", "3 hours", "At the exhibitions hall, behind the cafe", workshopInfoButton, workshopImGoingButton, eventGoingCheck3);
            Event hikeTour = new Event(eventType.Hike, "Hiking tour around the camp", "8:00 am", "3 hours", "At the camping lobby", hikeTourInfoButton, hikeTourImGoingButton, eventGoingCheck4);

            CampMarker Campsite1 = new CampMarker(new PointLatLng(38.196180, 23.736182), "Camp Site 1: 38.196180, 23.736182",
                "320m", "Smooth", "Relatively flat", "1530 kg/m^3", "47%");

            CampMarker Campsite2 = new CampMarker(new PointLatLng(38.195464, 23.740821), "Camp Site 2: 38.195464, 23.740821",
                "110m", "Smooth", "Flat", "740 kg/m^3", "25%");

            CampMarker Campsite3 = new CampMarker(new PointLatLng(38.196708, 23.735236), "Camp Site 3: 38.196708, 23.735236",
                "270m", "Rocky", "Relatively flat", "900 kg/m^3", "31%");

            CampMarker Campsite4 = new CampMarker(new PointLatLng(38.193456, 23.746023), "Camp Site 4: 38.193456, 23.746023",
                "490m", "Rocky", "Relatively flat", "1710 kg/m^3", "62%");

            CampMarker Campsite5 = new CampMarker(new PointLatLng(38.197821, 23.741660), "Camp Site 5: 38.197821, 23.741660",
                "20m", "Smooth", "Flat", "1080 kg/m^3", "17%");

            List<CampMarker> markers = new List<CampMarker>();
            markers.Add(Campsite1);
            markers.Add(Campsite2);
            markers.Add(Campsite3);
            markers.Add(Campsite4);
            markers.Add(Campsite5);

            Map.initializeMarkers(markers);

            EmergencyMap = new map(emergencyPage);
            EmergencyMap.setCamp();
            emergencyMapCard.Controls.Add(EmergencyMap.mapControl);

            ExploreMap = new map(explorePage);
            ExploreMap.setCamp();
            mapExploreCard.Controls.Add(ExploreMap.mapControl);

            TouristSpot ForestRestaurant = new TouristSpot(new PointLatLng(38.198473, 23.735281), "Forest restaurant", "550m away", "4.5", "Open", forestRestaurantExploreLabel);
            TouristSpot HikeTrail = new TouristSpot(new PointLatLng(38.194426, 23.738682), "Hike trail", "760m away", "3.9", "Open", hikeTrailExploreLabel);
            TouristSpot Temple = new TouristSpot(new PointLatLng(38.198077, 23.743521), "Buddhist Temple", "1.4m away", "4.6", "Open", buddhistTempleExploreLabel);
            TouristSpot Bar = new TouristSpot(new PointLatLng(38.195354, 23.739808), "Bar", "430m away", "4.9", "Open", BarExploreLabel);

            changeColor(Color.Black);

            Fabric standard = new Fabric("Standard fabric", "This fabric is the most versatile fabric.", Properties.Resources.tent, fabric1PictureBox);
            Fabric insulating = new Fabric("Insulating fabric", "This fabric is best suitable for cold weather, as the special nanofibers keep the heat in and the cold out", Properties.Resources.tent_hot, fabric2PictureBox);
            Fabric breezy = new Fabric("Breezy fabric", "This fabric is best suitable for hot weather, as it allows the air to flow in the tent", Properties.Resources.tent_breezy, fabric3PictureBox);
            Fabric enforced = new Fabric("Enforced fabric", "This fabric is suitable for hazardous phenomena as it protects your tent.", Properties.Resources.tent_enforced, fabric4PictureBox);
            
            fabrics.Add(standard);
            fabrics.Add(insulating);
            fabrics.Add(breezy);
            fabrics.Add(enforced);

            tentControlTentPreviewPictureBox.AllowDrop = true;
        }

        private void onFabric_mouseDown(object sender, MouseEventArgs e)
        {
            loadedFabric = ((PictureBox)sender).Tag as Fabric;

            if (((PictureBox)sender).Image != null && e.Button == MouseButtons.Left)
            {
                DoDragDrop(((PictureBox)sender).Image, DragDropEffects.Copy);
            }
        }

        private void tentControlTentPreviewPictureBox_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(Bitmap)))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void tentControlTentPreviewPictureBox_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(Bitmap)))
            {
                tentControlTentPreviewPictureBox.Image = loadedFabric.img;
                defaultFabricNameLabel.Text = loadedFabric.name;
                defaultFabricDescriptionLabel.Text = loadedFabric.description;
                loadedFabric.usedCounter++;

                updateFavorites();
            }
        }

        void updateFavorites()
        {
            if (loadedFabric != null)
            {
                Fabric no1 = null;

                foreach (Fabric item in fabrics)
                {
                    if(item.usedCounter >= no1.usedCounter)
                    {
                        no1 = item;
                    }
                }

                mostUsedPictureBox1.Tag = no1;
                //unfinished
            }
        }

        private void setupEmergencyMap()
        {
            EmergencyMap.initializeMarkers(selectedCampsite);

            shelter = new GMarkerGoogle(new PointLatLng(38.196180, 23.739319) , GMarkerGoogleType.blue_dot)
            {
                ToolTipText = "Closest Shelter is here",
                ToolTipMode = MarkerTooltipMode.OnMouseOver,
            };

            EmergencyMap.markersOverlay.Markers.Add(shelter);
        }

        private void setupExploreMap()
        {
            ExploreMap.initializeMarkers(selectedCampsite);

            ExploreMap.initializeMarkers(TouristSpot.gMarkers);
        }

        private void exploreLabel_Click(object sender, EventArgs e)
        {
            MaterialLabel label = sender as MaterialLabel;

            TouristSpot spot = label.Tag as TouristSpot;

            distanceExploreLabelVar1.Text = spot.distance;
            starsExploreLabelVar1.Text = spot.rating;
            openExploreLabel.Text = spot.availability;

            selectedSpot = spot;

            label.BorderStyle = BorderStyle.FixedSingle;
            label.Focus();

            ExploreMap.clearRoute();
        }

        private void startNavigationExploreButton_Click(object sender, EventArgs e)
        {
            if(selectedSpot != null)
            {
                ExploreMap.DrawRoute(selectedCampsite.getMarker().Position, selectedSpot.marker.Position);
            }
        }

        private void exploreLabel_ClickAway(object sender, EventArgs e)
        {
            MaterialLabel label = sender as MaterialLabel;
            label.BorderStyle = BorderStyle.None;
        }

        private void startNavEmergencyButton_Click(object sender, EventArgs e)
        {
            EmergencyMap.DrawRoute(selectedCampsite.getMarker().Position , shelter.Position);
            EmergencyMap.mapControl.Zoom = 12;
            EmergencyMap.mapControl.Zoom = 14;

        }

        private void onPageChange(object sender, EventArgs e)
        {
            TabControl pageManager = (TabControl)sender;

            if (pageManager.SelectedTab.Text != "Setup")
            {
                pageManager.SelectedTab.Controls.Add(blockCard1);
                blockCard1.BringToFront();
            }

        }

        private void myCampMarker_Click(object sender, EventArgs e)
        {
            finalSetupCard.Visible = true;
            finalizeButton.Visible = false;
        }

        private void littleSwitch_toggle(object sender, EventArgs e)
        {
            MaterialSwitch lightSwitch = sender as MaterialSwitch;

            lightSwitch1.Text = lightSwitch.Checked ? "On" : " Off";
            lightSwitch1.Checked = lightSwitch.Checked;
            lightSwitch2.Text = lightSwitch.Checked ? "On" : " Off";
            lightSwitch2.Checked = lightSwitch.Checked;

            if(!lightSwitch.Checked)
            {
                changeColor(Color.Black);
                timer2.Enabled = false;
                timer3.Enabled = false;
            } else
            {
                changeColor(Color.White);
            }
        }

        private void infoEventButton_Click(object sender, EventArgs e)
        {
            MaterialButton btn = (MaterialButton)sender;
            Event eventData = btn.Tag as Event;

            eventNameLabel1.Text = eventData.name;
            eventTimeLabel1.Text = eventData.time;
            eventDurationLabel1.Text = eventData.duration;
            eventVenueLabel1.Text = eventData.venue;
        }

        private void goingEventButton_Click(object sender, EventArgs e)
        {
            MaterialButton btn = (MaterialButton)sender;
            Event eventData = btn.Tag as Event;

            switch (eventData.checkbox.Checked)
            {
                case true:
                    eventData.checkbox.Checked = false;
                    events.Remove(eventData);
                    break;

                case false:
                    eventData.checkbox.Checked = true;
                    events.Add(eventData);
                    break;
            }
        }

        private void submitOrderButton_Click(object sender, EventArgs e)
        {
            if (orderTotal <= 0) return;
            
            orderPlacedCard.Visible = true;
            orderPlacedCard.BringToFront();

            totalLabel.Visible = false;
            priceLabel.Visible = false;
        }

        private void addToOrderButton_Click(object sender, EventArgs e)
        {
            totalLabel.Visible = true;
            priceLabel.Visible = true;

            MaterialButton button = (MaterialButton)sender;
            FoodItem item = (FoodItem)button.Tag;
            orderTotal += item.price;

            MaterialLabel itemLabel = new MaterialLabel();

            itemLabel.Location = itemPointer.Location;
            itemPointer.Location = new System.Drawing.Point(itemPointer.Location.X, itemPointer.Location.Y + 20);

            itemLabel.Text = item.item + " " + item.price.ToString() + "$";
            itemLabel.AutoSize = false;
            itemLabel.Size = itemPointer.Size;

            cart.Controls.Add(itemLabel);
            materialLabels.Add(itemLabel);

            incartLabel.Text = "items in cart:";
            priceLabel.Text = orderTotal.ToString() + " $";
        }

        private void closeOrderConfirmationButton_Click(object sender, EventArgs e)
        {
            cleanCart();
            orderPlacedCard.Visible = false;
        }

        private void discardChangesButton_Click(object sender, EventArgs e)
        {
            cleanCart();
        }

        void cleanCart()
        {
            totalLabel.Visible = false;
            priceLabel.Visible = false;

            incartLabel.Text = "No items in cart.";
            orderTotal = 0;

            itemPointer.Location = new System.Drawing.Point(16, 20);

            foreach (MaterialLabel item in materialLabels.ToList())
            {
                cart.Controls.Remove(item);
                materialLabels.Remove(item);
            }
        }

        private void groundInformationContinueBtn_Click(object sender, System.EventArgs e)
        {
            if (selectedCampsite != null)
            {
                groundInfoCard.Visible = false;
                finalSetupCard.Visible = true;
            }
        }

        private void checkButton_Click(object sender, EventArgs e)
        {
            bool label1 = calculateStatus(psi1, angle1);
            setPressure1.Text = psi1.ToString() + " psi";
            setAngle1.Text = angle1.ToString() + " degrees";

            bool label2 = calculateStatus(psi2, angle2);
            setPressure2.Text = psi2.ToString() + " psi";
            setAngle2.Text = angle2.ToString() + " degrees";

            bool label3 = calculateStatus(psi3, angle3);
            setPressure3.Text = psi3.ToString() + " psi";
            setAngle3.Text = angle3.ToString() + " degrees";

            bool label4 = calculateStatus(psi4, angle4);
            setPressure4.Text = psi4.ToString() + " psi";
            setAngle4.Text = angle4.ToString() + " degrees";

            setStatus1.Text = label1 ? "OK!" : "Adjustment needed";
            setStatus2.Text = label2 ? "OK!" : "Adjustment needed";
            setStatus3.Text = label3 ? "OK!" : "Adjustment needed";
            setStatus4.Text = label4 ? "OK!" : "Adjustment needed";


            bool flag = label1 == label2 == label3 == label4 & label1 == true;

            stakesStatusChanging.Text = flag ? "Stable" : "Unstable";

            if (flag) finalizeButton.Visible = true;
        }

        bool calculateStatus(int psi, int angle)
        {
            int density = int.Parse( selectedCampsite.density.Substring(0, selectedCampsite.density.Length - 7) );
            bool status = false;

            if (density <= 1000)
            {
                status = psi > 0 && angle >= 0;
            }
            else
            {
                status = psi > 15 && angle >= 0;
            }

            return status;
        }

        private void finalizeButton_Click(object sender, EventArgs e)
        {
            finalSetupCard.Visible = false;
            Map.clearMarkers();
            selectedCampsite.changeContext("Your camp is here!");

            Map.initializeMarkers(selectedCampsite);
            Map.mapControl.OnMarkerClick += myCampMarker_Click;
            Map.setCamp();

            TabMaster.SelectedIndexChanged -= onPageChange;
            blockCard1.Dispose();

            setupEmergencyMap();
            setupExploreMap();
        }

        private void switches_CheckedChanged(object sender, EventArgs e)
        {
            MaterialSwitch toggle = (MaterialSwitch)sender;
            toggle.Text = toggle.Text == "Off" ? toggle.Text = "On" : toggle.Text = "Off";

            switch (toggle.Checked)
            {
                case true: energyConsumption += 1; break;
                case false: energyConsumption -= 1; break;
            }
        }

        private void energySaving_CheckedChanged(object sender, EventArgs e)
        {
            MaterialCheckbox toggle = (MaterialCheckbox)sender;

            switch (toggle.Checked)
            {
                case true: energySaving += 1; break;
                case false: energySaving -= 1; break;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Interval = initialInterval;
            update_tickrate();

            if (Battery.Value >= 0)
            {
                Battery.Value -= 1;
            }
            else
            {
                timer1.Enabled = false;
            }
        }

        private void colorSpectrum_MouseDown(object sender, MouseEventArgs e)
        {
            Bitmap pixelData = (Bitmap)colorSpectrum.Image;
            clrPicked = pixelData.GetPixel(e.X, e.Y);

            colorPreview.BackColor = clrPicked;
        }

        private void colorSelectApplyButton_Click(object sender, EventArgs e)
        {
            if (lightSwitch2.Checked)
            {
                changeColor(clrPicked);
                timer2.Enabled = false;
                timer3.Enabled = false;
            }
        }

        private void changeColor(Color color)
        {
            clr = color;
            internalColor = Color.FromArgb((int)(color.R * lightIntensity), (int)(color.G * lightIntensity), (int)(color.B * lightIntensity));
            internalColor = Color.FromArgb(Clamp((int)(internalColor.R + lightWarmth), 0, 255), internalColor.G, Clamp((int)(internalColor.B - lightWarmth), 0, 255));

            color1.BackColor = internalColor;
            color2.BackColor = internalColor;
            color3.BackColor = internalColor;
            color4.BackColor = internalColor;
        }

        private void nightModeButton_Click(object sender, EventArgs e)
        {
            changeColor(Color.Orange);
            timer2.Enabled = false;
            timer3.Enabled = false;
        }

        private void intensityLightControlSlider_onValueChanged(object sender, int newValue)
        {
            lightIntensity = newValue * 0.01;

            changeColor(clr);
        }

        private void warmthLightControlSlider_onValueChanged(object sender, int newValue)
        {
            lightWarmth = newValue;
            
            changeColor(clr);
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if(clr == Color.Black) { 
                changeColor(clrPicked); 
            } else
            {
                changeColor(Color.Black);
            }
        }

        private void flashingEffectButton_Click(object sender, EventArgs e)
        {
            timer2.Enabled = true;
            timer3.Enabled = false;
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            changeColor(rainbowEffect[rainbowIndex]);

            rainbowIndex++;
            rainbowIndex = rainbowIndex > rainbowEffect.Length - 1 ? 0 : rainbowIndex;
        }

        private void RainbowEffectButton_Click(object sender, EventArgs e)
        {
            timer3.Enabled = true;
            timer2.Enabled = false;
        }

        void update_tickrate()
        {
            switch (energySaving - energyConsumption)
            {
                case -1:
                    timer1.Interval = timer1.Interval - 1000;
                    break;

                case -2:
                    timer1.Interval = timer1.Interval - 1500;
                    break;

                case -3:
                    timer1.Interval = timer1.Interval - 2000;
                    break;
                case -4:
                    timer1.Interval = timer1.Interval - 2250;
                    break;
                case 0:
                    timer1.Interval = initialInterval;
                    break;
                case 1:
                    timer1.Interval = timer1.Interval + 1000;
                    break;

                case 2:
                    timer1.Interval = timer1.Interval + 1500;
                    break;

                case 3:
                    timer1.Interval = timer1.Interval + 2000;
                    break;
            }
        }

        private void orderNowHomeButton_Click(object sender, EventArgs e)
        {
            TabMaster.SelectTab(4);
        }

        private void energySeeMoreButton_Click(object sender, EventArgs e)
        {
            TabMaster.SelectTab(5);
        }

        private void stakesStatusSeeMoreButton_Click(object sender, EventArgs e)
        {
            TabMaster.SelectTab(1);
        }

        private void blockButton_Click(object sender, EventArgs e)
        {
            TabMaster.SelectTab(1);
        }

        private void upcomingEventsSeeMoreButton_Click(object sender, EventArgs e)
        {
            TabMaster.SelectTab(3);
        }

        //Stake 1
        private void pressureScrollbar1_Scroll(object sender, ScrollEventArgs e)
        {
            psi1 = pressureScrollbar1.Value;
            setPressure1.Text = psi1.ToString() + " psi";
        }

        private void angleScrollbar1_Scroll(object sender, ScrollEventArgs e)
        {
            angle1 = angleScrollbar1.Value;
            setAngle1.Text = angle1.ToString() + " degrees";
        }

        //Stake 2
        private void pressureScrollbar2_Scroll(object sender, ScrollEventArgs e)
        {
            psi2 = pressureScrollbar2.Value;
            setPressure2.Text = psi2.ToString() + " psi";
        }

        private void angleScrollbar2_Scroll(object sender, ScrollEventArgs e)
        {
            angle2 = angleScrollbar2.Value;
            setAngle2.Text = angle2.ToString() + " degrees";
        }

        //Stake 3
        private void pressureScrollbar3_Scroll(object sender, ScrollEventArgs e)
        {
            psi3 = pressureScrollbar3.Value;
            setPressure3.Text = psi3.ToString() + " psi";
        }

        private void angleScrollbar3_Scroll(object sender, ScrollEventArgs e)
        {
            angle3 = angleScrollbar3.Value;
            setAngle3.Text = angle3.ToString() + " degrees";
        }

        //Stake 4
        private void pressureScrollbar4_Scroll(object sender, ScrollEventArgs e)
        {
            psi4 = pressureScrollbar4.Value;
            setPressure4.Text = psi4.ToString() + " psi";
        }

        private void angleScrollbar4_Scroll(object sender, ScrollEventArgs e)
        {
            angle4 = angleScrollbar4.Value;
            setAngle4.Text = angle4.ToString() + " degrees";
        }

        public static int Clamp(int value, int min, int max)
        {
            return (value < min) ? min : (value > max) ? max : value;
        }
    }
}
