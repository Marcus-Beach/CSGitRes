using System;
using System.Collections.Generic;
using System.Text;

namespace CS_Lab4_GuessMyNumber
{
    class ClassDesign
    {
        static void Main()
        {
            double monSize = 22;
            int h = 1920;
            int v = 1080;
            
            Monitor labMonitor = new Monitor(monSize, true, true, false, false, h, v);
            Console.WriteLine(labMonitor.ToString());
        }

    }

    class Bottle
    {
        double ounceVolume; //volume in ounces
        bool cap; //does bottle have a cap
        string label; //label description
        public Bottle(double ounceVolume, bool cap, string label)
        {
            this.OunceVolume = ounceVolume;
            this.Cap = cap;
            this.Label = label;
        }

        public double OunceVolume { get => ounceVolume; set => ounceVolume = value; }
        public bool Cap { get => cap; set => cap = value; }
        public string Label { get => label; set => label = value; }

        public override string ToString()
        {
            return String.Format("Bottle with label {0} " + (Cap ? "has a cap" : "has no cap") + 
                " and can contain {1} ounces.", Label, OunceVolume);
        }

    }

    class Mouse
    {
        bool wireless;
        bool webWheel;
        int numButtons;
        public Mouse(bool wireless, bool webwheel, int numButtons)
        {
            this.Wireless = wireless;
            this.WebWheel = webWheel;
            this.numButtons = numButtons;
        }
        public bool Wireless { get => wireless; set => wireless = value; }
        public bool WebWheel { get => webWheel; set => webWheel = value; }
        public int NumButtons { get => numButtons; set => numButtons = value; }

        public override string ToString()
        {
            return String.Format("A " + (Wireless ? "wireless" : "wired") + " mouse with " + NumButtons + " buttons, " +
                (WebWheel ? "and a web wheel." : "and no web wheel."));
        }
    }

    class Monitor
    {
        double inchSize; //screen size by diagonal in inches
        bool vga;
        bool dvi;
        bool hdmi;
        bool displayPort;
        int hPixelCount;
        int vPixelCount;
        public Monitor(double inchSize, bool vga, bool dvi, bool hdmi, bool displayPort, int hPixelCount, int vPixelCount)
        {
            this.InchSize = inchSize;
            this.Vga = vga;
            this.Dvi = dvi;
            this.Hdmi = hdmi;
            this.DisplayPort = displayPort;
            this.HPixelCount = hPixelCount;
            this.VPixelCount = vPixelCount;
        }
        public double InchSize { get => inchSize; set => inchSize = value; }
        public bool Vga { get => vga; set => vga = value; }
        public bool Dvi { get => dvi; set => dvi = value; }
        public bool Hdmi { get => hdmi; set => hdmi = value; }
        public bool DisplayPort { get => displayPort; set => displayPort = value; }
        public int HPixelCount { get => hPixelCount; set => hPixelCount = value; }
        public int VPixelCount { get => vPixelCount; set => vPixelCount = value; }

        public override string ToString()
        {
            return String.Format("A " + HPixelCount + "x" + VPixelCount + " " + InchSize + "\" monitor." +
                "\nVGA: \t\t" + (Vga ? "Yes" : "No") +
                "\nDVI: \t\t" + (Dvi ? "Yes" : "No") +
                "\nHDMI: \t\t" + (Hdmi ? "Yes" : "No") +
                "\nDisplay Port: \t" + (DisplayPort ? "Yes" : "No"));
        }
    }
}