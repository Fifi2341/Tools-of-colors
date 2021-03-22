using Terraria;
using Terraria.ModLoader;

namespace ColorSwords.Buffs
{
    public class NinjaBuff2 : ModBuff
    {
        public override void SetDefaults()
        {
            DisplayName.SetDefault("Supreme Samurai");
            Description.SetDefault("You can fell the power of Greatest Samurai");
            Main.buffNoTimeDisplay[Type] = false;
            Main.debuff[Type] = false;
        }

        public override void Update(Player player, ref int buffIndex)
        {
            player.statDefense += 100;
        }
    }
}