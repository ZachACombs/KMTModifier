using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using KMT;

namespace KMTModifier
{
    class CurrentMissionOption
    {
        private static string getcode(int region)
        {
            //region==0   PAL
            //region==1   NTSC-U
            //region==2   NTSC-J
            //region==3   NTSC-K

            string code_PAL;
            #region PAL
            code_PAL =
                "C20009C8 0000001A\n" +
                "3800008E 48000075\n" +
                "MM\n" +
                "7C8802A6 3C608000\n" +
                "3884FFF0 908309C0\n" +
                "3C60809C 80631E38\n" +
                "80630000 806301AC\n" +
                "3880FFFF 908306B4\n" +
                "3C808000 608409CC\n" +
                "908306B8 80630668\n" +
                "9064FFF8 3C608062\n" +
                "6063C3C4 7C6903A6\n" +
                "7FE3FB78 4E800420\n" +
                "60000000 00000000\n" +
                "0462D338 4B9D3690\n" +
                "0462D47C 4B9D354C\n" +
                "0462D5C0 4B9D3408\n" +
                "0462D80C 4B9D31BC\n" +
                "C20009CC 00000007\n" +
                "38800001 3D408000\n" +
                "908A09D0 3C80809C\n" +
                "80841E38 80840000\n" +
                "808401AC 80840024\n" +
                "80840008 814A09C4\n" +
                "7D4903A6 4E800420\n" +
                "60000000 00000000\n" +
                "C284F4AC 00000005\n" +
                "3D408000 812A09D0\n" +
                "2C090001 40820010\n" +
                "39200000 912A09D0\n" +
                "38800004 2C040001\n" +
                "60000000 00000000\n" +
                "C262CA50 00000007\n" +
                "3C608062 38632D08\n" +
                "7C6903A6 7FE3FB78\n" +
                "38800035 4E800421\n" +
                "3C608062 38632D08\n" +
                "7C6903A6 7FE3FB78\n" +
                "3880002A 4E800421\n" +
                "7FE3FB78 00000000\n" +
                "C285E3B4 00000005\n" +
                "3C60809C 80631E38\n" +
                "80630000 80630000\n" +
                "2C03002C 41A2000C\n" +
                "38600026 48000008\n" +
                "38600025 00000000\n" +
                "C2529E1C 00000003\n" +
                "3FC08000 7C04F040\n" +
                "41A10008 3C808170\n" +
                "7C7E1B78 00000000\n" +
                "C284302C 00000008\n" +
                "3C808000 808409C0\n" +
                "2C040000 41A20010\n" +
                "7C832378 38000000\n" +
                "48000024 2C030000\n" +
                "4182000C 80630000\n" +
                "48000014 3C608170\n" +
                "38800001 98830016\n" +
                "38000000 00000000\n" +
                "C2630814 00000006\n" +
                "3C608062 60632DA0\n" +
                "7C6903A6 7FE3FB78\n" +
                "4E800421 3C608062\n" +
                "60632DA0 7C6903A6\n" +
                "7FE3FB78 3880007A\n" +
                "4E800421 00000000";
            #endregion

            string code_NTSCU;
            #region NTSC-U
            code_NTSCU =
                "C20009C8 0000001A\n" +
                "3800008E 48000075\n" +
                "MM\n" +
                "7C8802A6 3C608000\n" +
                "3884FFF0 908309C0\n" +
                "3C60809C 80631E38\n" +
                "80630000 806301AC\n" +
                "3880FFFF 908306B4\n" +
                "3C808000 608409CC\n" +
                "908306B8 80630668\n" +
                "9064FFF8 3C608062\n" +
                "6063C3C4 7C6903A6\n" +
                "7FE3FB78 4E800420\n" +
                "60000000 00000000\n" +
                "0462D338 4B9D3690\n" +
                "0462D47C 4B9D354C\n" +
                "0462D5C0 4B9D3408\n" +
                "0462D80C 4B9D31BC\n" +
                "C20009CC 00000007\n" +
                "38800001 3D408000\n" +
                "908A09D0 3C80809C\n" +
                "80841E38 80840000\n" +
                "808401AC 80840024\n" +
                "80840008 814A09C4\n" +
                "7D4903A6 4E800420\n" +
                "60000000 00000000\n" +
                "C284F4AC 00000005\n" +
                "3D408000 812A09D0\n" +
                "2C090001 40820010\n" +
                "39200000 912A09D0\n" +
                "38800004 2C040001\n" +
                "60000000 00000000\n" +
                "C262CA50 00000007\n" +
                "3C608062 38632D08\n" +
                "7C6903A6 7FE3FB78\n" +
                "38800035 4E800421\n" +
                "3C608062 38632D08\n" +
                "7C6903A6 7FE3FB78\n" +
                "3880002A 4E800421\n" +
                "7FE3FB78 00000000\n" +
                "C285E3B4 00000005\n" +
                "3C60809C 80631E38\n" +
                "80630000 80630000\n" +
                "2C03002C 41A2000C\n" +
                "38600026 48000008\n" +
                "38600025 00000000\n" +
                "C2529E1C 00000003\n" +
                "3FC08000 7C04F040\n" +
                "41A10008 3C808170\n" +
                "7C7E1B78 00000000\n" +
                "C284302C 00000008\n" +
                "3C808000 808409C0\n" +
                "2C040000 41A20010\n" +
                "7C832378 38000000\n" +
                "48000024 2C030000\n" +
                "4182000C 80630000\n" +
                "48000014 3C608170\n" +
                "38800001 98830016\n" +
                "38000000 00000000\n" +
                "C2630814 00000006\n" +
                "3C608062 60632DA0\n" +
                "7C6903A6 7FE3FB78\n" +
                "4E800421 3C608062\n" +
                "60632DA0 7C6903A6\n" +
                "7FE3FB78 3880007A\n" +
                "4E800421 00000000";
            #endregion

            string code_NTSCJ;
            #region NTSC-J
            code_NTSCJ =
                "C20009C8 0000001A\n" +
                "3800008E 48000075\n" +
                "MM\n" +
                "7C8802A6 3C608000\n" +
                "3884FFF0 908309C0\n" +
                "3C60809C 80630E98\n" +
                "80630000 806301AC\n" +
                "3880FFFF 908306B4\n" +
                "3C808000 608409CC\n" +
                "908306B8 80630668\n" +
                "9064FFF8 3C608062\n" +
                "6063BB10 7C6903A6\n" +
                "7FE3FB78 4E800420\n" +
                "60000000 00000000\n" +
                "0462CA84 4B9D3F44\n" +
                "0462CBC8 4B9D3E00\n" +
                "0462CD0C 4B9D3CBC\n" +
                "0462CF58 4B9D3A70\n" +
                "C20009CC 00000007\n" +
                "38800001 3D408000\n" +
                "908A09D0 3C80809C\n" +
                "80840E98 80840000\n" +
                "808401AC 80840024\n" +
                "80840008 814A09C4\n" +
                "7D4903A6 4E800420\n" +
                "60000000 00000000\n" +
                "C284EB18 00000005\n" +
                "3D408000 812A09D0\n" +
                "2C090001 40820010\n" +
                "39200000 912A09D0\n" +
                "38800004 2C040001\n" +
                "60000000 00000000\n" +
                "C262C19C 00000007\n" +
                "3C608062 38632454\n" +
                "7C6903A6 7FE3FB78\n" +
                "38800035 4E800421\n" +
                "3C608062 38632454\n" +
                "7C6903A6 7FE3FB78\n" +
                "3880002A 4E800421\n" +
                "7FE3FB78 00000000\n" +
                "C285DA20 00000005\n" +
                "3C60809C 80630E98\n" +
                "80630000 80630000\n" +
                "2C03002C 41A2000C\n" +
                "38600026 48000008\n" +
                "38600025 00000000\n" +
                "C252979C 00000003\n" +
                "3FC08000 7C04F040\n" +
                "41A10008 3C808170\n" +
                "7C7E1B78 00000000\n" +
                "C2842698 00000008\n" +
                "3C808000 808409C0\n" +
                "2C040000 41A20010\n" +
                "7C832378 38000000\n" +
                "48000024 2C030000\n" +
                "4182000C 80630000\n" +
                "48000014 3C608170\n" +
                "38800001 98830016\n" +
                "38000000 00000000\n" +
                "C262FF60 00000006\n" +
                "3C608062 606324EC\n" +
                "7C6903A6 7FE3FB78\n" +
                "4E800421 3C608062\n" +
                "606324EC 7C6903A6\n" +
                "7FE3FB78 3880007A\n" +
                "4E800421 00000000";
            #endregion

            string code_NTSCK;
            #region NTSC-K
            code_NTSCK =
                "C20009C8 0000001A\n" +
                "3800008E 48000075\n" +
                "MM\n" +
                "7C8802A6 3C608000\n" +
                "3884FFF0 908309C0\n" +
                "3C60809B 80630478\n" +
                "80630000 806301AC\n" +
                "3880FFFF 908306B4\n" +
                "3C808000 608409CC\n" +
                "908306B8 80630668\n" +
                "9064FFF8 3C608061\n" +
                "6063A7BC 7C6903A6\n" +
                "7FE3FB78 4E800420\n" +
                "60000000 00000000\n" +
                "0461B730 4B9E5298\n" +
                "0461B874 4B9E5154\n" +
                "0461B9B8 4B9E5010\n" +
                "0461BC04 4B9E4DC4\n" +
                "C20009CC 00000007\n" +
                "38800001 3D408000\n" +
                "908A09D0 3C80809B\n" +
                "80840478 80840000\n" +
                "808401AC 80840024\n" +
                "80840008 814A09C4\n" +
                "7D4903A6 4E800420\n" +
                "60000000 00000000\n" +
                "C283D86C 00000005\n" +
                "3D408000 812A09D0\n" +
                "2C090001 40820010\n" +
                "39200000 912A09D0\n" +
                "38800004 2C040001\n" +
                "60000000 00000000\n" +
                "C261AE48 00000007\n" +
                "3C608061 38631100\n" +
                "7C6903A6 7FE3FB78\n" +
                "38800035 4E800421\n" +
                "3C608061 38631100\n" +
                "7C6903A6 7FE3FB78\n" +
                "3880002A 4E800421\n" +
                "7FE3FB78 00000000\n" +
                "C284C774 00000005\n" +
                "3C60809B 80630478\n" +
                "80630000 80630000\n" +
                "2C03002C 41A2000C\n" +
                "38600026 48000008\n" +
                "38600025 00000000\n" +
                "C2517E40 00000003\n" +
                "3FC08000 7C04F040\n" +
                "41A10008 3C808170\n" +
                "7C7E1B78 00000000\n" +
                "C28313EC 00000008\n" +
                "3C808000 808409C0\n" +
                "2C040000 41A20010\n" +
                "7C832378 38000000\n" +
                "48000024 2C030000\n" +
                "4182000C 80630000\n" +
                "48000014 3C608170\n" +
                "38800001 98830016\n" +
                "38000000 00000000\n" +
                "C261EC0C 00000006\n" +
                "3C608061 60631198\n" +
                "7C6903A6 7FE3FB78\n" +
                "4E800421 3C608061\n" +
                "60631198 7C6903A6\n" +
                "7FE3FB78 3880007A\n" +
                "4E800421 00000000";
            #endregion

            if (region == 0) return code_PAL;
            if (region == 1) return code_NTSCU;
            if (region == 2) return code_NTSCJ;
            if (region == 3) return code_NTSCK;
            return "";
        }
        private static byte[] missioncode(KmtEntry mission)
        {
            byte[] ushort_getbytes(ushort value)
            {
                byte[] newbyte = BitConverter.GetBytes(value);
                Array.Reverse(newbyte);
                return newbyte;
            }
            byte[] uint_getbytes(uint value)
            {
                byte[] newbyte = BitConverter.GetBytes(value);
                Array.Reverse(newbyte);
                return newbyte;
            }

            List<byte> newbytes = new List<byte>();
            newbytes.AddRange(ushort_getbytes(mission.MissionRunFile));
            newbytes.AddRange(ushort_getbytes((ushort)mission.GameMode));
            newbytes.Add((byte)mission.Course);
            newbytes.Add((byte)mission.Character);
            newbytes.Add((byte)mission.Vehicle);
            newbytes.Add((byte)mission.EngineClass);
            for (int n = 0x08; n < 0x2C; n += 1) newbytes.Add(0x00);
            newbytes.AddRange(ushort_getbytes(mission.TimeLimit));
            newbytes.Add(0x00);
            newbytes.Add(mission.ControllerRestriction);
            newbytes.AddRange(uint_getbytes(mission.Score));
            for (int n = 0x34; n < 0x48; n += 1) newbytes.Add(0x00);
            newbytes.AddRange(ushort_getbytes((ushort)mission.CameraMode));
            newbytes.AddRange(ushort_getbytes((ushort)mission.Minimap));
            for (int n = 0x4C; n < 0x50; n += 1) newbytes.Add(0x00);
            newbytes.AddRange(ushort_getbytes(mission.CannonFlag));
            for (int n = 0x52; n < 0x58; n += 1) newbytes.Add(0x00);
            newbytes.AddRange(ushort_getbytes((ushort)mission.CPUs.Count));
            int offset = 0x5A;
            for (int n = 0; n < mission.CPUs.Count; n += 1)
            {
                KmtCPUEntry cpu = mission.CPUs[n];
                newbytes.Add((byte)cpu.Character);
                newbytes.Add((byte)cpu.Vehicle);
                offset += 2;
            }
            for (int n = offset; n < 0x70; n += 1) newbytes.Add(0x00);

            return newbytes.ToArray();
        }
        private static string bytetostring(byte[] bytes)
        {
            string newstr = "";

            for (int n = 0; n < bytes.Length; n += 1)
            {
                byte bbyte = bytes[n];
                int aa = bbyte / 16;
                int bb = bbyte % 16;

                if (aa == 0x0) newstr = newstr + "0";
                else if (aa == 0x1) newstr = newstr + "1";
                else if (aa == 0x2) newstr = newstr + "2";
                else if (aa == 0x3) newstr = newstr + "3";
                else if (aa == 0x4) newstr = newstr + "4";
                else if (aa == 0x5) newstr = newstr + "5";
                else if (aa == 0x6) newstr = newstr + "6";
                else if (aa == 0x7) newstr = newstr + "7";
                else if (aa == 0x8) newstr = newstr + "8";
                else if (aa == 0x9) newstr = newstr + "9";
                else if (aa == 0xA) newstr = newstr + "A";
                else if (aa == 0xB) newstr = newstr + "B";
                else if (aa == 0xC) newstr = newstr + "C";
                else if (aa == 0xD) newstr = newstr + "D";
                else if (aa == 0xE) newstr = newstr + "E";
                else newstr = newstr + "F";

                if (bb == 0x0) newstr = newstr + "0";
                else if (bb == 0x1) newstr = newstr + "1";
                else if (bb == 0x2) newstr = newstr + "2";
                else if (bb == 0x3) newstr = newstr + "3";
                else if (bb == 0x4) newstr = newstr + "4";
                else if (bb == 0x5) newstr = newstr + "5";
                else if (bb == 0x6) newstr = newstr + "6";
                else if (bb == 0x7) newstr = newstr + "7";
                else if (bb == 0x8) newstr = newstr + "8";
                else if (bb == 0x9) newstr = newstr + "9";
                else if (bb == 0xA) newstr = newstr + "A";
                else if (bb == 0xB) newstr = newstr + "B";
                else if (bb == 0xC) newstr = newstr + "C";
                else if (bb == 0xD) newstr = newstr + "D";
                else if (bb == 0xE) newstr = newstr + "E";
                else newstr = newstr + "F";

                if (n < (bytes.Length - 1))
                {
                    int offsetinrow = n % 8;
                    if (offsetinrow == 7) newstr = newstr + "\n";
                    if (offsetinrow == 3) newstr = newstr + " ";
                }
            }

            return newstr;
        }
        public static void CopyEntryToClipboard(KmtEntry mission)
        {
            Clipboard.SetText(bytetostring(missioncode(mission)));
        }
        public static void CopyCheatCodeToClipboard(KmtEntry mission, int region)
        {
            string missionmode = getcode(region);
            missionmode = missionmode.Replace("MM",
                bytetostring(missioncode(mission))
                );
            Clipboard.SetText(missionmode);
        }
        public static void ExportGCTCode(KmtEntry mission, int region)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "GCT File|*.gct";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    List<byte> newbytes = new List<byte>();

                    byte stringtobyte(char Y, char Z)
                    {
                        //Format: 0xYZ
                        int getvalue(char cc)
                        {
                            int index = ("0123456789ABCDEF").IndexOf(cc);
                            if (index == -1)
                                index = ("0123456789abcedf").IndexOf(cc);
                            return index;
                        }

                        return (byte)(getvalue(Y) * 16 + getvalue(Z));
                    }
                    string missionmode = getcode(region)
                        .Replace("\n", "").Replace(" ", "");
                    int mmoffset = missionmode.IndexOf("MM");

                    newbytes.Add(0x00);
                    newbytes.Add(0xD0);
                    newbytes.Add(0xC0);
                    newbytes.Add(0xDE);
                    newbytes.Add(0x00);
                    newbytes.Add(0xD0);
                    newbytes.Add(0xC0);
                    newbytes.Add(0xDE);

                    for (int n = 0; n < mmoffset; n += 2)
                    {
                        newbytes.Add(stringtobyte(
                            missionmode[n], missionmode[n + 1]
                            ));
                    }
                    newbytes.AddRange(missioncode(mission));
                    for (int n = mmoffset + 2; n < missionmode.Length; n += 2)
                    {
                        newbytes.Add(stringtobyte(
                            missionmode[n], missionmode[n + 1]
                            ));
                    }

                    newbytes.Add(0xFF);
                    newbytes.Add(0x00);
                    newbytes.Add(0x00);
                    newbytes.Add(0x00);
                    newbytes.Add(0x00);
                    newbytes.Add(0x00);
                    newbytes.Add(0x00);
                    newbytes.Add(0x00);

                    File.WriteAllBytes(dialog.FileName, newbytes.ToArray());
                }
                catch (Exception ex)
                {
                    Error.Show(ex.Message, "Could not save file");
                }
            }
        }
    }
}
