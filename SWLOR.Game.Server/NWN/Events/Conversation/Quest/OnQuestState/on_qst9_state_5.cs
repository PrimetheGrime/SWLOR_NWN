using SWLOR.Game.Server;

using SWLOR.Game.Server.NWN.Events.Conversation.Quest.OnQuestState;
using static NWN._;

// ReSharper disable once CheckNamespace
namespace NWN.Scripts
{
#pragma warning disable IDE1006 // Naming Styles
    internal class on_qst9_state_5
#pragma warning restore IDE1006 // Naming Styles
    {
        public static int Main()
        {
            return QuestCheckState.Check(9, 5) ? TRUE : FALSE;
        }
    }
}
