using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KMTModifier
{
    public partial class Form_About : Form
    {
        void WriteText(params RichText[] text)
        {
            int[] index = new int[text.Length];
            string newtext = "";
            for (int n = 0; n < text.Length; n += 1)
            {
                index[n] = newtext.Length;
                newtext = newtext + text[n].Text;
            }
            rtb_About.Text = newtext;

            for (int n = 0; n < text.Length; n += 1)
            {
                rtb_About.Select(index[n], text[n].Text.Length);
                rtb_About.SelectionAlignment = text[n].Alignment;
                rtb_About.SelectionFont = text[n].Textfont;
            }

            rtb_About.DeselectAll();
        }
        public Form_About()
        {
            InitializeComponent();

            WriteText(
                new RichText(HorizontalAlignment.Center,
                    new Font(FontFamily.GenericSansSerif, 24),
                    "KMT Modifier\n"
                    ),
                new RichText(HorizontalAlignment.Center,
                new Font(FontFamily.GenericSansSerif, 10),
                    "v1.0 beta\n" +
                    "Created by Zach Combs")
                );

            rtb_About.ReadOnly = true;
        }
    }
    class RichText
    {
        public HorizontalAlignment Alignment;
        public Font Textfont;
        public string Text;

        public RichText(HorizontalAlignment alignment, 
            Font textfont, string text)
        {
            Alignment = alignment;
            Textfont = textfont;
            Text = text;
        }
    }
}
