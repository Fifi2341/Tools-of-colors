using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.Serialization;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.ModLoader.Config;
using Terraria.ModLoader.Config.UI;
using Terraria.UI;

namespace ColorSwords
{

	public class ColorSwordsConfig : ModConfig
	{

		public override ConfigScope Mode => ConfigScope.ServerSide;

		[DefaultValue(true)]



		[Label("Disable buggy and experimental items")]
		[Tooltip("It will remove all experimental items from game.")]
		[ReloadRequired]
		public bool DisableExperimentalItems { get; set; }

		[Label("Reduce lag")]
		[Tooltip("Reduces lag a bit, decreases ram usage.")]
		[DefaultValue(false)]
		[ReloadRequired]
		public bool isLagReduceEnabled;

		[Label("Nerf Bat King Soul")]
		[Tooltip("Nerfs Bat King Soul item.")]
		[DefaultValue(false)]
		[ReloadRequired]
		public bool isBatNerfEnabled;

		[ReloadRequired]
		[Range(1, 9999)]
		[Label("Gem Zombie HP")]
		[Tooltip("Change HP of zombie king (1 - 9999 hp)")]
		[DefaultValue(75)]
		public int GemZombieHP { get; set; }

		[Label("Easier Gem Gold Bar recipe")]
		[Tooltip("Changes required Gold Bars to craft Gem Gold Bars from 15 to 2")]
		[DefaultValue(false)]
		[ReloadRequired]
		public bool isEasyGoldEnabled;

		[Label("Disable Healing Staffs")]
		[Tooltip("It will remove all Healing Staffs from game.")]
		[ReloadRequired]
		public bool DisableHealingStaffItems { get; set; }

		[Label("Disable Heavy Armor")]
		[Tooltip("if you think heavy armor has too much defence, you can disable it.")]
		[ReloadRequired]
		public bool DisableBallisticItems { get; set; }

		[Label("Disable Gold plated items")]
		[Tooltip("Removes all Gold Plated weapons and Gem Gold Bar from game.")]
		[ReloadRequired]
		public bool DisableGoldenItems { get; set; }

		[Label("Disable Dev Weapons")]
		[Tooltip("Removes all Dev weapons from game.")]
		[ReloadRequired]
		public bool DisableDevItems { get; set; }
	}

	
}