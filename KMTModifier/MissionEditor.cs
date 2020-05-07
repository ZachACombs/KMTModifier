using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KMT;

namespace KMTModifier
{
    public partial class MissionEditor : UserControl
    {
        private Dictionary<KmtGameMode, NameDesc> dict_gamemode = new Dictionary<KmtGameMode, NameDesc>();
        private Dictionary<KmtCourse, NameImg> dict_course = new Dictionary<KmtCourse, NameImg>();
        private Dictionary<KmtCharacter, NameImg> dict_character = new Dictionary<KmtCharacter, NameImg>();
        private Dictionary<KmtVehicle, NameImg> dict_vehicle = new Dictionary<KmtVehicle, NameImg>();
        private Dictionary<KmtEngineClass, NameImg> dict_engineclass = new Dictionary<KmtEngineClass, NameImg>();
        private Dictionary<KmtCameraMode, string> dict_cameramode = new Dictionary<KmtCameraMode, string>();
        
        public KmtEntry CurrentMission = null;

        public MissionEditor()
        {
            InitializeComponent();

            #region Dictionary Game Mode
            dict_gamemode.Add(KmtGameMode.Miniturbo, new NameDesc("Miniturbo", "Release miniturbos to score points."));
            dict_gamemode.Add(KmtGameMode.LapRun01, new NameDesc("LapRun01", "VS Mode. Complete 3 laps before time runs out."));
            dict_gamemode.Add(KmtGameMode.LapRun02, new NameDesc("LapRun02", "VS Mode. Complete 3 laps before time runs out. (Seems identical to mode LapRun01)."));
            dict_gamemode.Add(KmtGameMode.Drift, new NameDesc("Drift", "Perform any drift to score. (Faulty, increments score too quickly, Manual only)"));
            dict_gamemode.Add(KmtGameMode.ItemBox, new NameDesc("ItemBox", "Break item boxes to score points."));
            dict_gamemode.Add(KmtGameMode.EnemyDown01, new NameDesc("EnemyDown01", "Hit enemies with items to score points."));
            dict_gamemode.Add(KmtGameMode.EnemyDown02, new NameDesc("EnemyDown02", "Attack a boss to score points. (E.g. Spiky Topmen, Big Pokey, etc)"));
            dict_gamemode.Add(KmtGameMode.EnemyDown03, new NameDesc("EnemyDown03", "Unknown. (Most likely unused or deleted. A piece of text in StaticR.rel, \"EnemyDown03\" may indicate it used to be related to modes EnemyDown01 and EnemyDown02, attacking something)."));
            dict_gamemode.Add(KmtGameMode.CoinGet01, new NameDesc("CoinGet01", "Gather coins to score points."));
            dict_gamemode.Add(KmtGameMode.ToGate01, new NameDesc("ToGate01", "Drive through gates to score points."));
            dict_gamemode.Add(KmtGameMode.RocketStart, new NameDesc("RocketStart", "Perform any level of boost start to immediately win the mission. (If you miss the boost start, you can no longer win, at all)."));
            dict_gamemode.Add(KmtGameMode.ItemHit, new NameDesc("ItemHit", "Hit CPU opponents with certain items to score points. (All projectiles. Stars, Mushrooms, Mega Mushrooms and Bullet Bills do not score)."));
            dict_gamemode.Add(KmtGameMode.Wheelie, new NameDesc("Wheelie", "Perform wheelies to score. (Faulty, increments score too quickly, increments for wheelies on the spot)."));
            dict_gamemode.Add(KmtGameMode.Slipstream, new NameDesc("Slipstream", "Get slipstreams from CPU opponents to score points. (However, the score also increases if they slipstream someone, too)."));
            #endregion

            #region Dictionary Course
            dict_course.Add(KmtCourse.LuigiCircuit, new NameImg("Luigi Circuit", null));
            dict_course.Add(KmtCourse.MooMooMeadows, new NameImg("Moo Moo Meadows", null));
            dict_course.Add(KmtCourse.MushroomGorge, new NameImg("Mushroom Gorge", null));
            dict_course.Add(KmtCourse.ToadsFactory, new NameImg("Toads Factory", null));
            dict_course.Add(KmtCourse.MarioCircuit, new NameImg("Mario Circuit", null));
            dict_course.Add(KmtCourse.CoconutMall, new NameImg("Coconut Mall", null));
            dict_course.Add(KmtCourse.DKSummit, new NameImg("DK Summit", null));
            dict_course.Add(KmtCourse.WariosGoldMine, new NameImg("Warios Gold Mine", null));
            dict_course.Add(KmtCourse.DaisyCircuit, new NameImg("Daisy Circuit", null));
            dict_course.Add(KmtCourse.KoopaCape, new NameImg("Koopa Cape", null));
            dict_course.Add(KmtCourse.MapleTreeway, new NameImg("Maple Treeway", null));
            dict_course.Add(KmtCourse.GrumbleVolcano, new NameImg("Grumble Volcano", null));
            dict_course.Add(KmtCourse.DryDryRuins, new NameImg("Dry Dry Ruins", null));
            dict_course.Add(KmtCourse.MoonviewHighway, new NameImg("Moonview Highway", null));
            dict_course.Add(KmtCourse.BowsersCastle, new NameImg("Bowser's Castle", null));
            dict_course.Add(KmtCourse.RainbowRoad, new NameImg("Rainbow Road", null));
            dict_course.Add(KmtCourse.GCNPeachBeach, new NameImg("GCN Peach Beach", null));
            dict_course.Add(KmtCourse.DSYoshiFalls, new NameImg("DS Yoshi Falls", null));
            dict_course.Add(KmtCourse.SNESGhostValley2, new NameImg("SNES Ghost Valley 2", null));
            dict_course.Add(KmtCourse.N64MarioRaceway, new NameImg("N64 Mario Raceway", null));
            dict_course.Add(KmtCourse.N64SherbetLand, new NameImg("N64 Sherbet Land", null));
            dict_course.Add(KmtCourse.GBAShyGuyBeach, new NameImg("GBA Shy Guy Beach", null));
            dict_course.Add(KmtCourse.DSDelfinoSquare, new NameImg("DS Delfino Square", null));
            dict_course.Add(KmtCourse.GCNWaluigiStadium, new NameImg("GCN Waluigi Stadium", null));
            dict_course.Add(KmtCourse.DSDesertHills, new NameImg("DS Desert Hills", null));
            dict_course.Add(KmtCourse.GBABowserCastle3, new NameImg("GBA Bowser Castle 3", null));
            dict_course.Add(KmtCourse.N64DKJungleParkway, new NameImg("N64 DK Jungle Parkway", null));
            dict_course.Add(KmtCourse.GCNMarioCircuit, new NameImg("GCN Mario Circuit", null));
            dict_course.Add(KmtCourse.SNESMarioCircuit3, new NameImg("SNES Mario Circuit 3", null));
            dict_course.Add(KmtCourse.DSPeachGardens, new NameImg("DS Peach Gardens", null));
            dict_course.Add(KmtCourse.GCNDKMountain, new NameImg("GCN DK Mountain", null));
            dict_course.Add(KmtCourse.N64BowsersCastle, new NameImg("N64 Bowser's Castle", null));
            dict_course.Add(KmtCourse.BlockPlaza, new NameImg("Block Plaza", null));
            dict_course.Add(KmtCourse.DelfinoPier, new NameImg("Delfino Pier", null));
            dict_course.Add(KmtCourse.FunkyStadium, new NameImg("Funky Stadium", null));
            dict_course.Add(KmtCourse.ChainChompWheel, new NameImg("Chain Chomp Wheel", null));
            dict_course.Add(KmtCourse.ThwompDesert, new NameImg("Thwomp Desert", null));
            dict_course.Add(KmtCourse.SNESBattleCourse4, new NameImg("SNES Battle Course 4", null));
            dict_course.Add(KmtCourse.GBABattleCourse3, new NameImg("GBA Battle Course 3", null));
            dict_course.Add(KmtCourse.N64Skyscraper, new NameImg("N64 Skyscraper", null));
            dict_course.Add(KmtCourse.GCNCookieLand, new NameImg("GCN Cookie Land", null));
            dict_course.Add(KmtCourse.DSTwilightHouse, new NameImg("DS Twilight House", null));
            dict_course.Add(KmtCourse.Unknown0x2A, new NameImg("0x2A", null));
            dict_course.Add(KmtCourse.Unknown0x2B, new NameImg("0x2B", null));
            dict_course.Add(KmtCourse.Unknown0x2C, new NameImg("0x2C", null));
            dict_course.Add(KmtCourse.Unknown0x2D, new NameImg("0x2D", null));
            dict_course.Add(KmtCourse.Unknown0x2E, new NameImg("0x2E", null));
            dict_course.Add(KmtCourse.Unknown0x2F, new NameImg("0x2F", null));
            dict_course.Add(KmtCourse.Unknown0x30, new NameImg("0x30", null));
            dict_course.Add(KmtCourse.Unknown0x31, new NameImg("0x31", null));
            dict_course.Add(KmtCourse.Unknown0x32, new NameImg("0x32", null));
            dict_course.Add(KmtCourse.Unknown0x33, new NameImg("0x33", null));
            dict_course.Add(KmtCourse.Unknown0x34, new NameImg("0x34", null));
            dict_course.Add(KmtCourse.Unknown0x35, new NameImg("0x35", null));
            dict_course.Add(KmtCourse.GalaxyColosseum, new NameImg("Galaxy Colosseum", null));
            dict_course.Add(KmtCourse.winingrun_demo, new NameImg("winingrun_demo", null));
            dict_course.Add(KmtCourse.loser_demo, new NameImg("loser_demo", null));
            dict_course.Add(KmtCourse.draw_demo, new NameImg("draw_demo", null));
            dict_course.Add(KmtCourse.ending_demo, new NameImg("ending_demo", null));
            #endregion

            #region Dictionary Character
            dict_character.Add(KmtCharacter.BabyMario, new NameImg("Baby Mario", null));
            dict_character.Add(KmtCharacter.BabyLuigi, new NameImg("Baby Luigi", null));
            dict_character.Add(KmtCharacter.BabyPeach, new NameImg("Baby Peach", null));
            dict_character.Add(KmtCharacter.BabyDaisy, new NameImg("Baby Daisy", null));
            dict_character.Add(KmtCharacter.Toad, new NameImg("Toad", null));
            dict_character.Add(KmtCharacter.Toadette, new NameImg("Toadette", null));
            dict_character.Add(KmtCharacter.Koopa, new NameImg("Koopa", null));
            dict_character.Add(KmtCharacter.DryBones, new NameImg("Dry Bones", null));
            dict_character.Add(KmtCharacter.Mario, new NameImg("Mario", null));
            dict_character.Add(KmtCharacter.Luigi, new NameImg("Luigi", null));
            dict_character.Add(KmtCharacter.Peach, new NameImg("Peach", null));
            dict_character.Add(KmtCharacter.Daisy, new NameImg("Daisy", null));
            dict_character.Add(KmtCharacter.Yoshi, new NameImg("Yoshi", null));
            dict_character.Add(KmtCharacter.Birdo, new NameImg("Birdo", null));
            dict_character.Add(KmtCharacter.DiddyKong, new NameImg("Diddy Kong", null));
            dict_character.Add(KmtCharacter.BowserJr, new NameImg("Bowser Jr.", null));
            dict_character.Add(KmtCharacter.Wario, new NameImg("Wario", null));
            dict_character.Add(KmtCharacter.Waluigi, new NameImg("Waluigi", null));
            dict_character.Add(KmtCharacter.DonkeyKong, new NameImg("Donkey Kong", null));
            dict_character.Add(KmtCharacter.Bowser, new NameImg("Bowser", null));
            dict_character.Add(KmtCharacter.KingBoo, new NameImg("King Boo", null));
            dict_character.Add(KmtCharacter.Rosalina, new NameImg("Rosalina", null));
            dict_character.Add(KmtCharacter.FunkyKong, new NameImg("Funky Kong", null));
            dict_character.Add(KmtCharacter.DryBowser, new NameImg("Dry Bowser", null));
            dict_character.Add(KmtCharacter.SMiiAM, new NameImg("S Mii A M", null));
            dict_character.Add(KmtCharacter.SMiiAF, new NameImg("S Mii A F", null));
            dict_character.Add(KmtCharacter.SMiiBM, new NameImg("S Mii B M", null));
            dict_character.Add(KmtCharacter.SMiiBF, new NameImg("S Mii B F", null));
            dict_character.Add(KmtCharacter.SMiiCM, new NameImg("S Mii C M", null));
            dict_character.Add(KmtCharacter.SMiiCF, new NameImg("S Mii C F", null));
            dict_character.Add(KmtCharacter.MMiiAM, new NameImg("M Mii A M", null));
            dict_character.Add(KmtCharacter.MMiiAF, new NameImg("M Mii A F", null));
            dict_character.Add(KmtCharacter.MMiiBM, new NameImg("M Mii B M", null));
            dict_character.Add(KmtCharacter.MMiiBF, new NameImg("M Mii B F", null));
            dict_character.Add(KmtCharacter.MMiiCM, new NameImg("M Mii C M", null));
            dict_character.Add(KmtCharacter.MMiiCF, new NameImg("M Mii C F", null));
            dict_character.Add(KmtCharacter.LMiiAM, new NameImg("L Mii A M", null));
            dict_character.Add(KmtCharacter.LMiiAF, new NameImg("L Mii A F", null));
            dict_character.Add(KmtCharacter.LMiiBM, new NameImg("L Mii B M", null));
            dict_character.Add(KmtCharacter.LMiiBF, new NameImg("L Mii B F", null));
            dict_character.Add(KmtCharacter.LMiiCM, new NameImg("L Mii C M", null));
            dict_character.Add(KmtCharacter.LMiiCF, new NameImg("L Mii C F", null));
            dict_character.Add(KmtCharacter.MMii, new NameImg("M Mii", null));
            dict_character.Add(KmtCharacter.SMii, new NameImg("S Mii", null));
            dict_character.Add(KmtCharacter.LMii, new NameImg("L Mii", null));
            #endregion

            #region Dictionary Vehicle
            dict_vehicle.Add(KmtVehicle.StandardKartS, new NameImg("Standard Kart S", null));
            dict_vehicle.Add(KmtVehicle.StandardBikeS, new NameImg("Standard Bike S", null));
            dict_vehicle.Add(KmtVehicle.BoosterSeat, new NameImg("Booster Seat", null));
            dict_vehicle.Add(KmtVehicle.BulletBike, new NameImg("Bullet Bike", null));
            dict_vehicle.Add(KmtVehicle.MiniBeast, new NameImg("Mini Beast", null));
            dict_vehicle.Add(KmtVehicle.BitBike, new NameImg("Bit Bike", null));
            dict_vehicle.Add(KmtVehicle.CheepCharger, new NameImg("Cheep Charger", null));
            dict_vehicle.Add(KmtVehicle.Quacker, new NameImg("Quacker", null));
            dict_vehicle.Add(KmtVehicle.TinyTitan, new NameImg("Tiny Titan", null));
            dict_vehicle.Add(KmtVehicle.Magikruiser, new NameImg("Magikruiser", null));
            dict_vehicle.Add(KmtVehicle.BlueFalcon, new NameImg("Blue Falcon", null));
            dict_vehicle.Add(KmtVehicle.JetBubble, new NameImg("Jet Bubble", null));
            dict_vehicle.Add(KmtVehicle.StandardKartM, new NameImg("Standard Kart M", null));
            dict_vehicle.Add(KmtVehicle.StandardBikeM, new NameImg("Standard Bike M", null));
            dict_vehicle.Add(KmtVehicle.ClassicDragster, new NameImg("Classic Dragster", null));
            dict_vehicle.Add(KmtVehicle.MachBike, new NameImg("Mach Bike", null));
            dict_vehicle.Add(KmtVehicle.WildWing, new NameImg("Wild Wing", null));
            dict_vehicle.Add(KmtVehicle.Sugarscoot, new NameImg("Sugarscoot", null));
            dict_vehicle.Add(KmtVehicle.SuperBlooper, new NameImg("Super Blooper", null));
            dict_vehicle.Add(KmtVehicle.ZipZip, new NameImg("Zip Zip", null));
            dict_vehicle.Add(KmtVehicle.Daytripper, new NameImg("Daytripper", null));
            dict_vehicle.Add(KmtVehicle.Sneakster, new NameImg("Sneakster", null));
            dict_vehicle.Add(KmtVehicle.Sprinter, new NameImg("Sprinter", null));
            dict_vehicle.Add(KmtVehicle.DolphinDasher, new NameImg("Dolphin Dasher", null));
            dict_vehicle.Add(KmtVehicle.StandardKartL, new NameImg("Standard Kart L", null));
            dict_vehicle.Add(KmtVehicle.StandardBikeL, new NameImg("Standard Bike L", null));
            dict_vehicle.Add(KmtVehicle.Offroader, new NameImg("Offroader", null));
            dict_vehicle.Add(KmtVehicle.FlameRunner, new NameImg("Flame Runner", null));
            dict_vehicle.Add(KmtVehicle.FlameFlyer, new NameImg("Flame Flyer", null));
            dict_vehicle.Add(KmtVehicle.WarioBike, new NameImg("Wario Bike", null));
            dict_vehicle.Add(KmtVehicle.PiranhaProwler, new NameImg("Piranha Prowler", null));
            dict_vehicle.Add(KmtVehicle.ShootingStar, new NameImg("Shooting Star", null));
            dict_vehicle.Add(KmtVehicle.Jetsetter, new NameImg("Jetsetter", null));
            dict_vehicle.Add(KmtVehicle.Spear, new NameImg("Spear", null));
            dict_vehicle.Add(KmtVehicle.Honeycoupe, new NameImg("Honeycoupe", null));
            dict_vehicle.Add(KmtVehicle.Phantom, new NameImg("Phantom", null));
            #endregion

            #region Dictionary Engine Class
            dict_engineclass.Add(KmtEngineClass.e50cc, new NameImg("50cc", null));
            dict_engineclass.Add(KmtEngineClass.e100cc, new NameImg("100cc", null));
            dict_engineclass.Add(KmtEngineClass.e150cc, new NameImg("150cc", null));
            dict_engineclass.Add(KmtEngineClass.Battle, new NameImg("Battle", null));
            #endregion

            #region Dictionary Camera Mode
            dict_cameramode.Add(KmtCameraMode.Unknown0x0000, "0x0000");
            dict_cameramode.Add(KmtCameraMode.Unknown0x0001, "0x0001");
            dict_cameramode.Add(KmtCameraMode.Unknown0x0002, "0x0002");
            dict_cameramode.Add(KmtCameraMode.Default, "Default");
            dict_cameramode.Add(KmtCameraMode.Unknown0x0004, "0x0004");
            dict_cameramode.Add(KmtCameraMode.Unknown0x0005, "0x0005");
            dict_cameramode.Add(KmtCameraMode.Unknown0x0006, "0x0006");
            dict_cameramode.Add(KmtCameraMode.FromAbove, "From Above");
            #endregion

            foreach (KeyValuePair<KmtGameMode, NameDesc> entry in dict_gamemode)
                cb_GameMode.Items.Add(entry.Value.Name);
            foreach (KeyValuePair<KmtCourse, NameImg> entry in dict_course)
                cb_Course.Items.Add(entry.Value.Name);
            foreach (KeyValuePair<KmtCharacter, NameImg> entry in dict_character)
                cb_CharVeh_Char.Items.Add(entry.Value.Name);
            foreach (KeyValuePair<KmtVehicle, NameImg> entry in dict_vehicle)
                cb_CharVeh_Veh.Items.Add(entry.Value.Name);
            foreach (KeyValuePair<KmtEngineClass, NameImg> entry in dict_engineclass)
                cb_Class.Items.Add(entry.Value.Name);
            foreach (KeyValuePair<KmtCameraMode, string> entry in dict_cameramode)
                cb_Camera.Items.Add(entry.Value);
        }
        
        public void DisplayMission(KmtEntry mission)
        {
            CurrentMission = mission;
            Redisplay_GameMode();
            Redisplay_Course();
            Redisplay_Character();
            Redisplay_Vehicle();
            Redisplay_EngineClass();
            Redisplay_CameraMode();
            Redisplay_MissionRunFile();
            Redisplay_Time();
            Redisplay_Controller();
            Redisplay_Score();
            Redisplay_Minimap();
            Redisplay_Cannon();
            Redisplay_CPUs();
        }
        private void Redisplay_GameMode()
        {
            cb_GameMode.SelectedIndex =
                dict_gamemode.Keys.ToList().IndexOf(
                    CurrentMission.GameMode
                    );
        }
        private void Redisplay_Course()
        {
            cb_Course.SelectedIndex =
                dict_course.Keys.ToList().IndexOf(
                    CurrentMission.Course
                    );
        }
        private void Redisplay_Character()
        {
            cb_CharVeh_Char.SelectedIndex =
                dict_character.Keys.ToList().IndexOf(
                    CurrentMission.Character
                    );
        }
        private void Redisplay_Vehicle()
        {
            cb_CharVeh_Veh.SelectedIndex =
                dict_vehicle.Keys.ToList().IndexOf(
                    CurrentMission.Vehicle
                    );
        }
        private void Redisplay_EngineClass()
        {
            cb_Class.SelectedIndex =
                dict_engineclass.Keys.ToList().IndexOf(
                    CurrentMission.EngineClass
                    );
        }
        private void Redisplay_CameraMode()
        {
            cb_Camera.SelectedIndex =
                dict_cameramode.Keys.ToList().IndexOf(
                    CurrentMission.CameraMode
                    );
        }
        private void Redisplay_MissionRunFile()
        {
            tb_mrf.Text = CurrentMission.MissionRunFile.ToString();
        }
        private void Redisplay_Time()
        {
            tb_Time.Text = CurrentMission.TimeLimit.ToString();
        }
        private void Redisplay_Controller()
        {
            tb_Controller.Text = CurrentMission.ControllerRestriction.ToString();
        }
        private void Redisplay_Score()
        {
            tb_Score.Text = CurrentMission.Score.ToString();
        }
        private void Redisplay_Minimap()
        {
            tb_Minimap.Text = CurrentMission.Minimap.ToString();
        }
        private void Redisplay_Cannon()
        {
            tb_Cannon.Text = CurrentMission.CannonFlag.ToString();
        }
        private void Redisplay_CPUs()
        {
            string text_char = "";
            string text_veh = "";
            for (int n = 0; n < CurrentMission.CPUs.Count; n += 1)
            {
                KmtCPUEntry entry = CurrentMission.CPUs[n];
                string newline = Environment.NewLine;
                if (n == (CurrentMission.CPUs.Count - 1)) newline = "";
                text_char = text_char + String.Format(
                    "{1}{0}"
                    , newline, dict_character[entry.Character].Name);
                text_veh = text_veh + String.Format(
                    "{1}{0}"
                    , newline, dict_vehicle[entry.Vehicle].Name);
            }
            tb_CPUs_Characters.Text = text_char;
            tb_CPUs_Vehicles.Text = text_veh;
        }

        private void cb_GameMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            CurrentMission.GameMode =
                dict_gamemode.Keys.ToArray()[cb_GameMode.SelectedIndex];
            tb_GameMode.Text = ((dict_gamemode.Values.ToArray())[cb_GameMode.SelectedIndex]).Desc;
        }
        private void cb_Course_SelectedIndexChanged(object sender, EventArgs e)
        {
            CurrentMission.Course =
                dict_course.Keys.ToArray()[cb_Course.SelectedIndex];
        }
        private void cb_CharVeh_Char_SelectedIndexChanged(object sender, EventArgs e)
        {
            CurrentMission.Character =
                dict_character.Keys.ToArray()[cb_CharVeh_Char.SelectedIndex];
        }
        private void cb_CharVeh_Veh_SelectedIndexChanged(object sender, EventArgs e)
        {
            CurrentMission.Vehicle =
                dict_vehicle.Keys.ToArray()[cb_CharVeh_Veh.SelectedIndex];
        }
        private void cb_Class_SelectedIndexChanged(object sender, EventArgs e)
        {
            CurrentMission.EngineClass =
                dict_engineclass.Keys.ToArray()[cb_Class.SelectedIndex];
        }
        private void cb_Camera_SelectedIndexChanged(object sender, EventArgs e)
        {
            CurrentMission.CameraMode =
                dict_cameramode.Keys.ToArray()[cb_Camera.SelectedIndex];
        }
        private void tb_mrf_TextChanged(object sender, EventArgs e)
        {
            CurrentMission.MissionRunFile = Ex.StringToUInt16(tb_mrf.Text);
            tb_ro_mrf.Text = String.Format("mr{0:00}.szs", CurrentMission.MissionRunFile);
        }
        private void tb_Time_TextChanged(object sender, EventArgs e)
        {
            ushort GetTimeLimit(string s)
            {
                ushort time_min;
                ushort time_sec;
                int index = s.IndexOf(":");
                if (index != -1)
                {
                    time_min = Ex.StringToUInt16(s.Substring(0, index));
                    time_sec = Ex.StringToUInt16(s.Substring(index + 1));
                }
                else
                {
                    time_min = 0;
                    time_sec = Ex.StringToUInt16(s);
                }
                uint seconds = ((uint)time_min) * 60 + ((uint)time_sec);
                if (seconds > ((uint)ushort.MaxValue)) return ushort.MaxValue;
                return (ushort)seconds;
            }
            CurrentMission.TimeLimit = GetTimeLimit(tb_Time.Text);
            int sec = CurrentMission.TimeLimit % 60;
            int min = CurrentMission.TimeLimit / 60;
            tb_ro_Time.Text = String.Format("{0}:{1:00}", min, sec);
        }
        private void tb_Controller_TextChanged(object sender, EventArgs e)
        {
            CurrentMission.ControllerRestriction = Ex.StringToByte(tb_Controller.Text);
        }
        private void tb_Score_TextChanged(object sender, EventArgs e)
        {
            CurrentMission.Score = Ex.StringToUInt32(tb_Score.Text);
        }
        private void tb_Minimap_TextChanged(object sender, EventArgs e)
        {
            CurrentMission.Minimap = Ex.StringToUInt16(tb_Minimap.Text);
        }
        private void tb_Cannon_TextChanged(object sender, EventArgs e)
        {
            CurrentMission.CannonFlag = Ex.StringToUInt16(tb_Cannon.Text);
        }

        private void tb_mrf_Leave(object sender, EventArgs e)
        {
            Redisplay_MissionRunFile();
        }
        private void tb_Time_Leave(object sender, EventArgs e)
        {
            Redisplay_Time();
        }
        private void tb_Controller_Leave(object sender, EventArgs e)
        {
            Redisplay_Controller();
        }
        private void tb_Score_Leave(object sender, EventArgs e)
        {
            Redisplay_Score();
        }
        private void tb_Minimap_Leave(object sender, EventArgs e)
        {
            Redisplay_Minimap();
        }
        private void tb_Cannon_Leave(object sender, EventArgs e)
        {
            Redisplay_Cannon();
        }

        private void b_Course_Click(object sender, EventArgs e)
        {
            Form_Course dialog = new Form_Course(CurrentMission.Course);
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                CurrentMission.Course = dialog.Course;
                Redisplay_Course();
            }
        }
        private void b_CharVeh_Click(object sender, EventArgs e)
        {
            Form_CharVeh dialog = new Form_CharVeh(
                CurrentMission.Character, CurrentMission.Vehicle);
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                CurrentMission.Character = dialog.Character;
                CurrentMission.Vehicle = dialog.Vehicle;
                Redisplay_Character();
                Redisplay_Vehicle();
            }
        }

        private void b_CPUs_Click(object sender, EventArgs e)
        {
            Form_CPUs dialog = new Form_CPUs(dict_character, dict_vehicle, CurrentMission.CPUs);
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                CurrentMission.CPUs = dialog.CPUs;
                Redisplay_CPUs();
            }
        }
    }
}
