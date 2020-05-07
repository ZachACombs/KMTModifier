using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using KMT;

namespace KMTModifier
{
    public class BoolValue
    {
        public bool Value { set; get; }

        public BoolValue(bool value)
        {
            Value = value;
        }
    }
    public class StringValue
    {
        public string Value { set; get; }

        public StringValue(string value)
        {
            Value = value;
        }
    }

    public class NameDesc
    {
        public string Name;
        public string Desc;

        public NameDesc(string name, string desc)
        {
            Name = name;
            Desc = desc;
        }
    }
    public class NameImg
    {
        public string Name;
        public Image Img;

        public NameImg(string name, Image img)
        {
            Name = name;
            Img = img;
        }
    }

    public class IndexMission
    {
        public int Index;
        public KmtEntry Mission;

        public IndexMission(int index, KmtEntry mission)
        {
            Index = index;
            Mission = mission;
        }
    }

    public class Ex
    {
        static uint stringtouint(string s)
        {
            ulong newvalue = 0;
            int digitcount = 0;
            foreach (char c in s)
            {
                int index = "0123456789".IndexOf(c);
                if (index != -1)
                {
                    newvalue *= 10;
                    newvalue += (ulong)index;
                    digitcount += 1;
                }
                if (digitcount > 10)
                {
                    return uint.MaxValue;
                }
            }
            if (newvalue > uint.MaxValue) return uint.MaxValue;
            return (uint)newvalue;
        }
        public static uint StringToUInt32(string s)
        {
            return stringtouint(s);
        }
        public static ushort StringToUInt16(string s)
        {
            uint value = stringtouint(s);
            if (value > ushort.MaxValue) return ushort.MaxValue;
            return (ushort)value;
        }
        public static byte StringToByte(string s)
        {
            uint value = stringtouint(s);
            if (value > byte.MaxValue) return byte.MaxValue;
            return (byte)value;
        }
    }

    public class Error
    {
        public static void Show(string message, string header)
        {
            MessageBox.Show(message, header, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        public static void Show(string format, string header, params object[] args)
        {
            MessageBox.Show(String.Format(format, args),
                header, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
