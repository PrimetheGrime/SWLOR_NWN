using SWLOR.Game.Server;
using SWLOR.Game.Server.Event.Conversation.KeyItem;
using static SWLOR.Game.Server.NWN._;

// ReSharper disable once CheckNamespace
namespace NWN.Scripts
{
#pragma warning disable IDE1006 // Naming Styles
    public class any_keyitems_7
#pragma warning restore IDE1006 // Naming Styles
    {
        public static int Main()
        {
            return KeyItemCheck.Check(7, 2) ? true : false;
        }
    }
}
