﻿using SWLOR.Game.Server;

using SWLOR.Game.Server.NWN.Events.Conversation.Quest.HasQuest;
using static NWN._;

// ReSharper disable once CheckNamespace
namespace NWN.Scripts
{
#pragma warning disable IDE1006 // Naming Styles
    internal class has_quest_3
#pragma warning restore IDE1006 // Naming Styles
    {
        public static int Main()
        {
            return QuestCheck.Check(3) ? TRUE : FALSE;
        }
    }
}
