using SWLOR.Game.Server;

using SWLOR.Game.Server.NWN.Events.Conversation.Quest.FinishQuest;
using static NWN._;

// ReSharper disable once CheckNamespace
namespace NWN.Scripts
{
#pragma warning disable IDE1006 // Naming Styles
    internal class fin_qst10_rule3
#pragma warning restore IDE1006 // Naming Styles
    {
        public static int Main()
        {
            return QuestComplete.Check(10, 3) ? TRUE : FALSE;
        }
    }
}
