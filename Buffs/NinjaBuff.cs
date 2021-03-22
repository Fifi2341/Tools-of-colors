using Terraria;
using Terraria.ModLoader;

namespace ColorSwords.Buffs
{
    public class NinjaBuff : ModBuff
    {
        public override void SetDefaults()
        {
            DisplayName.SetDefault("Ninja Buff");
            Description.SetDefault("+30 defence");
            Main.buffNoTimeDisplay[Type] = false;
            Main.debuff[Type] = false;
        }

        public override void Update(Player player, ref int buffIndex)
        {
            player.statDefense += 30;
        }
    }
}