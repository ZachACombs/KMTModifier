using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KMT;

namespace KMTModifier
{
    public partial class Form_CharVeh : Form
    {
        DialogResult result = DialogResult.Cancel;

        public KmtCharacter Character = KmtCharacter.Mario;
        public KmtVehicle Vehicle = KmtVehicle.StandardKartM;

        int currentpage = 0;
        List<Panel> pages = new List<Panel>();

        int vehicleclass = 0; //0=Small; 1=Med; 2=Large;

        const int padding_x = 12;
        const int padding_y = 9;

        Dictionary<RadioButton, CharacterSize> buttonscharacters =
            new Dictionary<RadioButton, CharacterSize>();
        Dictionary<RadioButton, KeyValuePair<string[], KmtVehicle[]>> buttonsvehicles =
                new Dictionary<RadioButton, KeyValuePair<string[], KmtVehicle[]>>();

        public Form_CharVeh(KmtCharacter selectedchar, KmtVehicle selectedveh)
        {
            InitializeComponent();
            Character = selectedchar;

            int max_width = 0;
            int max_height = 0;
            void UpdateMax(int width, int height)
            {
                if (max_width < (width + padding_x * 2))
                    max_width = width + padding_x * 2;
                if (max_height < (height + padding_y * 2))
                    max_height = height + padding_y * 2;
            }

            #region Page 1
            Panel page1 = new Panel();
            pages.Add(page1);

            const int char_width = 125;
            const int char_height = 18;
            const int char_gap_width = 6;
            const int char_gap_height = 6;

            List<Dictionary<string, CharacterSize>> charrows = 
                new List<Dictionary<string, CharacterSize>>();
            #region Define Characters
            Dictionary<string, CharacterSize> characters;
            characters = new Dictionary<string, CharacterSize>();
            characters.Add("Baby Mario", new CharacterSize(KmtCharacter.BabyMario, 0));
            characters.Add("Baby Luigi", new CharacterSize(KmtCharacter.BabyLuigi, 0));
            characters.Add("Baby Peach", new CharacterSize(KmtCharacter.BabyPeach, 0));
            characters.Add("Baby Daisy", new CharacterSize(KmtCharacter.BabyDaisy, 0));
            charrows.Add(characters);

            characters = new Dictionary<string, CharacterSize>();
            characters.Add("Toad", new CharacterSize(KmtCharacter.Toad, 0));
            characters.Add("Toadette", new CharacterSize(KmtCharacter.Toadette, 0));
            characters.Add("Koopa Troopa", new CharacterSize(KmtCharacter.Koopa, 0));
            characters.Add("Dry Bones", new CharacterSize(KmtCharacter.DryBones, 0));
            charrows.Add(characters);

            characters = new Dictionary<string, CharacterSize>();
            characters.Add("Mario", new CharacterSize(KmtCharacter.Mario, 1));
            characters.Add("Luigi", new CharacterSize(KmtCharacter.Luigi, 1));
            characters.Add("Peach", new CharacterSize(KmtCharacter.Peach, 1));
            characters.Add("Daisy", new CharacterSize(KmtCharacter.Daisy, 1));
            charrows.Add(characters);

            characters = new Dictionary<string, CharacterSize>();
            characters.Add("Yoshi", new CharacterSize(KmtCharacter.Yoshi, 1));
            characters.Add("Birdo", new CharacterSize(KmtCharacter.Birdo, 1));
            characters.Add("Diddy Kong", new CharacterSize(KmtCharacter.DiddyKong, 1));
            characters.Add("Bowser Jr.", new CharacterSize(KmtCharacter.BowserJr, 1));
            charrows.Add(characters);

            characters = new Dictionary<string, CharacterSize>();
            characters.Add("Wario", new CharacterSize(KmtCharacter.Wario, 2));
            characters.Add("Waluigi", new CharacterSize(KmtCharacter.Waluigi, 2));
            characters.Add("Donkey Kong", new CharacterSize(KmtCharacter.DonkeyKong, 2));
            characters.Add("Bowser", new CharacterSize(KmtCharacter.Bowser, 2));
            charrows.Add(characters);

            characters = new Dictionary<string, CharacterSize>();
            characters.Add("King Boo", new CharacterSize(KmtCharacter.KingBoo, 2));
            characters.Add("Rosalina", new CharacterSize(KmtCharacter.Rosalina, 2));
            characters.Add("Funky Kong", new CharacterSize(KmtCharacter.FunkyKong, 2));
            characters.Add("Dry Bowser", new CharacterSize(KmtCharacter.DryBowser, 2));
            charrows.Add(characters);

            characters = new Dictionary<string, CharacterSize>();
            characters.Add("S Mii A M", new CharacterSize(KmtCharacter.SMiiAM, 0));
            characters.Add("S Mii A F", new CharacterSize(KmtCharacter.SMiiAF, 0));
            characters.Add("S Mii B M", new CharacterSize(KmtCharacter.SMiiBM, 0));
            characters.Add("S Mii B F", new CharacterSize(KmtCharacter.SMiiBF, 0));
            charrows.Add(characters);

            characters = new Dictionary<string, CharacterSize>();
            characters.Add("S Mii C M", new CharacterSize(KmtCharacter.SMiiCM, 0));
            characters.Add("S Mii C F", new CharacterSize(KmtCharacter.SMiiCF, 0));
            characters.Add("S Mii", new CharacterSize(KmtCharacter.SMii, 0));
            charrows.Add(characters);

            characters = new Dictionary<string, CharacterSize>();
            characters.Add("M Mii A M", new CharacterSize(KmtCharacter.MMiiAM, 1));
            characters.Add("M Mii A F", new CharacterSize(KmtCharacter.MMiiAF, 1));
            characters.Add("M Mii B M", new CharacterSize(KmtCharacter.MMiiBM, 1));
            characters.Add("M Mii B F", new CharacterSize(KmtCharacter.MMiiBF, 1));
            charrows.Add(characters);

            characters = new Dictionary<string, CharacterSize>();
            characters.Add("M Mii C M", new CharacterSize(KmtCharacter.MMiiCM, 1));
            characters.Add("M Mii C F", new CharacterSize(KmtCharacter.MMiiCF, 1));
            characters.Add("M Mii", new CharacterSize(KmtCharacter.MMii, 1));
            charrows.Add(characters);

            characters = new Dictionary<string, CharacterSize>();
            characters.Add("L Mii A M", new CharacterSize(KmtCharacter.LMiiAM, 2));
            characters.Add("L Mii A F", new CharacterSize(KmtCharacter.LMiiAF, 2));
            characters.Add("L Mii B M", new CharacterSize(KmtCharacter.LMiiBM, 2));
            characters.Add("L Mii B F", new CharacterSize(KmtCharacter.LMiiBF, 2));
            charrows.Add(characters);

            characters = new Dictionary<string, CharacterSize>();
            characters.Add("L Mii C M", new CharacterSize(KmtCharacter.LMiiCM, 2));
            characters.Add("L Mii C F", new CharacterSize(KmtCharacter.LMiiCF, 2));
            characters.Add("L Mii", new CharacterSize(KmtCharacter.LMii, 2));
            charrows.Add(characters);
            #endregion

            int char_newwidth = 0;
            int char_newheight = 0;
            RadioButton char_firstbutton = null;
            bool char_isfirstbutton = false;
            bool char_oneischecked = false;
            for (int y = 0; y < charrows.Count; y += 1)
            {
                Dictionary<string, CharacterSize> charrow =
                    charrows[y];
                if (y > 0) char_newheight += char_gap_height;
                int offset_x = 0;
                string[] charnames = charrow.Keys.ToArray();
                for (int x = 0; x < charrow.Count; x += 1)
                {
                    string name = charnames[x];
                    KmtCharacter charr = charrow[name].Character;
                    int csize = charrow[name].Size;
                    if (x > 0) offset_x += char_gap_width;
                    RadioButton button = new RadioButton();
                    buttonscharacters.Add(button, new CharacterSize(charr, csize));
                    if (char_isfirstbutton)
                    {
                        char_firstbutton = button;
                        char_isfirstbutton = false;
                    }
                    button.AutoSize = false;
                    button.Location = new Point(offset_x, char_newheight);
                    button.Size = new Size(char_width, char_height);
                    button.Text = name;
                    void ButtonClicked(object sender, EventArgs e)
                    {
                        if (button.Checked)
                        {
                            Character = buttonscharacters[button].Character;
                            vehicleclass = buttonscharacters[button].Size;
                        }
                    }
                    button.CheckedChanged += new EventHandler(ButtonClicked);
                    if (charr == Character)
                    {
                        char_oneischecked = true;
                        button.Checked = true;
                    }
                    page1.Controls.Add(button);
                    offset_x += char_width;
                }
                if (char_newwidth < offset_x) char_newwidth = offset_x;
                char_newheight += char_height;
            }
            if (!char_oneischecked & char_firstbutton != null)
            {
                char_firstbutton.Checked = true;
            }
            page1.Size = new Size(char_newwidth, char_newheight);


            UpdateMax(page1.Width, page1.Height);
            #endregion

            #region Page 2
            Panel page2 = new Panel();
            pages.Add(page2);

            const int veh_width = 125;
            const int veh_height = 18;
            const int veh_gap_width = 6;
            const int veh_gap_height = 6;

            List<Dictionary<string[], KmtVehicle[]>> vehrows =
                new List<Dictionary<string[], KmtVehicle[]>>();
            #region Define Vehicles
            Dictionary<string[], KmtVehicle[]> vehicles;
            KeyValuePair<string[], KmtVehicle[]> veh_kvp;
            KeyValuePair<string[], KmtVehicle[]> vehicle_KVP(
                string name_1, KmtVehicle code_1,
                string name_2, KmtVehicle code_2,
                string name_3, KmtVehicle code_3)
            {
                string[] vehicle_name = new string[3];
                KmtVehicle[] vehicle_code = new KmtVehicle[3];
                vehicle_name[0] = name_1; vehicle_code[0] = code_1;
                vehicle_name[1] = name_2; vehicle_code[1] = code_2;
                vehicle_name[2] = name_3; vehicle_code[2] = code_3;
                return new KeyValuePair<string[], KmtVehicle[]>
                    (vehicle_name, vehicle_code);
            }

            vehicles = new Dictionary<string[], KmtVehicle[]>();
            veh_kvp = vehicle_KVP(
                "Standard Kart S", KmtVehicle.StandardKartS,
                "Standard Kart M", KmtVehicle.StandardKartM,
                "Standard Kart L", KmtVehicle.StandardKartL);
            vehicles.Add(veh_kvp.Key, veh_kvp.Value);
            veh_kvp = vehicle_KVP(
                "Standard Bike S", KmtVehicle.StandardBikeS,
                "Standard Bike M", KmtVehicle.StandardBikeM,
                "Standard Bike L", KmtVehicle.StandardBikeL);
            vehicles.Add(veh_kvp.Key, veh_kvp.Value);
            vehrows.Add(vehicles);

            vehicles = new Dictionary<string[], KmtVehicle[]>();
            veh_kvp = vehicle_KVP(
                "Booster Seat", KmtVehicle.BoosterSeat,
                "Classic Dragster", KmtVehicle.ClassicDragster,
                "Offroader", KmtVehicle.Offroader);
            vehicles.Add(veh_kvp.Key, veh_kvp.Value);
            veh_kvp = vehicle_KVP(
                "Bullet Bike", KmtVehicle.BulletBike,
                "Mach Bike", KmtVehicle.MachBike,
                "Flame Runner", KmtVehicle.FlameRunner);
            vehicles.Add(veh_kvp.Key, veh_kvp.Value);
            vehrows.Add(vehicles);

            vehicles = new Dictionary<string[], KmtVehicle[]>();
            veh_kvp = vehicle_KVP(
                "Mini Beast", KmtVehicle.MiniBeast,
                "Wild Wing", KmtVehicle.WildWing,
                "Flame Flyer", KmtVehicle.FlameFlyer);
            vehicles.Add(veh_kvp.Key, veh_kvp.Value);
            veh_kvp = vehicle_KVP(
                "Bit Bike", KmtVehicle.BitBike,
                "Sugarscoot", KmtVehicle.Sugarscoot,
                "Wario Bike", KmtVehicle.WarioBike);
            vehicles.Add(veh_kvp.Key, veh_kvp.Value);
            vehrows.Add(vehicles);

            vehicles = new Dictionary<string[], KmtVehicle[]>();
            veh_kvp = vehicle_KVP(
                "Cheep Charger", KmtVehicle.CheepCharger,
                "Super Blooper", KmtVehicle.SuperBlooper,
                "Piranha Prowler", KmtVehicle.PiranhaProwler);
            vehicles.Add(veh_kvp.Key, veh_kvp.Value);
            veh_kvp = vehicle_KVP(
                "Quacker", KmtVehicle.Quacker,
                "Zip Zip", KmtVehicle.ZipZip,
                "Shooting Star", KmtVehicle.ShootingStar);
            vehicles.Add(veh_kvp.Key, veh_kvp.Value);
            vehrows.Add(vehicles);

            vehicles = new Dictionary<string[], KmtVehicle[]>();
            veh_kvp = vehicle_KVP(
                "Tiny Titan", KmtVehicle.TinyTitan,
                "Daytripper", KmtVehicle.Daytripper,
                "Jetsetter", KmtVehicle.Jetsetter);
            vehicles.Add(veh_kvp.Key, veh_kvp.Value);
            veh_kvp = vehicle_KVP(
                "Magikruiser", KmtVehicle.Magikruiser,
                "Sneakster", KmtVehicle.Sneakster,
                "Spear", KmtVehicle.Spear);
            vehicles.Add(veh_kvp.Key, veh_kvp.Value);
            vehrows.Add(vehicles);

            vehicles = new Dictionary<string[], KmtVehicle[]>();
            veh_kvp = vehicle_KVP(
                "Blue Falcon", KmtVehicle.BlueFalcon,
                "Sprinter", KmtVehicle.Sprinter,
                "Honeycoupe", KmtVehicle.Honeycoupe);
            vehicles.Add(veh_kvp.Key, veh_kvp.Value);
            veh_kvp = vehicle_KVP(
                "Jet Bubble", KmtVehicle.JetBubble,
                "Dolphin Dasher", KmtVehicle.DolphinDasher,
                "Phantom", KmtVehicle.Phantom);
            vehicles.Add(veh_kvp.Key, veh_kvp.Value);
            vehrows.Add(vehicles);
            #endregion

            int veh_newwidth = 0;
            int veh_newheight = 0;
            RadioButton veh_firstbutton = null;
            bool veh_isfirstbutton = false;
            bool veh_oneischecked = false;
            for (int y = 0; y < vehrows.Count; y += 1)
            {
                Dictionary<string[], KmtVehicle[]> vehrow =
                    vehrows[y];
                if (y > 0) veh_newheight += veh_gap_height;
                int offset_x = 0;
                int x = 0;
                foreach (KeyValuePair<string[], KmtVehicle[]> kvp 
                    in vehrow)
                {
                    RadioButton button = new RadioButton();
                    buttonsvehicles.Add(button, kvp);

                    if (veh_isfirstbutton)
                    {
                        veh_firstbutton = button;
                        veh_isfirstbutton = false;
                    }
                    button.AutoSize = false;
                    button.Location = new Point(offset_x, veh_newheight);
                    button.Size = new Size(veh_width, veh_height);
                    void ButtonClicked(object sender, EventArgs e)
                    {
                        if (button.Checked)
                        {
                            KeyValuePair<string[], KmtVehicle[]> kmtveh = 
                                (buttonsvehicles[button]);
                            Vehicle = kmtveh.Value[vehicleclass];
                        }
                    }
                    button.CheckedChanged += new EventHandler(ButtonClicked);
                    if (Array.IndexOf(kvp.Value, selectedveh) >= 0)
                    {
                        Vehicle = selectedveh;
                        veh_oneischecked = true;
                        button.Checked = true;
                    }

                    page2.Controls.Add(button);
                    offset_x += veh_width;

                    x += 1;
                }
                if (veh_newwidth < offset_x) veh_newwidth = offset_x;
                veh_newheight += veh_height;
            }
            if (!veh_oneischecked & veh_firstbutton != null)
            {
                veh_firstbutton.Checked = true;
            }
            page2.Size = new Size(veh_newwidth, veh_newheight);

            UpdateMax(page2.Width, page2.Height);
            #endregion

            p_CharVeh.Size = new Size(max_width, max_height);
            flp_CharVeh.MaximumSize = new Size(p_CharVeh.Width, 0);

            Display_Page_1();
        }

        void displaypage(int page)
        {
            p_CharVeh.Controls.Clear();
            currentpage = page;
            Panel gotopage = pages[page];
            int x = (p_CharVeh.Width / 2) - (gotopage.Width / 2);
            int y = (p_CharVeh.Height / 2) - (gotopage.Height / 2);
            gotopage.Location = new Point(x, y);
            p_CharVeh.Controls.Add(gotopage);
        }
        void Display_Page_1()
        {
            displaypage(0);

            Text = "Select Character";
            b_PrevNext.Text = "Next";
            b_Finish.Visible = false;

        }
        void Display_Page_2()
        {
            foreach (KeyValuePair<RadioButton, KeyValuePair<string[], KmtVehicle[]>>
                kvp in buttonsvehicles)
            {
                kvp.Key.Text=kvp.Value.Key[vehicleclass];
                if (kvp.Key.Checked)
                {
                    Vehicle = kvp.Value.Value[vehicleclass];
                }
            }

            displaypage(1);

            b_PrevNext.Text = "Prev";
            b_Finish.Visible = true;
        }

        private void b_Finish_Click(object sender, EventArgs e)
        {
            result = DialogResult.OK;
            Close();
        }

        private void Form_CharVeh_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult = result;
        }

        private void b_PrevNext_Click(object sender, EventArgs e)
        {
            if (currentpage == 0)
            {
                Display_Page_2();
            }
            else if (currentpage == 1)
            {
                Display_Page_1();
            }
        }
    }
    class CharacterSize
    {
        public KmtCharacter Character;
        public int Size; //0=Small; 1=Medium; 2=Large

        public CharacterSize(KmtCharacter character, int size)
        {
            Character = character;
            Size = size;
        }
    }
}
