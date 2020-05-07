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
    public partial class Form_Course : Form
    {
        DialogResult result = DialogResult.Cancel;

        public KmtCourse Course = KmtCourse.MarioCircuit;

        const int padding_x = 12;
        const int padding_y = 9;

        const int cup_width = 150;
        const int cup_gap_width = 6;
        const int cup_gap_height = 12;
        const int cup_title_height = 20;
        const int cup_titlecourse_gap_height = 3;
        const int cup_course_height = 18;
        const int cup_course_gap_height = 6;

        Dictionary<RadioButton, KmtCourse> buttoncourse =
            new Dictionary<RadioButton, KmtCourse>();

        public Form_Course(KmtCourse selectedcourse)
        {
            InitializeComponent();
            Course = selectedcourse;
            KeyValuePair<string, KmtCourse> NameCourse(
                string name, KmtCourse course)
            {
                KeyValuePair<string, KmtCourse> namecourse =
                    new KeyValuePair<string, KmtCourse>
                    (name, course);
                return namecourse;
            }
            CupCourses[] cupscourses =
            {
                new CupCourses("Mushroom Cup",
                    NameCourse("Luigi Circuit", KmtCourse.LuigiCircuit),
                    NameCourse("Moo Moo Meadows", KmtCourse.MooMooMeadows),
                    NameCourse("Mushrooom Gorge", KmtCourse.MushroomGorge),
                    NameCourse("Toad's Factory", KmtCourse.ToadsFactory)
                    ),
                new CupCourses("Flower Cup",
                    NameCourse("Mario Circuit", KmtCourse.MarioCircuit),
                    NameCourse("Coconut Mall", KmtCourse.CoconutMall),
                    NameCourse("DK Summit", KmtCourse.DKSummit),
                    NameCourse("Wario's Gold Mine", KmtCourse.WariosGoldMine)
                    ),
                new CupCourses("Star Cup",
                    NameCourse("Daisy Circuit", KmtCourse.DaisyCircuit),
                    NameCourse("Koopa Cape", KmtCourse.KoopaCape),
                    NameCourse("Maple Treeway", KmtCourse.MapleTreeway),
                    NameCourse("Grumble Volcano", KmtCourse.GrumbleVolcano)
                    ),
                new CupCourses("Special Cup",
                    NameCourse("Dry Dry Ruins", KmtCourse.DryDryRuins),
                    NameCourse("Moonview Highway", KmtCourse.MoonviewHighway),
                    NameCourse("Bowser's Castle", KmtCourse.BowsersCastle),
                    NameCourse("Rainbow Road", KmtCourse.RainbowRoad)
                    ),
                new CupCourses("Shell Cup",
                    NameCourse("GCN Peach Beach", KmtCourse.GCNPeachBeach),
                    NameCourse("DS Yoshi Falls", KmtCourse.DSYoshiFalls),
                    NameCourse("SNES Ghost Valley 2", KmtCourse.SNESGhostValley2),
                    NameCourse("N64 Mario Raceway", KmtCourse.N64MarioRaceway)
                    ),
                new CupCourses("Banana Cup",
                    NameCourse("N64 Sherbet Land", KmtCourse.N64SherbetLand),
                    NameCourse("GBA Shy Guy Beach", KmtCourse.GBAShyGuyBeach),
                    NameCourse("DS Delfino Square", KmtCourse.DSDelfinoSquare),
                    NameCourse("GCN Waluigi Stadium", KmtCourse.GCNWaluigiStadium)
                    ),
                new CupCourses("Leaf Cup",
                    NameCourse("DS Desert Hills", KmtCourse.DSDesertHills),
                    NameCourse("GBA Bowser Castle 3", KmtCourse.GBABowserCastle3),
                    NameCourse("N64 DK Jungle Parkway", KmtCourse.N64DKJungleParkway),
                    NameCourse("GCN Mario Circuit", KmtCourse.GCNMarioCircuit)
                    ),
                new CupCourses("Lightning Cup",
                    NameCourse("SNES Mario Circuit 3", KmtCourse.SNESMarioCircuit3),
                    NameCourse("DS Peach Gardens", KmtCourse.DSPeachGardens),
                    NameCourse("GCN DK Mountain", KmtCourse.GCNDKMountain),
                    NameCourse("N64 Bowser's Castle", KmtCourse.N64BowsersCastle)
                    ),
                new CupCourses("Wii Battle Stages",
                    NameCourse("Block Plaza", KmtCourse.BlockPlaza),
                    NameCourse("Delfino Pier", KmtCourse.DelfinoPier),
                    NameCourse("Funky Stadium", KmtCourse.FunkyStadium),
                    NameCourse("Chain Chomp Wheel", KmtCourse.ChainChompWheel),
                    NameCourse("Thwomp Desert", KmtCourse.ThwompDesert)
                    ),
                new CupCourses("Retro Battle Stages",
                    NameCourse("SNES Battle Course 4", KmtCourse.SNESBattleCourse4),
                    NameCourse("GBA Battle Course 3", KmtCourse.GBABattleCourse3),
                    NameCourse("N64 Skyscraper", KmtCourse.N64Skyscraper),
                    NameCourse("GCN Cookie Land", KmtCourse.GCNCookieLand),
                    NameCourse("DS Twilight House", KmtCourse.DSTwilightHouse)
                    ),
                new CupCourses("Misc",
                    NameCourse("Galaxy Colosseum", KmtCourse.GalaxyColosseum),
                    NameCourse("winingrun_demo", KmtCourse.winingrun_demo),
                    NameCourse("loser_demo", KmtCourse.loser_demo),
                    NameCourse("draw_demo", KmtCourse.draw_demo),
                    NameCourse("ending_demo", KmtCourse.ending_demo)
                    ),
            };
            const int cupsperrow = 4;
            int width = padding_x;
            int height = padding_y;
            bool isfirstbutton = true;
            RadioButton firstbutton = null;
            bool oneischecked = false;
            for (int n = 0; n < cupscourses.Length; n += cupsperrow)
            {
                if (n > 0) height += cup_gap_height;
                int maxcupheight = 0;
                int x = padding_x;
                int rowitemcount = Math.Min(n + cupsperrow, cupscourses.Length);
                for (int m = n;
                    m < rowitemcount;
                    m += 1)
                {
                    CupCourses cupcourse = cupscourses[m];
                    int y = 0;

                    #region Cup Title
                    Label cuptitle = new Label();
                    cuptitle.AutoSize = false;
                    cuptitle.Location = new Point(x, height + y);
                    cuptitle.Size = new Size(cup_width, cup_title_height);
                    cuptitle.TextAlign = ContentAlignment.TopCenter;
                    cuptitle.Text = cupcourse.CupName;
                    cuptitle.BorderStyle = BorderStyle.FixedSingle;
                    p_Courses.Controls.Add(cuptitle);
                    #endregion

                    y = cup_title_height + cup_titlecourse_gap_height;

                    string[] coursenames = cupcourse.Courses.Keys.ToArray();
                    for (int o = 0; o < coursenames.Length; o += 1)
                    {
                        string course_name = coursenames[o];
                        KmtCourse course_course = cupcourse.Courses[course_name];
                        RadioButton button = new RadioButton();
                        buttoncourse.Add(button, course_course);
                        if (isfirstbutton)
                        {
                            firstbutton = button;
                            isfirstbutton = false;
                        }
                        button.AutoSize = false;
                        button.Location = new Point(x, height + y);
                        button.Size = new Size(cup_width, cup_course_height);
                        button.Text = course_name;
                        void ButtonClicked(object sender, EventArgs e)
                        {
                            if (button.Checked) Course = buttoncourse[button];
                        }
                        button.CheckedChanged += new EventHandler(ButtonClicked);
                        if (course_course == Course)
                        {
                            oneischecked = true;
                            button.Checked = true;
                        }
                        p_Courses.Controls.Add(button);
                        y += cup_course_height;
                        if (o < (coursenames.Length - 1)) y += cup_course_gap_height;
                    }

                    x += cup_width;
                    if (m < (rowitemcount - 1)) x += cup_gap_width;
                    if (y > maxcupheight) maxcupheight = y;
                }
                height += maxcupheight;
                if (x > width) width = x;
            }
            if (!oneischecked & firstbutton != null)
            {
                firstbutton.Checked = true;
            }
            flp_Courses.MaximumSize = new Size(width + padding_x, 0);
            p_Courses.Size = new Size(width + padding_x, height + padding_y);
        }

        private void b_OK_Click(object sender, EventArgs e)
        {
            result = DialogResult.OK;
            Close();
        }

        private void Form_Course_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult = result;
        }
    }
    class CupCourses
    {
        public string CupName;
        public Dictionary<string, KmtCourse> Courses;

        public CupCourses(string cupname,
            params KeyValuePair<string, KmtCourse>[] courses)
        {
            CupName = cupname;
            Courses = new Dictionary<string, KmtCourse>();
            foreach (KeyValuePair<string, KmtCourse> course
                in courses)
            {
                Courses.Add(course.Key, course.Value);
            }
        }
    }
}
