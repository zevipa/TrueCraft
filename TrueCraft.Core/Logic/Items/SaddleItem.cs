using System;
using TrueCraft.API.Logic;

namespace TrueCraft.Core.Logic.Items
{
    public class SaddleItem : ItemProvider
    {
        public static readonly short ItemID = 0x149;

        public override short ID { get { return 0x149; } }

        public override sbyte MaximumStack { get { return 1; } }

        public override string DisplayName { get { return "Saddle"; } }
    }
}