using System;
using System.Collections.Generic;

namespace HuckFacts
{
    public class HuckFactData
    {
        public HuckFactData()
        {
        }
        
        public static IEnumerable<HuckFactData> All { private set; get; }
        public string TheFact { get; set; }
        public string ShortFact { get; set; }
        public string ImageFile { get; set; }
        static HuckFactData()
        {
            List<String> imgs = new List<String>();
            imgs.Add("one.png");
            imgs.Add("two.png");
            imgs.Add("three.png");
            imgs.Add("four.png");
            imgs.Add("five.png");
            

            List<HuckFactData> all = new List<HuckFactData>();
            all.Add(new HuckFactData() { ImageFile = imgs[0], TheFact = "Hucks are of predominantly German Heritage.", ShortFact = "Huck Ancestry" });
            all.Add(new HuckFactData() { ImageFile = imgs[1], TheFact = "Hucks are deceivingly average students, high aptitude & low attitude.", ShortFact = "Skool" });
            all.Add(new HuckFactData() { ImageFile = imgs[2], TheFact = "Hucks love horseradish, mustard, and peppers.", ShortFact = "Spicey" });
            all.Add(new HuckFactData() { ImageFile = imgs[3], TheFact = "A majority of Hucks live in the Midwestern United States", ShortFact = "Location" });
            all.Add(new HuckFactData() { ImageFile = imgs[4], TheFact = "Hucks cannot live without a steady intake of caffeine.", ShortFact = "Coffee" });
            All = all;

            
        }
    }
}