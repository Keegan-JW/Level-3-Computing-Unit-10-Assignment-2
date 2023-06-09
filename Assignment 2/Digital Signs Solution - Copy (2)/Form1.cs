using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Digital_Signs_Solution
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        #region Form1
        private void Form1_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false; //So the user can not enlarge the form
        }
        #endregion

        #region ZoomInAndOut

        float fontchange = 1;

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (Control control in MenuPanel.Controls)
            {
                FontStyle style = FontStyle.Regular;
                float fontsize = control.Font.Size + fontchange;
                string fontname = control.Font.Name;
                string fontstyle = control.Font.Style.ToString();
                if (fontstyle == "Regular")
                {
                    style = FontStyle.Regular;
                }
                else if (fontstyle == "Bold")
                {
                    style = FontStyle.Bold;
                }
                control.Font = new Font(fontname, fontsize, style); ;
            }
        }

        private void pictureBoxZoomOut_Click(object sender, EventArgs e)
        {
            foreach (Control control in MenuPanel.Controls)
            {
                FontStyle style = FontStyle.Regular;
                float fontsize = control.Font.Size - fontchange;
                string fontname = control.Font.Name;
                string fontstyle = control.Font.Style.ToString();
                if (fontstyle == "Regular")
                {
                    style = FontStyle.Regular;
                }
                else if (fontstyle == "Bold")
                {
                    style = FontStyle.Bold;
                }
                control.Font = new Font(fontname, fontsize, style); ;
            }
        }
        #endregion

        #region richTextBox
        private void richTextBoxFireEscape_TextChanged(object sender, EventArgs e)
        {

        }
        #endregion

        #region LanguageEvents
        private void btnBackLanguages_Click(object sender, EventArgs e)
        {
            ChangeTab(MenuPanel);
        }

        private void btnLanguage_Click(object sender, EventArgs e)
        {
            ChangeTab(LanguagePanel);
        }

        private void btnLanguagesFireEscape_Click(object sender, EventArgs e)
        {
            ChangeTab(FireEscapePanel);
        }

        #endregion

        #region FireEscapeEvents
        private void btnFireEscape_Click(object sender, EventArgs e)
        {
            ChangeTab(FireEscapePanel);
        }

        private void btnBackFireEscape_Click(object sender, EventArgs e)
        {
            ChangeTab(MenuPanel);
        }
        #endregion

        #region LanguageConversion
        private void ChangeLanguage(int language)
        {
            if (language == 1) //English
            {
                btnSpecialOffers.Text = "Amenities";
                btnParking.Text = "Travel && Parking";
                btnStoreFinder.Text = "Store Finder";
                btnFireEscape.Text = "Fire Escape";
                btnBackLanguages.Text = "Back";
                btnLanguage.Text = "Languages";
                lblTitle.Text = "AMAP Shopping Centre";
                lblTitle2.Text = "Nottingham";
                lblFireEscape.Text = "Fire Escape";
                richTextBoxFireEscape.Text = "Fire Escape Plan for AMAP Shopping Centre: \n \nUse marked emergency exits (main entrance, side exits, rear exit) \n \nFollow green and yellow arrows on the ground indicating primary and secondary evacuation routes. \n \nAssembly points are located in the parking lot near the main entrance, on the opposite side of the shopping center, and at the back. Follow instructions, avoid elevators, and assist others to safety.";
                btnBackFireEscape.Text = "Back";
                lblLanguagesTitle.Text = "Languages";
                lblUK.Text = "English";
                lblPoland.Text = "Polski";
                lblFrance.Text = "Français";
                btnStoreFinderFireEscape.Text = "Fire Escape";

                lblStoreFinderTitle.Text = "Store Finder";
                btnAllShops.Text = "All Shops";
                btnFood.Text = "Food";
                btnBanks.Text = "Banks";
                btnMap.Text = "Map";
                btnStoreFinderFireEscape.Text = "Fire Escape";
                lblOffersTitle.Text = "Special Offers";
                btnSpecialOffersBack.Text = "Back";
                btnSpeialOffersFireEscape.Text = "Fire Escape";
                lblParkingTitle.Text = "Travel && Parking";
                btnPrices.Text = "Prices";
                btnParking1.Text = "Parking 1";
                btnParking2.Text = "Parking 2";
                btnParkingBack.Text = "Back";
                btnFireEscapeTravel.Text = "Fire Escape";
            }
            else if (language == 2) //Polish
            {
                btnSpecialOffers.Text = "Udogodnienia";
                btnParking.Text = "Parking && podróżny";
                btnStoreFinder.Text = "Wyszukiwarka sklepu";
                btnFireEscape.Text = "Wyjście pożarowe";
                btnBackLanguages.Text = "Z powrotem";
                btnLanguage.Text = "Languages";
                lblTitle.Text = "AMAP Centrum handlowe";
                lblTitle2.Text = "Nottingham";
                lblFireEscape.Text = "Wyjście pożarowe";
                richTextBoxFireEscape.Text = "Plan ewakuacyjny dla Centrum Handlowego AMAP: \n \nUżyj oznaczonych wyjść ewakuacyjnych (wejście główne, wyjścia boczne, wyjście tylne) \n \nPodążaj za zielonymi i żółtymi strzałkami na ziemi, wskazując główne i drugorzędne drogi ewakuacyjne. \n \nPunkty zbiórki znajdują się na parkingu przy wejściu głównym, po przeciwnej stronie centrum handlowego oraz z tyłu. Postępuj zgodnie z instrukcjami, unikaj wind i pomagaj innym bezpiecznie się wydostać.";
                btnBackFireEscape.Text = "Z powrotem";
                lblLanguagesTitle.Text = "Języki";
                lblUK.Text = "English";
                lblPoland.Text = "Polski";
                lblFrance.Text = "Français";
                btnStoreFinderFireEscape.Text = "Wyjście pożarowe";
            }
            else if (language == 3) //French
            {
                btnSpecialOffers.Text = "Agréments";
                btnParking.Text = "Voyage && Parking";
                btnStoreFinder.Text = "Trouver un magasin";
                btnFireEscape.Text = "Escalier de secours";
                btnBackLanguages.Text = "Dos";
                btnLanguage.Text = "Languages";
                lblTitle.Text = "AMAP Centre commercial";
                lblTitle2.Text = "Nottingham";
                lblFireEscape.Text = "Escalier de secours";
                richTextBoxFireEscape.Text = "Plan d'évacuation en cas d'incendie du centre commercial AMAP: \n \nUtilisez les issues de secours balisées(entrée principale, sorties latérales, sortie arrière) \n \nSuivez les flèches vertes et jaunes au sol indiquant les voies d'évacuation primaires et secondaires. \n \nLes points de rassemblement sont situés sur le parking près de l'entrée principale, de l'autre côté du centre commercial et à l'arrière.Suivez les instructions, évitez les ascenseurs et aidez les autres à se mettre en sécurité.";
                btnBackFireEscape.Text = "Dos";
                lblLanguagesTitle.Text = "Langues";
                lblUK.Text = "English";
                lblPoland.Text = "Polski";
                lblFrance.Text = "Français";
                btnStoreFinderFireEscape.Text = "Escalier de secours";
            }
        }
        private void pictureBoxUK_Click(object sender, EventArgs e)
        {
            ChangeLanguage(1);
            lblUK.ForeColor = Color.Goldenrod;
            lblPoland.ForeColor = Color.Black;
            lblFrance.ForeColor = Color.Black;
        }

        private void pictureBoxPoland_Click(object sender, EventArgs e)
        {
            ChangeLanguage(2);
            lblUK.ForeColor = Color.Black;
            lblPoland.ForeColor = Color.Goldenrod;
            lblFrance.ForeColor = Color.Black;
        }

        private void pictureBoxFrance_Click(object sender, EventArgs e)
        {
            ChangeLanguage(3);
            lblUK.ForeColor = Color.Black;
            lblPoland.ForeColor = Color.Black;
            lblFrance.ForeColor = Color.Goldenrod;
        }
        #endregion

        #region ClickEvents

        private void btnStoreFinder_Click(object sender, EventArgs e)
        {
            ChangeTab(panelStoreFinder);
        }

        private void btnStoreFinderBack_Click(object sender, EventArgs e)
        {
            ChangeTab(MenuPanel);
        }

        private void btnAmmenities_Click(object sender, EventArgs e)
        {
            ChangeTab(panelSpecialOffers);
        }
        #endregion

        #region fireandback
        private void btnParking_Click(object sender, EventArgs e)
        {
            ChangeTab(panelParkingTravel);
        }

        private void btnParkingBack_Click(object sender, EventArgs e)
        {
            ChangeTab(MenuPanel);
        }

        private void btnBackAmenities_Click(object sender, EventArgs e)
        {
            ChangeTab(MenuPanel);
        }

        private void btnStoreFinderFireEscape_Click(object sender, EventArgs e)
        {
            ChangeTab(FireEscapePanel);
        }

        private void btnFireEscapeAmenities_Click(object sender, EventArgs e)
        {
            ChangeTab(FireEscapePanel);
        }

        private void btnFireEscapeTravel_Click(object sender, EventArgs e)
        {
            ChangeTab(FireEscapePanel);
        }
        #endregion




        //A region for all the code for the Parking and Travel panels.
        #region ParkingAndTravelTotalPages

        #region ParkingAndTravel
        private void btnPrices_Click(object sender, EventArgs e) //Prices button on the travel and parking panel
        {
            ChangeTab(panelParkingPrices);
        }

        private void btnParking1_Click(object sender, EventArgs e) //Parking 1 button on the travel and parking panel
        {
            ChangeTab(panelParking1);   
        }

        private void btnParking2_Click(object sender, EventArgs e) //Parking 2 button on the travel and parking panel
        {
            ChangeTab(panelParking2);
        }

        #endregion

        #region ParkingAndTravelPrices

        private void ChangeTab(Panel panel)
        {
            panelParkingTravel.Visible = false;
            panelParkingPrices.Visible = false;
            MenuPanel.Visible = false;
            LanguagePanel.Visible = false;
            panelStoreFinder.Visible = false;
            panelSpecialOffers.Visible = false;
            panelParking1.Visible = false;
            panelParking2.Visible = false;
            FireEscapePanel.Visible = false;
            panel.Visible = true;
        }

        private void btnParking1OnPrices(object sender, EventArgs e) //Parking 1 button on Parking and Travel Prices Panel
        {
            ChangeTab(panelParking1);
        }

        private void btnParking2OnPrices(object sender, EventArgs e) //Parking 2 button on Parking and Travel Prices Panel 
        {
            ChangeTab(panelParking2);
        }

        private void btBackPrices_Click(object sender, EventArgs e) //Back Button on Parking and Travel Prices Panel
        {
            ChangeTab(MenuPanel);
        }

        private void btnPricesFireEscape_Click(object sender, EventArgs e)
        {
            ChangeTab(FireEscapePanel);
        }

        #endregion

        #region ParkingAndTravelParking1

        private void btnPricesOnPanelParking1_Click(object sender, EventArgs e)
        {
            ChangeTab(panelParkingPrices);
        }

        private void btnParking2OnPanelParking1_Click(object sender, EventArgs e)
        {
            ChangeTab(panelParking2);
        }

        private void btnBackParking1_Click(object sender, EventArgs e)
        {
            ChangeTab(MenuPanel);
        }

        private void btnFireEscapeParking1_Click(object sender, EventArgs e)
        {
            ChangeTab(FireEscapePanel);
        }

        #endregion

        #region ParkingAndTravelParking2

        private void btnPricesOnPanelParking2_Click(object sender, EventArgs e)
        {
            ChangeTab(panelParkingPrices);
        }

        private void btnParking1OnParking2Panel_Click(object sender, EventArgs e)
        {
            ChangeTab(panelParking1);
        }

        private void btnBackParking2_Click(object sender, EventArgs e)
        {
            ChangeTab(MenuPanel);
        }

        private void btnFireEscapeParking2_Click(object sender, EventArgs e)
        {
            ChangeTab(FireEscapePanel);
        }

        #endregion

        #endregion







        private void lblParkingTitle_Click(object sender, EventArgs e)
        {

        }

        private void btnBank_Click(object sender, EventArgs e)
        {

        }

        private void btnFood_Click(object sender, EventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {

        }

    }
}
