using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1.type3
{
    internal class TTsquad
    { 
        private string _orgName;
        private int _regNum;
        private string _theme;
         private TimeFrame _timeFrame;
      
        private Info[] Infos = new Info[0];

       
        public int RegNum { get => _regNum; init => _regNum = value; }
      
        public string Theme { get => _theme; init => _theme = value; }
        public string OrgName { get => _orgName; init => _orgName = value; }  
        public TimeFrame TimeFrame { get => _timeFrame; init => _timeFrame = value; }
        public Info[] AllInfos { get => Infos; init => Infos = value; }

        public Info? LastInfo => AllInfos.Length == 0 ? null : AllInfos[AllInfos.Length - 1];
        public bool this[TimeFrame frame] { get => TimeFrame == frame; }

       
        public TTsquad(string theme, string orgName, int regNum, TimeFrame timeFrame)
        {
            _theme = theme;
            _orgName = orgName;
            _regNum = regNum;
            _timeFrame = timeFrame;
        }
        public TTsquad()
        {
            _theme = string.Empty;
            _orgName = string.Empty;
            _regNum = 0;
            _timeFrame = new TimeFrame();
        }
       

        public override string? ToString()
        {
            StringBuilder builder = new StringBuilder(ToShortString());
            foreach (var item in Infos)
            {
                builder.Append("Infos: ").Append(item).Append("\n");
            }
            return builder.ToString();
        }
        public string? ToShortString()
        {
            StringBuilder builder = new StringBuilder();
            builder.Append("Theme: ").Append(_theme).Append("\n");
            builder.Append("Org name: ").Append(_orgName).Append("\n");
            builder.Append("Reg num: ").Append(_regNum).Append("\n");
            builder.Append("Time frame: ").Append(_timeFrame).Append("\n");
            return builder.ToString();
        } 
        public void AppebdInfo(params Info[] newInfos)
        {
            if (newInfos == null)
            {
                return;
            }
            Info[] temp = new Info[newInfos.Length+Infos.Length];
            Infos.CopyTo(temp, 0);
            newInfos.CopyTo(temp, Infos.Length);
            Infos = temp;
        }
    }
}
