using Terraria;
using Terraria.ModLoader;

namespace ColorSwords.Buffs
{
    public class SpiderRevenge : ModBuff
    {
        public override void SetDefaults()
        {
            DisplayName.SetDefault("Spider Revenge");
            Description.SetDefault("Your defense is decreased!");
            Main.buffNoTimeDisplay[Type] = false;
            Main.debuff[Type] = false;
        }

        public override void Update(Player player, ref int buffIndex)
        {
            player.statDefense += -30;
        }
    }
}