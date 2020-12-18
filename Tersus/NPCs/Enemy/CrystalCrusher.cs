using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
namespace Tersus.NPCs.Enemy
{
	public class CrystalCrusher : ModNPC
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Crystal Crusher");
			Main.npcFrameCount[npc.type] = Main.npcFrameCount[NPCID.BlueSlime];
		}

		public override void SetDefaults()
		{
			npc.width = 36;
			npc.height = 27;
			npc.damage = 10;
			npc.defense = 5;
			npc.lifeMax = 45;
			npc.HitSound = SoundID.NPCHit1;
			npc.DeathSound = SoundID.NPCDeath43;
			npc.value = 100f;
			npc.knockBackResist = .25f;
			npc.aiStyle = 1;
			aiType = NPCID.BlueSlime;
			animationType = NPCID.BlueSlime;
		}
		bool jump;
		public override void AI()
		{
			Player target = Main.player[npc.target];
			bool expertMode = Main.expertMode;
			npc.direction = npc.spriteDirection;
			if (!npc.collideY) {
				jump = true;
			}
			if (npc.collideY && jump) {
				jump = false;
				Main.PlaySound(2, npc.Center, 110);
				for (int i = 0; i < 5; i++) {
					float rotation = (float)(Main.rand.Next(0, 361) * (Math.PI / 180));
					Vector2 velocity = new Vector2((float)Math.Cos(rotation), (float)Math.Sin(rotation));
					int proj = Projectile.NewProjectile(npc.Center.X, npc.Center.Y,
						velocity.X, velocity.Y, mod.ProjectileType("GreenCrystalProj"), 13, 1, Main.myPlayer, 0, 0);
					Main.projectile[proj].velocity *= 2f;
				}
			}
		}
		public override float SpawnChance(NPCSpawnInfo spawnInfo)
		{
			return spawnInfo.spawnTileY > Main.rockLayer ? 0.05f : 0f;
		}
	}
	public class GreenCrystalProj : ModProjectile
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Green Crystal");
			ProjectileID.Sets.TrailCacheLength[projectile.type] = 5;
			ProjectileID.Sets.TrailingMode[projectile.type] = 0;
		}

		public override void SetDefaults()
		{
			projectile.width = 6;
			projectile.height = 11;
			projectile.aiStyle = 1;
			projectile.friendly = false;
			projectile.hostile = true;
			projectile.penetrate = 5;
			projectile.timeLeft = 600;
			projectile.alpha = 255;
			projectile.extraUpdates = 1;
			aiType = ProjectileID.CrystalShard;
		}

		public override bool OnTileCollide(Vector2 oldVelocity)
		{
			projectile.Kill();
			return false;
		}
		public override void AI()
		{

			for (int index1 = 0; index1 < 5; ++index1) {
				float num1 = projectile.velocity.X * 0.2f * (float)index1;
				float num2 = projectile.velocity.Y * -0.200000002980232f * index1;
				int index2 = Dust.NewDust(new Vector2(projectile.position.X, projectile.position.Y), projectile.width, projectile.height, 74, 0.0f, 0.0f, 100, new Color(), 1.3f);
				Main.dust[index2].noGravity = true;
				Main.dust[index2].velocity *= 0.0f;
				Main.dust[index2].scale = .5f;
				Main.dust[index2].position.X -= num1;
				Main.dust[index2].position.Y -= num2;
			}
		}

		public override void Kill(int timeLeft)
		{
			for (int i = 0; i < 3; i++) {
				int index2 = Dust.NewDust(projectile.position, projectile.width, projectile.height, 187);
				Main.dust[index2].noGravity = true;
			}
			Main.PlaySound(SoundID.Dig, (int)projectile.position.X, (int)projectile.position.Y);
		}
	}
}
