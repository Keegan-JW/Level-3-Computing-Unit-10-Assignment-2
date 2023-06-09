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
        Button[] buttons;
        Label[] labels;
        RichTextBox[] richtextboxes;
        public Form1()
        {
            InitializeComponent();
            //An array of all buttons.
            #region Buttons
            buttons = new Button[] {btnStoreFinder, btnSpecialOffers, btnParking, btnLanguage, btnFireEscape, btnBack, btnBackLanguages,
            btnLanguagesFireEscape, btnShopsFood, btnFoodOnFoodPanel, btnBanksFood, btnMapFood, btnBackFood, btnFireEscapeFood,
            btnShopsBanks, btnFoodBanks, btnBanksOnBanks, btnMapBanks, btnBackBanks, btnFireEscapeBanks, btnFoodMap,
            btnShopsMap, btnBanksMap, btnMapOnMap, btnBackMap, btnFireEscapeMap, btnShopsOnShops, btnFoodShops,
            btnBanksShops, btnMapShops, btnBackShops, btnFireEscapeShops, btnFood, btnAllShops, btnBanks, btnMap,
            btnStoreFinderBack, btnStoreFinderFire, btnSpecialOffersBack, btnSpeialOffersFire, btnPricesPrices, btnParking1Prices, btnParkingPrices,
            btnBackPrices, btnPricesFireEscape, btnPricesParking1, btnParking1OnParking1, btnParking2Parking1, btnBackParking1, btnFireEscapeParking1,
            btnPricesParking2, btnParking1Parking2, btnParking2OnParking2, btnBackParking2, btnFireEscapeParking2,btnDisabled, btnBackAccessability, btnFireEscapeAccessability, btnLanguagesAccessability, btnBanksFood, btnShopsFood};
            #endregion

            //An array of all labels.
            #region Labels
            labels = new Label[] {lblTitle, lblTitle2, lblFireEscape, lblLanguagesTitle, lblUK, lblPoland, lblFrance, labelBanks, labelMap, labelShops,
            lblStoreFinderTitle, lblOffersTitle, labelPrices, labelParking1, labelParking2, lblAccessability, labelFood};
            #endregion

            //An array of all rich text boxes.
            #region RichTextBoxes
            richtextboxes = new RichTextBox[] { richTextBoxFireEscape, richTextBoxMap, richTextBoxStore, richTextBoxParkingPrices, richTextBoxParking1Text, richTextBoxParking2, richTextBoxAccessability, };
            #endregion
        }

        //A function to switch panels.
        #region ChangeTab
        private void ChangeTab(Panel panel)
        {
            panelParkingPrices.Visible = false;
            MenuPanel.Visible = false;
            LanguagePanel.Visible = false;
            panelStoreFinder.Visible = false;
            panelSpecialOffers.Visible = false;
            panelParking1.Visible = false;
            panelParking2.Visible = false;
            FireEscapePanel.Visible = false;
            panelFood.Visible = false;
            panelBanks.Visible = false;
            panelMap.Visible = false;
            panelAllShops.Visible = false;
            panelAccessability.Visible = false;
            panel.Visible = true;
        }
        #endregion

        //A region for all code relating to form 1.
        #region Form1
        private void Form1_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false; //So the user can not enlarge the form
        }
        #endregion

        //Code for increasing and decreasing font.
        #region ZoomInAndOut

        float fontchange = 1;
        int fontcount = 0;

        //Code for increasing font.
        private void button2_Click(object sender, EventArgs e)
        {
            if (fontcount < 2) //Code for increasing the font size for all buttons.
            {
                fontcount++;
                foreach (Button control in buttons)
                {
                    FontStyle style = FontStyle.Regular;
                    float fontsize = control.Font.Size + fontchange;
                    string fontname = control.Font.Name;
                    string fontstyle = control.Font.Style.ToString();
                    if (fontstyle == "Regular") //Makes sure that the font style stays bold or regular.
                    {
                        style = FontStyle.Regular;
                    }
                    else if (fontstyle == "Bold")
                    {
                        style = FontStyle.Bold;
                    }
                    control.Font = new Font(fontname, fontsize, style);
                }
            }

            if (fontcount < 3) //Code for increasing the font size for all labels.
            {
                fontcount++;
                foreach (Label control in labels)
                {
                    FontStyle style = FontStyle.Regular;
                    float fontsize = control.Font.Size + fontchange;
                    string fontname = control.Font.Name;
                    string fontstyle = control.Font.Style.ToString();
                    if (fontstyle == "Regular") //Makes sure that the font style stays bold or regular.
                    {
                        style = FontStyle.Regular;
                    }
                    else if (fontstyle == "Bold")
                    {
                        style = FontStyle.Bold;
                    }
                    control.Font = new Font(fontname, fontsize, style);
                }
            }

            if (fontcount < 4) //Code for increasing the font size for all rich text boxes.
            {
                fontcount++;
                foreach (RichTextBox control in richtextboxes)
                {
                    FontStyle style = FontStyle.Regular;
                    float fontsize = control.Font.Size + fontchange;
                    string fontname = control.Font.Name;
                    string fontstyle = control.Font.Style.ToString();
                    if (fontstyle == "Regular") //Makes sure that the font style stays bold or regular.
                    {
                        style = FontStyle.Regular;
                    }
                    else if (fontstyle == "Bold")
                    {
                        style = FontStyle.Bold;
                    }
                    control.Font = new Font(fontname, fontsize, style);
                }
            }
        }

        //Code for decreasing font.
        private void pictureBoxZoomOut_Click(object sender, EventArgs e)
        {
            if (fontcount > -2) //Code for decreasing the font size for all buttons.
            {
                fontcount--;
                foreach (Button control in buttons)
                {
                    FontStyle style = FontStyle.Regular;
                    float fontsize = control.Font.Size - fontchange;
                    string fontname = control.Font.Name;
                    string fontstyle = control.Font.Style.ToString();
                    if (fontstyle == "Regular") //Makes sure that the font style stays bold or regular.
                    {
                        style = FontStyle.Regular;
                    }
                    else if (fontstyle == "Bold")
                    {
                        style = FontStyle.Bold;
                    }
                    control.Font = new Font(fontname, fontsize, style);
                }
            }

            if (fontcount > -4) //Code for decreasing the font size for all labels.
            {
                fontcount--;
                foreach (Label control in labels)
                {
                    FontStyle style = FontStyle.Regular;
                    float fontsize = control.Font.Size - fontchange;
                    string fontname = control.Font.Name;
                    string fontstyle = control.Font.Style.ToString();
                    if (fontstyle == "Regular") //Makes sure that the font style stays bold or regular.
                    {
                        style = FontStyle.Regular;
                    }
                    else if (fontstyle == "Bold")
                    {
                        style = FontStyle.Bold;
                    }
                    control.Font = new Font(fontname, fontsize, style);
                }
            }

            if (fontcount > -4) //Code for decreasing the font size for all rich text boxes.
            {
                fontcount--;
                foreach (RichTextBox control in richtextboxes)
                {
                    FontStyle style = FontStyle.Regular;
                    float fontsize = control.Font.Size - fontchange;
                    string fontname = control.Font.Name;
                    string fontstyle = control.Font.Style.ToString();
                    if (fontstyle == "Regular") //Makes sure that the font style stays bold or regular.
                    {
                        style = FontStyle.Regular;
                    }
                    else if (fontstyle == "Bold")
                    {
                        style = FontStyle.Bold;
                    }
                    control.Font = new Font(fontname, fontsize, style);
                }
            }
        }
        #endregion

        //All code for the language translation.
        #region LanguageConversion
        private void ChangeLanguage(int language)
        {
            if (language == 1) //English - If option 1 is chosen, all the text on the Digital signs solution is set to English.
            {
                //Assigns everything with text on it to its assigned English version.
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
                btnBack.Text = "Back";
                lblLanguagesTitle.Text = "Languages";
                lblUK.Text = "English";
                lblPoland.Text = "Polski";
                lblFrance.Text = "Français";
                btnStoreFinderFire.Text = "Fire Escape";
                btnDisabled.Text = "Accessability";
                textBoxSearch.Text = "Search";
                btnShopsFood.Text = "Shops";
                btnFoodOnFoodPanel.Text = "Food";
                btnBanksFood.Text = "Banks";
                btnMapFood.Text = "Map";
                btnBackFood.Text = "Back";
                btnFireEscapeFood.Text = "Fire Escape";
                labelFood.Text = "StoreFinder - Food";
                btnAccessabilityFood.Text = "Accessability";
                btnShopsBanks.Text = "Shops";
                btnFoodBanks.Text = "Food";
                btnBanksOnBanks.Text = "Banks";
                btnMapBanks.Text = "Banks";
                btnBackBanks.Text = "Back";
                btnFireEscapeBanks.Text = "Fire Escape";
                labelBanks.Text = "StoreFinder - Banks";
                btnAccessabiltyBanks.Text = "Accessability";
                btnShopsMap.Text = "Shops";
                btnFoodMap.Text = "Food";
                btnBanksMap.Text = "Banks";
                btnMapOnMap.Text = "Map";
                btnBackMap.Text = "Back";
                btnFireEscapeMap.Text = "Fire Escape";
                labelMap.Text = "StoreFinder - Map";
                btnAccessabilityMap.Text = "Accessability";
                btnShopsOnShops.Text = "Shops";
                btnFoodShops.Text = "Food";
                btnBanksShops.Text = "Banks";
                btnMapShops.Text = "Map";
                btnBackShops.Text = "Back";
                btnFireEscapeShops.Text = "Fire Escape";
                labelShops.Text = "StoreFinder - Shops";
                btnAccessabilityShops.Text = "Accessability";
                lblStoreFinderTitle.Text = "Store Finder";
                btnAllShops.Text = "All Shops";
                btnFood.Text = "Food";
                btnBanks.Text = "Banks";
                btnMap.Text = "Map";
                btnStoreFinderFire.Text = "Fire Escape";
                lblOffersTitle.Text = "Special Offers";
                btnSpecialOffersBack.Text = "Back";
                btnSpeialOffersFire.Text = "Fire Escape";
                btnLanguagesFireEscape.Text = "Fire Escape";
                labelFood.Text = "StoreFinder - Food";
                btnFoodOnFoodPanel.Text = "Food";
                btnBanksFood.Text = "Banks";
                btnMapFood.Text = "Map";
                btnShopsFood.Text = "All Shops";
                btnBackFood.Text = "Back";
                btnFireEscapeFood.Text = "Fire Escape";
                btnAccessabilityOffers.Text = "Accessability";
                btnPricesParking1.Text = "Prices";
                btnParking1OnParking1.Text = "Parking 1";
                btnParking2Parking1.Text = "Parking 2";
                btnBackParking1.Text = "Back";
                btnFireEscapeParking1.Text = "Fire Escape";
                btnAccessabilityParking1.Text = "Accessability";
                btnPricesParking2.Text = "Prices";
                btnParking1Parking2.Text = "Parking 1";
                btnParking2OnParking2.Text = "Parking 2";
                btnBackParking2.Text = "Back";
                btnFireEscapeParking2.Text = "Fire Escape";
                btnAccessabilityParking2.Text = "Accessability";
                lblAccessability.Text = "Accessability";
                btnBackAccessability.Text = "Back";
                btnFireEscapeAccessability.Text = "Fire Escape";
                btnLanguagesAccessability.Text = "Languages";
                btnPricesPrices.Text = "Prices";
                btnParking1Prices.Text = "Parking 1";
                btnParkingPrices.Text = "Parking 2";
                btnBackPrices.Text = "Back";
                btnPricesFireEscape.Text = "Fire Escape";
                labelPrices.Text = "Travel && Parking - Prices";
                btnAccessabilityPrices.Text = "Accessability";
                btnAccessabilityStore.Text = "Accessability";
                btnAccessabilityLanguages.Text = "Accessability";
                richTextBoxStore.Text = "All shops clost at:\r\nMonday - 9am - 7pm\r\nTuesday - 9am - 7pm\r\nWednesday - 9am - 7pm\r\nThursday - 9am - 7pm\r\nFriday - 9am - 7pm\r\nSaturday - 9am - 8pm\r\nSunday - 10am - 5pm\r\n\r\nAll shop icons can be clicked on to show the location on the map.";
                richTextBoxParkingPrices.Text = "Up to 30 Minutes - Free\r\nUp to 1 Hours - £1.75\r\nUp to 2 Hours - £2.50\r\nUp to 3 Hours - £3.50\r\nUp to 5 Hours - £5.00\r\nUp to 7 Hours - £7.00\r\n\r\n24 Hours Parking - £12.00\r\n72 Hours Parking - £32.00\r\n\r\nLost Ticket / Penalty Fee - £16.00\r\n\r\nAll vehicles entering the parking lots will be issued a ticket.";
                richTextBoxParking1Text.Text = "Monday - 5am - 8pm\r\nTuesday - 5am - 8pm\r\nWedensday - 5am - 8pm\r\nThursday - 5am - 8pm\r\nFriday - 5am - 8pm\r\nSaturday - 5am - 10pm\r\nSunday - 5am - 6pm\r\n\r\n14 minute walk away.";
                richTextBoxParking2.Text = "Monday - 5am - 8pm\r\nTuesday - 5am - 8pm\r\nWedensday - 5am - 8pm\r\nThursday - 5am - 8pm\r\nFriday - 5am - 8pm\r\nSaturday - 5am - 10pm\r\nSunday - 5am - 6pm\r\n\r\n2 minute walk away.";
                richTextBoxAccessability.Text = "Wheelchair exits for emergencies can be found on the fire escape page.\r\n\r\nAll shops have wheelchair and other accessability access. If you are have any issues use one of the red phones located around the shopping centre for help or call 818-927.";

            }
            else if (language == 2) //Polish - If option 1 is chosen, all the text on the Digital signs solution is set to Polish.
            {
                //Assigns everything with text on it to its assigned Polish version.
                btnSpecialOffers.Text = "Udogodnienia";
                btnParking.Text = "Podróż i Parking";
                btnStoreFinder.Text = "Wyszukiwarka sklepów";
                btnFireEscape.Text = "Wyjście ewakuacyjne";
                btnBackLanguages.Text = "Powrót";
                btnLanguage.Text = "Języki";
                lblTitle.Text = "AMAP Centrum handl";
                lblTitle2.Text = "Nottingham";
                lblFireEscape.Text = "Wyjście ewakuacy";
                richTextBoxFireEscape.Text = "Plan ewakuacyjny dla Centrum Handlowego AMAP: \n \nUżyj oznaczonych wyjść ewakuacyjnych (wejście główne, wyjścia boczne, wyjście tylne) \n \nPodążaj za zielonymi i żółtymi strzałkami na ziemi, wskazując główne i drugorzędne drogi ewakuacyjne. \n \nPunkty zbiórki znajdują się na parkingu przy wejściu głównym, po przeciwnej stronie centrum handlowego oraz z tyłu. Postępuj zgodnie z instrukcjami, unikaj wind i pomagaj innym bezpiecznie się wydostać.";
                btnBack.Text = "Powrót";
                lblLanguagesTitle.Text = "Języki";
                lblUK.Text = "Angielski";
                lblPoland.Text = "Polski";
                lblFrance.Text = "Français";
                btnStoreFinderFire.Text = "Wyjście ewakuacyjne";
                btnDisabled.Text = "Dostępność";
                textBoxSearch.Text = "Szukaj";
                btnShopsFood.Text = "Sklepy";
                btnFoodOnFoodPanel.Text = "Jedzenie";
                btnBanksFood.Text = "Banki";
                btnMapFood.Text = "Mapa";
                btnBackFood.Text = "Powrót";
                btnFireEscapeFood.Text = "Wyjście ewakuacyjne";
                labelFood.Text = "Jedzenie";
                btnAccessabilityFood.Text = "Dostępność";
                btnShopsBanks.Text = "Sklepy";
                btnFoodBanks.Text = "Jedzenie";
                btnBanksOnBanks.Text = "Banki";
                btnMapBanks.Text = "Mapa";
                btnBackBanks.Text = "Powrót";
                btnFireEscapeBanks.Text = "Wyjście ewakuacyjne";
                labelBanks.Text = "Banki";
                btnAccessabiltyBanks.Text = "Dostępność";
                btnShopsMap.Text = "Sklepy";
                btnFoodMap.Text = "Jedzenie";
                btnBanksMap.Text = "Banki";
                btnMapOnMap.Text = "Mapa";
                btnBackMap.Text = "Powrót";
                btnFireEscapeMap.Text = "Wyjście ewakuacyjne";
                labelMap.Text = "Mapa";
                btnAccessabilityMap.Text = "Dostępność";
                btnShopsOnShops.Text = "Sklepy";
                btnFoodShops.Text = "Jedzenie";
                btnBanksShops.Text = "Banki";
                btnMapShops.Text = "Mapa";
                btnBackShops.Text = "Powrót";
                btnFireEscapeShops.Text = "Wyjście ewakuacyjne";
                labelShops.Text = "Sklepy";
                btnAccessabilityShops.Text = "Dostępność";
                lblStoreFinderTitle.Text = "Sklepy";
                btnAllShops.Text = "Sklepy";
                btnFood.Text = "Jedzenie";
                btnBanks.Text = "Banki";
                btnMap.Text = "Mapa";
                btnStoreFinderFire.Text = "Wyjście ewakuacyjne";
                lblOffersTitle.Text = "Specjalne oferty";
                btnSpecialOffersBack.Text = "Powrót";
                btnSpeialOffersFire.Text = "Wyjście ewakuacyjne";
                btnLanguagesFireEscape.Text = "Wyjście ewakuacyjne";
                labelFood.Text = "Jedzenie";
                btnFoodOnFoodPanel.Text = "Jedzenie";
                btnBanksFood.Text = "Banki";
                btnMapFood.Text = "Mapa";
                btnShopsFood.Text = "Wszystkie sklepy";
                btnBackFood.Text = "Powrót";
                btnFireEscapeFood.Text = "Wyjście ewakuacyjne";
                btnAccessabilityOffers.Text = "Dostępność";
                btnPricesParking1.Text = "Ceny";
                btnParking1OnParking1.Text = "Parking 1";
                btnParking2Parking1.Text = "Parking 2";
                btnBackParking1.Text = "Powrót";
                btnFireEscapeParking1.Text = "Wyjście ewakuacyjne";
                btnAccessabilityParking1.Text = "Dostępność";
                btnPricesParking2.Text = "Ceny";
                btnParking1Parking2.Text = "Parking 1";
                btnParking2OnParking2.Text = "Parking 2";
                btnBackParking2.Text = "Powrót";
                btnFireEscapeParking2.Text = "Wyjście ewakuacyjne";
                btnAccessabilityParking2.Text = "Dostępność";
                lblAccessability.Text = "Dostępność";
                btnBackAccessability.Text = "Powrót";
                btnFireEscapeAccessability.Text = "Wyjście ewakuacyjne";
                btnLanguagesAccessability.Text = "Języki";
                btnPricesPrices.Text = "Ceny";
                btnParking1Prices.Text = "Parking 1";
                btnParkingPrices.Text = "Parking 2";
                btnBackPrices.Text = "Powrót";
                btnPricesFireEscape.Text = "Wyjście ewakuacyjne";
                labelPrices.Text = "Podróż i Parking - Ceny";
                btnAccessabilityPrices.Text = "Dostępność";
                btnAccessabilityStore.Text = "Dostępność";
                btnAccessabilityLanguages.Text = "Dostępność";
                richTextBoxStore.Text = "\r\nWszystkie sklepy zamykają o:\r\nPoniedziałek - 9:00 - 19:00\r\nWtorek - 9:00 - 19:00\r\nŚroda - 9:00 - 19:00\r\nCzwartek - 9:00 - 19:00\r\nPiątek - 9:00 - 19:00\r\nSobota - 9:00 - 20:00\r\nNiedziela - 10:00 - 17:00\r\n\r\nWszystkie ikony sklepów można kliknąć, aby pokazać ich lokalizację na mapie.";
                richTextBoxParkingPrices.Text = "Do 30 minut - Bezpłatnie\r\nDo 1 godziny - £1.75\r\nDo 2 godzin - £2.50\r\nDo 3 godzin - £3.50\r\nDo 5 godzin - £5.00\r\nDo 7 godzin - £7.00\r\n\r\nParkowanie na 24 godziny - £12.00\r\nParkowanie na 72 godziny - £32.00\r\n\r\nZagubiony bilet / Kara finansowa - £16.00\r\n\r\nWszystkie pojazdy wjeżdżające na parking otrzymają bilet.";
                richTextBoxParking1Text.Text = "\r\nPoniedziałek - 5:00 - 20:00\r\nWtorek - 5:00 - 20:00\r\nŚroda - 5:00 - 20:00\r\nCzwartek - 5:00 - 20:00\r\nPiątek - 5:00 - 20:00\r\nSobota - 5:00 - 22:00\r\nNiedziela - 5:00 - 18:00\r\n\r\nOddalone o 14 minut spacerem.";
                richTextBoxParking2.Text = "\r\nPoniedziałek - 5:00 - 20:00\r\nWtorek - 5:00 - 20:00\r\nŚroda - 5:00 - 20:00\r\nCzwartek - 5:00 - 20:00\r\nPiątek - 5:00 - 20:00\r\nSobota - 5:00 - 22:00\r\nNiedziela - 5:00 - 18:00\r\n\r\nOddalone o 2 minuty spacerem.";
                richTextBoxAccessability.Text = "Wyjścia dla wózków inwalidzkich w razie awarii można znaleźć na stronie wyjścia ewakuacyjnego.\r\n\r\nWszystkie sklepy mają dostęp dla wózków inwalidzkich i innych udogodnień dostępności. Jeśli masz jakiekolwiek problemy, skorzystaj z jednego z czerwonych telefonów znajdujących się wokół centrum handlowego, aby uzyskać pomoc lub zadzwoń pod numer 818-927.";

            }
            else if (language == 3) //French  - If option 1 is chosen, all the text on the Digital signs solution is set to French.
            {
                //Assigns everything with text on it to its assigned French version.
                btnSpecialOffers.Text = "Équipements";
                btnParking.Text = "Voyage et Parking";
                btnStoreFinder.Text = "Localisateur de magasins";
                btnFireEscape.Text = "Issue de secours";
                btnBackLanguages.Text = "Retour";
                btnLanguage.Text = "Langues";
                lblTitle.Text = "AMAP Centre commerc";
                lblTitle2.Text = "Nottingham";
                lblFireEscape.Text = "Issue de secours";
                richTextBoxFireEscape.Text = "Plan d'évacuation en cas d'incendie du centre commercial AMAP: \n \nUtilisez les issues de secours balisées(entrée principale, sorties latérales, sortie arrière) \n \nSuivez les flèches vertes et jaunes au sol indiquant les voies d'évacuation primaires et secondaires. \n \nLes points de rassemblement sont situés sur le parking près de l'entrée principale, de l'autre côté du centre commercial et à l'arrière.Suivez les instructions, évitez les ascenseurs et aidez les autres à se mettre en sécurité.";
                btnBack.Text = "Retour";
                lblLanguagesTitle.Text = "Langues";
                lblUK.Text = "Anglais";
                lblPoland.Text = "Polski";
                lblFrance.Text = "Français";
                btnStoreFinderFire.Text = "Issue de secours";
                btnDisabled.Text = "Accessibilité";
                textBoxSearch.Text = "Recherche";
                btnShopsFood.Text = "Boutiques";
                btnFoodOnFoodPanel.Text = "Restaurants";
                btnMapFood.Text = "Carte";
                btnBackFood.Text = "Retour";
                btnFireEscapeFood.Text = "Issue de secours";
                labelFood.Text = "Recherche de magasins - Restaurants";
                btnAccessabilityFood.Text = "Accessibilité";
                btnShopsBanks.Text = "Boutiques";
                btnFoodBanks.Text = "Restaurants";
                btnBanksOnBanks.Text = "Banques";
                btnMapBanks.Text = "Banques";
                btnBackBanks.Text = "Retour";
                btnFireEscapeBanks.Text = "Issue de secours";
                labelBanks.Text = "Recherche de magasins - Banques";
                btnAccessabiltyBanks.Text = "Accessibilité";
                btnShopsMap.Text = "Boutiques";
                btnFoodMap.Text = "Restaurants";
                btnBanksMap.Text = "Banques";
                btnMapOnMap.Text = "Carte";
                btnBackMap.Text = "Retour";
                btnFireEscapeMap.Text = "Issue de secours";
                labelMap.Text = "Recherche de magasins - Carte";
                btnAccessabilityMap.Text = "Accessibilité";
                btnShopsOnShops.Text = "Boutiques";
                btnFoodShops.Text = "Restaurants";
                btnBanksShops.Text = "Banques";
                btnMapShops.Text = "Carte";
                btnBackShops.Text = "Retour";
                btnFireEscapeShops.Text = "Issue de secours";
                labelShops.Text = "Recherche de magasins - Boutiques";
                btnAccessabilityShops.Text = "Accessibilité";
                lblStoreFinderTitle.Text = "Recherche de magasins";
                btnAllShops.Text = "Toutes les boutiques";
                btnFood.Text = "Restaurants";
                btnBanks.Text = "Banques";
                btnMap.Text = "Carte";
                btnStoreFinderFire.Text = "Issue de secours";
                lblOffersTitle.Text = "Offres spéciales";
                btnSpecialOffersBack.Text = "Retour";
                btnSpeialOffersFire.Text = "Issue de secours";
                btnLanguagesFireEscape.Text = "Issue de secours";
                labelFood.Text = "Recherche de magasins - Restaurants";
                btnFoodOnFoodPanel.Text = "Restaurants";
                btnBanksFood.Text = "Banques";
                btnMapFood.Text = "Carte";
                btnShopsFood.Text = "Toutes les boutiques";
                btnBackFood.Text = "Retour";
                btnFireEscapeFood.Text = "Issue de secours";
                btnAccessabilityOffers.Text = "Accessibilité";
                btnPricesParking1.Text = "Tarifs";
                btnParking1OnParking1.Text = "Parking 1";
                btnParking2Parking1.Text = "Parking 2";
                btnBackParking1.Text = "Retour";
                btnFireEscapeParking1.Text = "Issue de secours";
                btnAccessabilityParking1.Text = "Accessibilité";
                btnPricesParking2.Text = "Tarifs";
                btnParking1Parking2.Text = "Parking 1";
                btnParking2OnParking2.Text = "Parking 2";
                btnBackParking2.Text = "Retour";
                btnFireEscapeParking2.Text = "Issue de secours";
                btnAccessabilityParking2.Text = "Accessibilité";
                lblAccessability.Text = "Accessibilité";
                btnBackAccessability.Text = "Retour";
                btnFireEscapeAccessability.Text = "Issue de secours";
                btnLanguagesAccessability.Text = "Langues";
                btnPricesPrices.Text = "Tarifs";
                btnParking1Prices.Text = "Parking 1";
                btnParkingPrices.Text = "Parking 2";
                btnBackPrices.Text = "Retour";
                btnPricesFireEscape.Text = "Issue de secours";
                labelPrices.Text = "Voyage et parking - Tarifs";
                btnAccessabilityPrices.Text = "Accessibilité";
                btnAccessabilityStore.Text = "Accessibilité";
                btnAccessabilityLanguages.Text = "Accessibilité";
                richTextBoxStore.Text = "Toutes les boutiques ferment à :\r\nLundi - 9h - 19h\r\nMardi - 9h - 19h\r\nMercredi - 9h - 19h\r\nJeudi - 9h - 19h\r\nVendredi - 9h - 19h\r\nSamedi - 9h - 20h\r\nDimanche - 10h - 17h\r\n\r\nTous les icônes de boutique peuvent être cliqués pour afficher l'emplacement sur la carte.";
                richTextBoxParkingPrices.Text = "Jusqu'à 30 minutes - Gratuit\r\nJusqu'à 1 heure - £1.75\r\nJusqu'à 2 heures - £2.50\r\nJusqu'à 3 heures - £3.50\r\nJusqu'à 5 heures - £5.00\r\nJusqu'à 7 heures - £7.00\r\n\r\nParking de 24 heures - £12.00\r\nParking de 72 heures - £32.00\r\n\r\nBillet perdu / Frais de pénalité - £16.00\r\n\r\nTous les véhicules entrant dans les parkings recevront un ticket.";
                richTextBoxParking1Text.Text = "Lundi - 5h - 20h\r\nMardi - 5h - 20h\r\nMercredi - 5h - 20h\r\nJeudi - 5h - 20h\r\nVendredi - 5h - 20h\r\nSamedi - 5h - 22h\r\nDimanche - 5h - 18h\r\n\r\nÀ 14 minutes à pied.";
                richTextBoxParking2.Text = "Lundi - 5h - 20h\r\nMardi - 5h - 20h\r\nMercredi - 5h - 20h\r\nJeudi - 5h - 20h\r\nVendredi - 5h - 20h\r\nSamedi - 5h - 22h\r\nDimanche - 5h - 18h\r\n\r\nÀ 2 minutes à pied.";
                richTextBoxAccessability.Text = "Les sorties pour les fauteuils roulants en cas d'urgence se trouvent sur la page des sorties de secours.\r\n\r\nToutes les boutiques sont accessibles en fauteuil roulant et disposent d'autres facilités d'accessibilité. Si vous rencontrez des problèmes, utilisez l'un des téléphones rouges situés dans le centre commercial pour obtenir de l'aide ou appelez le 818-927.";
            }
        }

        //Changes the color of the current language selected on the language panel to gold.
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

        //A region for all the code for the map pointers when the user clicks on the shop icons.
        #region MapPointers
        private void pictureBoxAccessorize_Click(object sender, EventArgs e)
        {
            ArrowPictureBox.Location = new Point(278, 271); //If the image is clicked it will change the tab to the map panel and put the arrow pointer in it's assigned position.
            ChangeTab(panelMap);
        }

        private void pictureBoxBoots_Click(object sender, EventArgs e)
        {
            ArrowPictureBox.Location = new Point(380, 123); //If the image is clicked it will change the tab to the map panel and put the arrow pointer in it's assigned position.
            ChangeTab(panelMap);
        }

        private void pictureBoxClarks_Click(object sender, EventArgs e)
        {
            ArrowPictureBox.Location = new Point(500, 283); //If the image is clicked it will change the tab to the map panel and put the arrow pointer in it's assigned position.
            ChangeTab(panelMap);
        }

        private void pictureBoxJDSports_Click(object sender, EventArgs e)
        {
            ArrowPictureBox.Location = new Point(316, 224); //If the image is clicked it will change the tab to the map panel and put the arrow pointer in it's assigned position.
            ChangeTab(panelMap);
        }

        private void pictureBoxLush_Click(object sender, EventArgs e)
        {
            ArrowPictureBox.Location = new Point(421, 263); //If the image is clicked it will change the tab to the map panel and put the arrow pointer in it's assigned position.
            ChangeTab(panelMap);
        }

        private void pictureBoxHAndMPicture_Click(object sender, EventArgs e)
        {
            ArrowPictureBox.Location = new Point(311, 160); //If the image is clicked it will change the tab to the map panel and put the arrow pointer in it's assigned position.
            ChangeTab(panelMap);
        }

        private void pictureBoxNewLookPicture_Click(object sender, EventArgs e)
        {
            ArrowPictureBox.Location = new Point(458, 120); //If the image is clicked it will change the tab to the map panel and put the arrow pointer in it's assigned position.
            ChangeTab(panelMap);
        }

        private void pictureBoxRiverIslandPicture_Click(object sender, EventArgs e)
        {
            ArrowPictureBox.Location = new Point(268, 113); //If the image is clicked it will change the tab to the map panel and put the arrow pointer in it's assigned position.
            ChangeTab(panelMap); 
        }

        private void pictureBoxSuperdryPicture_Click(object sender, EventArgs e)
        {
            ArrowPictureBox.Location = new Point(308, 113); //If the image is clicked it will change the tab to the map panel and put the arrow pointer in it's assigned position.
            ChangeTab(panelMap);
        }

        private void pictureBoxTKMaxx_Click(object sender, EventArgs e)
        {
            ArrowPictureBox.Location = new Point(458, 52); //If the image is clicked it will change the tab to the map panel and put the arrow pointer in it's assigned position.
            ChangeTab(panelMap);
        }

        private void pictureBoxTedBaker_Click(object sender, EventArgs e)
        {
            ArrowPictureBox.Location = new Point(369, 55); //If the image is clicked it will change the tab to the map panel and put the arrow pointer in it's assigned position.
            ChangeTab(panelMap);
        }

        private void pictureBoxWHSmith_Click(object sender, EventArgs e)
        {
            ArrowPictureBox.Location = new Point(406, 55); //If the image is clicked it will change the tab to the map panel and put the arrow pointer in it's assigned position.
            ChangeTab(panelMap);
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            ArrowPictureBox.Location = new Point(284, 61); //If the image is clicked it will change the tab to the map panel and put the arrow pointer in it's assigned position.
            ChangeTab(panelMap);
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            ArrowPictureBox.Location = new Point(230, 224); //If the image is clicked it will change the tab to the map panel and put the arrow pointer in it's assigned position.
            ChangeTab(panelMap);
        }

        private void pictureBox22_Click(object sender, EventArgs e)
        {
            ArrowPictureBox.Location = new Point(230, 126); //If the image is clicked it will change the tab to the map panel and put the arrow pointer in it's assigned position.
            ChangeTab(panelMap);
        }

        private void pictureBox27_Click(object sender, EventArgs e)
        {
            ArrowPictureBox.Location = new Point(445, 177); //If the image is clicked it will change the tab to the map panel and put the arrow pointer in it's assigned position.
            ChangeTab(panelMap);
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            ArrowPictureBox.Location = new Point(230, 183); //If the image is clicked it will change the tab to the map panel and put the arrow pointer in it's assigned position.
            ChangeTab(panelMap);
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            ArrowPictureBox.Location = new Point(278, 224); //If the image is clicked it will change the tab to the map panel and put the arrow pointer in it's assigned position.
            ChangeTab(panelMap);
        }

        private void pictureBox17_Click(object sender, EventArgs e)
        {
            ArrowPictureBox.Location = new Point(420, 317); //If the image is clicked it will change the tab to the map panel and put the arrow pointer in it's assigned position.
            ChangeTab(panelMap);
        }
        #endregion

        //A region for all the code for the search function on the digital signs solution.
        #region Search
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //All the keywords that the user can search.
            string[] locations = { "store", "offers", "travel", "parking", "languages", "fire", "escape", "shop", "food", "bank", "map", "acces", "disab" };

            try
            {
                if (locations.Contains(textBoxSearch.Text.ToLower())) //Converts the users search to lowercase.
                {
                    switch (textBoxSearch.Text.ToLower())
                    {
                        case "store":
                            ChangeTab(panelStoreFinder);
                            break;
                        case "offers":
                            ChangeTab(panelSpecialOffers);
                            break;
                        case "travel":
                        case "parking":
                            ChangeTab(panelParkingPrices);
                            break;
                        case "languages":
                            ChangeTab(LanguagePanel);
                            break;
                        case "fire":
                        case "escape":
                            ChangeTab(FireEscapePanel);
                            break;
                        case "shop":
                            ChangeTab(panelAllShops);
                            break;
                        case "food":
                            ChangeTab(panelFood);
                            break;
                        case "bank":
                            ChangeTab(panelBanks);
                            break;
                        case "map":
                            ChangeTab(panelMap);
                            break;
                        case "acces":
                            ChangeTab(panelAccessability);
                            break;
                        case "disab":
                            ChangeTab(panelAccessability);
                            break;
                    }
                }
            }
            catch { }
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            textBoxSearch.Text = "";
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            textBoxSearch.Text = "Search";
        }
        #endregion

        //A region for all the buttons in the Digital Signs Solution.
        #region AllButtonPanelChangers
        private void btnStoreFinder_Click(object sender, EventArgs e)//Store Finder button.
        {
            ChangeTab(panelStoreFinder);
        }

        private void btnAmmenities_Click(object sender, EventArgs e)//Special Offers button.
        {
            ChangeTab(panelSpecialOffers);
        }

        private void btnParking_Click(object sender, EventArgs e) //Parking & Travel button.
        {
            ChangeTab(panelParkingPrices);
        }
        private void btnDisabled_Click(object sender, EventArgs e) //Accessibility button.
        {
            ChangeTab(panelAccessability);
        }

        private void btnBack_Click(object sender, EventArgs e) //Back button.
        {
            ChangeTab(MenuPanel);
        }

        private void btnFireEscape_Click(object sender, EventArgs e) //Fire escape button.
        {
            ChangeTab(FireEscapePanel);
        }

        private void btnLanguage_Click(object sender, EventArgs e) //Language button.
        {
            ChangeTab(LanguagePanel);
        }

        private void btnShops_Click(object sender, EventArgs e) //All Shops button.
        {
            ChangeTab(panelAllShops);
        }

        private void btnFood_Click(object sender, EventArgs e) //Food button
        {
            ChangeTab(panelFood);
        }

        private void btnBanks_Click(object sender, EventArgs e) //Banks button
        {
            ChangeTab(panelBanks);
        }

        private void btnMap_Click(object sender, EventArgs e) //Map button
        {
            ChangeTab(panelMap);
        }

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
    }
}
