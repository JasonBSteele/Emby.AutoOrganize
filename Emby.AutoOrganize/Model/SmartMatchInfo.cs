﻿
using System;
using System.Collections.Generic;

namespace Emby.AutoOrganize.Model
{
    public class SmartMatchInfo
    {
        public string SeriesId { get; set; }
        public string ItemName { get; set; }
        public string DisplayName { get; set; }
        public FileOrganizerType OrganizerType { get; set; }
        public string[] MatchStrings { get; set; }
        public string[] Paths { get; set; }

        public SmartMatchInfo()
        {
            MatchStrings = new string[] { };
            Paths = new string[] { };
        }
    }
}
