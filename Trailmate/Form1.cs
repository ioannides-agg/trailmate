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

        public static Marker selectedCampsite;
        map Map;

        int initialInterval;

        double orderTotal;

        FoodItem Latte, Cappuccino, Espresso, Americano;
        FoodItem Water, Lemonade, Orangade, Cocktail;
        FoodItem Burger, Pizza, Sandwich, Fries;

        List<MaterialLabel> materialLabels = new List<MaterialLabel>();

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

            Latte = new FoodItem("Latte", 4.5, latteAddButton);
            Cappuccino = new FoodItem("Cappuccino", 4, cappuccinoAddButton);
            Espresso = new FoodItem("Espresso", 3.5, espressoAddButton);
            Americano = new FoodItem("Americano", 4.5, americanoAddButton);

            Water = new FoodItem("Water", 0.5, waterAddButton);
            Lemonade = new FoodItem("Lemonade", 2.5, lemonadeAddButton);
            Orangade = new FoodItem("Orangade", 2.5, orangadeAddButton);
            Cocktail = new FoodItem("Cocktail", 10.5, cocktailAddButton);

            Burger = new FoodItem("Burger", 13, burgerAddButton);
            Pizza = new FoodItem("Pizza", 12, pizzaAddButton);
            Sandwich = new FoodItem("Sandwich", 6.5, sandwichAddButton);
            Fries = new FoodItem("French fries", 5, frenchFriesAddButton);
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
            itemPointer.Location = new Point(itemPointer.Location.X, itemPointer.Location.Y + 20);

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

            itemPointer.Location = new Point(16, 20);

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

            psi2 = pressureScrollbar2.Value;
            angle2 = angleScrollbar2.Value;
            bool label2 = calculateStatus(psi2, angle2);

            psi3 = pressureScrollbar3.Value;
            angle3 = pressureScrollbar3.Value;
            bool label3 = calculateStatus(psi3, angle3);

            psi4 = pressureScrollbar4.Value;
            angle4 = pressureScrollbar4.Value;
            bool label4 = calculateStatus(psi4, angle4);

            setStatus1.Text = label1 ? "OK!" : "Adjustment needed";
            setStatus2.Text = label2 ? "OK!" : "Adjustment needed";
            setStatus3.Text = label3 ? "OK!" : "Adjustment needed";
            setStatus4.Text = label4 ? "OK!" : "Adjustment needed";

            bool flag = label1 == label2 == label3 == label4 & label1 == true;

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
                status = psi > 20 && angle >= 0;
            }

            return status;
        }


        private void finalizeButton_Click(object sender, EventArgs e)
        {
            finalSetupCard.Visible = false;
            Map.clearMarkers();
            selectedCampsite.changeContext("Your camp is here!");

            Map.addMarker(selectedCampsite);
            Map.setCamp();
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
    }
}
