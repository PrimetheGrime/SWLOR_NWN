using SWLOR.Game.Server;

using SWLOR.Game.Server.NWN.Events.Conversation.Quest.FinishQuest;
using static NWN._;

// ReSharper disable once CheckNamespace
namespace NWN.Scripts
{
#pragma warning disable IDE1006 // Naming Styles
    internal class fin_qst9_rule7
#pragma warning restore IDE1006 // Naming Styles
    {
        public static int Main()
        {
            return QuestComplete.Check(9, 7) ? TRUE : FALSE;
        }
    }
}
