namespace BingSearchHelper.Models
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    internal class MD_Args
    {

        public int RngS = 10;
        public int RngE = 15;
        public int SearchNum = 35;
        public bool AutoMod = false;

        private const string FileName = "argSetting";
        public MD_Args()
        {
            if (File.Exists(FileName))
            {
                var content = File.ReadAllText(FileName);
                var vals = content.Split(',');
                if (vals.Length > 0)
                    int.TryParse(vals[0], out RngS);
                if (vals.Length > 1)
                    int.TryParse(vals[1], out RngE);
                if (vals.Length > 2)
                    int.TryParse(vals[2], out SearchNum);
                if (vals.Length > 3)
                    bool.TryParse(vals[3], out AutoMod);
            }
        }

        public void SaveArgs()
        {
            File.WriteAllText(FileName, $"{RngS},{RngE},{SearchNum},{AutoMod}");
        }
    }
}
