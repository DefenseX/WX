using Microsoft.Xna.Framework.Audio;
using Terraria.ModLoader;

namespace WX.Sounds.Item
{
	public class S01 : ModSound
	{
		public override SoundEffectInstance PlaySound(ref SoundEffectInstance soundInstance, float volume, float pan, SoundType type) {
			soundInstance = sound.CreateInstance();
			soundInstance.Volume = volume * .75f;
			soundInstance.Pan = pan;
			soundInstance.Pitch = -0.2f;
			return soundInstance;
		}
	}
}