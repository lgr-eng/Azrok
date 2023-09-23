/////////////////////////////////////////////////
//
// Automatically generated by the
// AddonGenerator script by Arya
//
/////////////////////////////////////////////////
using System;
using Server;
using Server.Items;

namespace Server.Items
{
	public class NecroCityHealerAddon : BaseAddon
	{
		public override BaseAddonDeed Deed
		{
			get
			{
				//return new NecroCityHealerAddonDeed();
				return null;
			}
		}

		[ Constructable ]
		public NecroCityHealerAddon()
		{
			AddonComponent ac = null;
			ac = new AddonComponent( 102 );
			AddComponent( ac, -4, -5, 0 );
			ac = new AddonComponent( 100 );
			AddComponent( ac, -4, -4, 0 );
			ac = new AddonComponent( 100 );
			AddComponent( ac, -4, -3, 0 );
			ac = new AddonComponent( 100 );
			AddComponent( ac, -4, -2, 0 );
			ac = new AddonComponent( 100 );
			AddComponent( ac, -4, -1, 0 );
			ac = new AddonComponent( 100 );
			AddComponent( ac, -4, 0, 0 );
			ac = new AddonComponent( 100 );
			AddComponent( ac, -4, 1, 0 );
			ac = new AddonComponent( 100 );
			AddComponent( ac, -4, 2, 0 );
			ac = new AddonComponent( 99 );
			AddComponent( ac, -3, -5, 0 );
			ac = new AddonComponent( 353 );
			ac.Hue = 1109;
			AddComponent( ac, -4, -5, 7 );
			ac = new AddonComponent( 351 );
			ac.Hue = 1109;
			AddComponent( ac, -4, -4, 7 );
			ac = new AddonComponent( 351 );
			ac.Hue = 1109;
			AddComponent( ac, -4, -3, 7 );
			ac = new AddonComponent( 354 );
			ac.Light = LightType.ArchedWindowEast;
			ac.Hue = 1109;
			AddComponent( ac, -4, -2, 7 );
			ac = new AddonComponent( 351 );
			ac.Hue = 1109;
			AddComponent( ac, -4, -1, 7 );
			ac = new AddonComponent( 354 );
			ac.Light = LightType.ArchedWindowEast;
			ac.Hue = 1109;
			AddComponent( ac, -4, 0, 7 );
			ac = new AddonComponent( 351 );
			ac.Hue = 1109;
			AddComponent( ac, -4, 1, 7 );
			ac = new AddonComponent( 354 );
			ac.Light = LightType.ArchedWindowEast;
			ac.Hue = 1109;
			AddComponent( ac, -4, 2, 7 );
			ac = new AddonComponent( 352 );
			ac.Hue = 1109;
			AddComponent( ac, -3, -5, 7 );
			ac = new AddonComponent( 1176 );
			ac.Hue = 1109;
			AddComponent( ac, -3, -4, 7 );
			ac = new AddonComponent( 1175 );
			ac.Hue = 1109;
			AddComponent( ac, -3, -3, 7 );
			ac = new AddonComponent( 1176 );
			ac.Hue = 1109;
			AddComponent( ac, -3, -2, 7 );
			ac = new AddonComponent( 1173 );
			ac.Hue = 1109;
			AddComponent( ac, -3, -1, 7 );
			ac = new AddonComponent( 1175 );
			ac.Hue = 1109;
			AddComponent( ac, -3, 0, 7 );
			ac = new AddonComponent( 1176 );
			ac.Hue = 1109;
			AddComponent( ac, -3, 1, 7 );
			ac = new AddonComponent( 1174 );
			ac.Hue = 1109;
			AddComponent( ac, -3, 2, 7 );
			ac = new AddonComponent( 363 );
			ac.Hue = 1109;
			AddComponent( ac, -4, -5, 27 );
			ac = new AddonComponent( 361 );
			ac.Hue = 1109;
			AddComponent( ac, -4, -4, 27 );
			ac = new AddonComponent( 361 );
			ac.Hue = 1109;
			AddComponent( ac, -4, -3, 27 );
			ac = new AddonComponent( 361 );
			ac.Hue = 1109;
			AddComponent( ac, -4, -2, 27 );
			ac = new AddonComponent( 361 );
			ac.Hue = 1109;
			AddComponent( ac, -4, -1, 27 );
			ac = new AddonComponent( 361 );
			ac.Hue = 1109;
			AddComponent( ac, -4, 0, 27 );
			ac = new AddonComponent( 361 );
			ac.Hue = 1109;
			AddComponent( ac, -4, 1, 27 );
			ac = new AddonComponent( 361 );
			ac.Hue = 1109;
			AddComponent( ac, -4, 2, 27 );
			ac = new AddonComponent( 362 );
			ac.Hue = 1109;
			AddComponent( ac, -3, -5, 27 );
			ac = new AddonComponent( 1173 );
			ac.Hue = 1109;
			AddComponent( ac, -3, -4, 27 );
			ac = new AddonComponent( 1175 );
			ac.Hue = 1109;
			AddComponent( ac, -3, -3, 27 );
			ac = new AddonComponent( 1173 );
			ac.Hue = 1109;
			AddComponent( ac, -3, -2, 27 );
			ac = new AddonComponent( 1173 );
			ac.Hue = 1109;
			AddComponent( ac, -3, -1, 27 );
			ac = new AddonComponent( 1175 );
			ac.Hue = 1109;
			AddComponent( ac, -3, 0, 27 );
			ac = new AddonComponent( 1175 );
			ac.Hue = 1109;
			AddComponent( ac, -3, 1, 27 );
			ac = new AddonComponent( 1175 );
			ac.Hue = 1109;
			AddComponent( ac, -3, 2, 27 );
			ac = new AddonComponent( 100 );
			ac.Hue = 1109;
			AddComponent( ac, -4, 4, 0 );
			ac = new AddonComponent( 99 );
			ac.Hue = 1109;
			AddComponent( ac, -3, 4, 0 );
			ac = new AddonComponent( 1880 );
			ac.Hue = 1109;
			AddComponent( ac, -3, 5, 0 );
			ac = new AddonComponent( 351 );
			ac.Hue = 1109;
			AddComponent( ac, -4, 3, 7 );
			ac = new AddonComponent( 351 );
			ac.Hue = 1109;
			AddComponent( ac, -4, 4, 7 );
			ac = new AddonComponent( 1174 );
			ac.Hue = 1109;
			AddComponent( ac, -3, 3, 7 );
			ac = new AddonComponent( 1173 );
			ac.Hue = 1109;
			AddComponent( ac, -3, 4, 7 );
			ac = new AddonComponent( 352 );
			ac.Hue = 1109;
			AddComponent( ac, -3, 4, 7 );
			ac = new AddonComponent( 361 );
			ac.Hue = 1109;
			AddComponent( ac, -4, 3, 27 );
			ac = new AddonComponent( 361 );
			ac.Hue = 1109;
			AddComponent( ac, -4, 4, 27 );
			ac = new AddonComponent( 1175 );
			ac.Hue = 1109;
			AddComponent( ac, -3, 3, 27 );
			ac = new AddonComponent( 1173 );
			AddComponent( ac, -3, 4, 27 );
			ac = new AddonComponent( 362 );
			ac.Hue = 1109;
			AddComponent( ac, -3, 4, 27 );
			ac = new AddonComponent( 99 );
			AddComponent( ac, -2, -5, 0 );
			ac = new AddonComponent( 99 );
			AddComponent( ac, -1, -5, 0 );
			ac = new AddonComponent( 99 );
			AddComponent( ac, 0, -5, 0 );
			ac = new AddonComponent( 99 );
			AddComponent( ac, 1, -5, 0 );
			ac = new AddonComponent( 99 );
			AddComponent( ac, 2, -5, 0 );
			ac = new AddonComponent( 99 );
			AddComponent( ac, 3, -5, 0 );
			ac = new AddonComponent( 99 );
			AddComponent( ac, 4, -5, 0 );
			ac = new AddonComponent( 99 );
			ac.Hue = 1109;
			AddComponent( ac, 5, -5, 0 );
			ac = new AddonComponent( 100 );
			ac.Hue = 1109;
			AddComponent( ac, 5, -4, 0 );
			ac = new AddonComponent( 100 );
			ac.Hue = 1109;
			AddComponent( ac, 5, -3, 0 );
			ac = new AddonComponent( 100 );
			ac.Hue = 1109;
			AddComponent( ac, 5, -2, 0 );
			ac = new AddonComponent( 100 );
			ac.Hue = 1109;
			AddComponent( ac, 5, -1, 0 );
			ac = new AddonComponent( 100 );
			ac.Hue = 1109;
			AddComponent( ac, 5, 0, 0 );
			ac = new AddonComponent( 100 );
			ac.Hue = 1109;
			AddComponent( ac, 5, 1, 0 );
			ac = new AddonComponent( 100 );
			ac.Hue = 1109;
			AddComponent( ac, 5, 2, 0 );
			ac = new AddonComponent( 352 );
			ac.Hue = 1109;
			AddComponent( ac, -2, -5, 7 );
			ac = new AddonComponent( 352 );
			ac.Hue = 1109;
			AddComponent( ac, -1, -5, 7 );
			ac = new AddonComponent( 352 );
			ac.Hue = 1109;
			AddComponent( ac, 0, -5, 7 );
			ac = new AddonComponent( 352 );
			ac.Hue = 1109;
			AddComponent( ac, 1, -5, 7 );
			ac = new AddonComponent( 352 );
			ac.Hue = 1109;
			AddComponent( ac, 2, -5, 7 );
			ac = new AddonComponent( 352 );
			ac.Hue = 1109;
			AddComponent( ac, 3, -5, 7 );
			ac = new AddonComponent( 352 );
			ac.Hue = 1109;
			AddComponent( ac, 4, -5, 7 );
			ac = new AddonComponent( 352 );
			ac.Hue = 1109;
			AddComponent( ac, 5, -5, 7 );
			ac = new AddonComponent( 1173 );
			ac.Hue = 1109;
			AddComponent( ac, -2, -4, 7 );
			ac = new AddonComponent( 1175 );
			ac.Hue = 1109;
			AddComponent( ac, -2, -3, 7 );
			ac = new AddonComponent( 1173 );
			ac.Hue = 1109;
			AddComponent( ac, -2, -2, 7 );
			ac = new AddonComponent( 1176 );
			ac.Hue = 1109;
			AddComponent( ac, -2, -1, 7 );
			ac = new AddonComponent( 1175 );
			ac.Hue = 1109;
			AddComponent( ac, -2, 0, 7 );
			ac = new AddonComponent( 1173 );
			ac.Hue = 1109;
			AddComponent( ac, -2, 1, 7 );
			ac = new AddonComponent( 1175 );
			ac.Hue = 1109;
			AddComponent( ac, -2, 2, 7 );
			ac = new AddonComponent( 1174 );
			ac.Hue = 1109;
			AddComponent( ac, -1, -4, 7 );
			ac = new AddonComponent( 1176 );
			ac.Hue = 1109;
			AddComponent( ac, -1, -3, 7 );
			ac = new AddonComponent( 1176 );
			ac.Hue = 1109;
			AddComponent( ac, -1, -2, 7 );
			ac = new AddonComponent( 1175 );
			ac.Hue = 1109;
			AddComponent( ac, -1, -1, 7 );
			ac = new AddonComponent( 1175 );
			ac.Hue = 1109;
			AddComponent( ac, -1, 0, 7 );
			ac = new AddonComponent( 1173 );
			ac.Hue = 1109;
			AddComponent( ac, -1, 1, 7 );
			ac = new AddonComponent( 1174 );
			ac.Hue = 1109;
			AddComponent( ac, -1, 2, 7 );
			ac = new AddonComponent( 1174 );
			ac.Hue = 1109;
			AddComponent( ac, 0, -4, 7 );
			ac = new AddonComponent( 1173 );
			ac.Hue = 1109;
			AddComponent( ac, 0, -3, 7 );
			ac = new AddonComponent( 1173 );
			ac.Hue = 1109;
			AddComponent( ac, 0, -2, 7 );
			ac = new AddonComponent( 1174 );
			ac.Hue = 1109;
			AddComponent( ac, 0, -1, 7 );
			ac = new AddonComponent( 1176 );
			ac.Hue = 1109;
			AddComponent( ac, 0, 0, 7 );
			ac = new AddonComponent( 1176 );
			ac.Hue = 1109;
			AddComponent( ac, 0, 1, 7 );
			ac = new AddonComponent( 1176 );
			ac.Hue = 1109;
			AddComponent( ac, 0, 2, 7 );
			ac = new AddonComponent( 1175 );
			ac.Hue = 1109;
			AddComponent( ac, 1, -4, 7 );
			ac = new AddonComponent( 1176 );
			ac.Hue = 1109;
			AddComponent( ac, 1, -3, 7 );
			ac = new AddonComponent( 1174 );
			ac.Hue = 1109;
			AddComponent( ac, 1, -2, 7 );
			ac = new AddonComponent( 1175 );
			ac.Hue = 1109;
			AddComponent( ac, 1, -1, 7 );
			ac = new AddonComponent( 1173 );
			ac.Hue = 1109;
			AddComponent( ac, 1, 0, 7 );
			ac = new AddonComponent( 1175 );
			ac.Hue = 1109;
			AddComponent( ac, 1, 1, 7 );
			ac = new AddonComponent( 1176 );
			ac.Hue = 1109;
			AddComponent( ac, 1, 2, 7 );
			ac = new AddonComponent( 1175 );
			ac.Hue = 1109;
			AddComponent( ac, 2, -4, 7 );
			ac = new AddonComponent( 1174 );
			ac.Hue = 1109;
			AddComponent( ac, 2, -3, 7 );
			ac = new AddonComponent( 1175 );
			ac.Hue = 1109;
			AddComponent( ac, 2, -2, 7 );
			ac = new AddonComponent( 1175 );
			ac.Hue = 1109;
			AddComponent( ac, 2, -1, 7 );
			ac = new AddonComponent( 1173 );
			ac.Hue = 1109;
			AddComponent( ac, 2, 0, 7 );
			ac = new AddonComponent( 1173 );
			ac.Hue = 1109;
			AddComponent( ac, 2, 1, 7 );
			ac = new AddonComponent( 1176 );
			ac.Hue = 1109;
			AddComponent( ac, 2, 2, 7 );
			ac = new AddonComponent( 1176 );
			ac.Hue = 1109;
			AddComponent( ac, 3, -4, 7 );
			ac = new AddonComponent( 1173 );
			ac.Hue = 1109;
			AddComponent( ac, 3, -3, 7 );
			ac = new AddonComponent( 1173 );
			ac.Hue = 1109;
			AddComponent( ac, 3, -2, 7 );
			ac = new AddonComponent( 1176 );
			ac.Hue = 1109;
			AddComponent( ac, 3, -1, 7 );
			ac = new AddonComponent( 1176 );
			ac.Hue = 1109;
			AddComponent( ac, 3, 0, 7 );
			ac = new AddonComponent( 1176 );
			ac.Hue = 1109;
			AddComponent( ac, 3, 1, 7 );
			ac = new AddonComponent( 1175 );
			ac.Hue = 1109;
			AddComponent( ac, 3, 2, 7 );
			ac = new AddonComponent( 1176 );
			AddComponent( ac, 4, -4, 7 );
			ac = new AddonComponent( 1175 );
			ac.Hue = 1109;
			AddComponent( ac, 4, -3, 7 );
			ac = new AddonComponent( 1176 );
			AddComponent( ac, 4, -2, 7 );
			ac = new AddonComponent( 1174 );
			ac.Hue = 1109;
			AddComponent( ac, 4, -1, 7 );
			ac = new AddonComponent( 1173 );
			AddComponent( ac, 4, 0, 7 );
			ac = new AddonComponent( 1176 );
			ac.Hue = 1109;
			AddComponent( ac, 4, 1, 7 );
			ac = new AddonComponent( 1176 );
			AddComponent( ac, 4, 2, 7 );
			ac = new AddonComponent( 1176 );
			AddComponent( ac, 5, -4, 7 );
			ac = new AddonComponent( 1175 );
			ac.Hue = 1109;
			AddComponent( ac, 5, -3, 7 );
			ac = new AddonComponent( 1175 );
			ac.Hue = 1109;
			AddComponent( ac, 5, -2, 7 );
			ac = new AddonComponent( 1173 );
			ac.Hue = 1109;
			AddComponent( ac, 5, -1, 7 );
			ac = new AddonComponent( 1175 );
			ac.Hue = 1109;
			AddComponent( ac, 5, 0, 7 );
			ac = new AddonComponent( 1174 );
			ac.Hue = 1109;
			AddComponent( ac, 5, 1, 7 );
			ac = new AddonComponent( 1175 );
			ac.Hue = 1109;
			AddComponent( ac, 5, 2, 7 );
			ac = new AddonComponent( 2659 );
			AddComponent( ac, -2, -4, 7 );
			ac = new AddonComponent( 2652 );
			AddComponent( ac, -2, -3, 7 );
			ac = new AddonComponent( 2659 );
			AddComponent( ac, 0, -4, 7 );
			ac = new AddonComponent( 2652 );
			AddComponent( ac, 0, -3, 7 );
			ac = new AddonComponent( 2659 );
			AddComponent( ac, 2, -4, 7 );
			ac = new AddonComponent( 2652 );
			AddComponent( ac, 2, -3, 7 );
			ac = new AddonComponent( 351 );
			ac.Hue = 1109;
			AddComponent( ac, 5, -4, 7 );
			ac = new AddonComponent( 351 );
			ac.Hue = 1109;
			AddComponent( ac, 5, -3, 7 );
			ac = new AddonComponent( 354 );
			ac.Light = LightType.ArchedWindowEast;
			ac.Hue = 1109;
			AddComponent( ac, 5, -2, 7 );
			ac = new AddonComponent( 351 );
			ac.Hue = 1109;
			AddComponent( ac, 5, -1, 7 );
			ac = new AddonComponent( 354 );
			ac.Light = LightType.ArchedWindowEast;
			ac.Hue = 1109;
			AddComponent( ac, 5, 0, 7 );
			ac = new AddonComponent( 351 );
			ac.Hue = 1109;
			AddComponent( ac, 5, 1, 7 );
			ac = new AddonComponent( 354 );
			ac.Light = LightType.ArchedWindowEast;
			ac.Hue = 1109;
			AddComponent( ac, 5, 2, 7 );
			ac = new AddonComponent( 362 );
			ac.Hue = 1109;
			AddComponent( ac, -2, -5, 27 );
			ac = new AddonComponent( 362 );
			ac.Hue = 1109;
			AddComponent( ac, -1, -5, 27 );
			ac = new AddonComponent( 362 );
			ac.Hue = 1109;
			AddComponent( ac, 0, -5, 27 );
			ac = new AddonComponent( 362 );
			ac.Hue = 1109;
			AddComponent( ac, 1, -5, 27 );
			ac = new AddonComponent( 362 );
			ac.Hue = 1109;
			AddComponent( ac, 2, -5, 27 );
			ac = new AddonComponent( 362 );
			ac.Hue = 1109;
			AddComponent( ac, 3, -5, 27 );
			ac = new AddonComponent( 362 );
			ac.Hue = 1109;
			AddComponent( ac, 4, -5, 27 );
			ac = new AddonComponent( 362 );
			ac.Hue = 1109;
			AddComponent( ac, 5, -5, 27 );
			ac = new AddonComponent( 1176 );
			ac.Hue = 1109;
			AddComponent( ac, -2, -4, 27 );
			ac = new AddonComponent( 1176 );
			ac.Hue = 1109;
			AddComponent( ac, -2, -3, 27 );
			ac = new AddonComponent( 1173 );
			ac.Hue = 1109;
			AddComponent( ac, -2, -2, 27 );
			ac = new AddonComponent( 1174 );
			ac.Hue = 1109;
			AddComponent( ac, -2, -1, 27 );
			ac = new AddonComponent( 1175 );
			ac.Hue = 1109;
			AddComponent( ac, -2, 0, 27 );
			ac = new AddonComponent( 1174 );
			ac.Hue = 1109;
			AddComponent( ac, -2, 1, 27 );
			ac = new AddonComponent( 1175 );
			ac.Hue = 1109;
			AddComponent( ac, -2, 2, 27 );
			ac = new AddonComponent( 1174 );
			ac.Hue = 1109;
			AddComponent( ac, -1, -4, 27 );
			ac = new AddonComponent( 1175 );
			ac.Hue = 1109;
			AddComponent( ac, -1, -3, 27 );
			ac = new AddonComponent( 1174 );
			ac.Hue = 1109;
			AddComponent( ac, -1, -2, 27 );
			ac = new AddonComponent( 1175 );
			ac.Hue = 1109;
			AddComponent( ac, -1, -1, 27 );
			ac = new AddonComponent( 1173 );
			ac.Hue = 1109;
			AddComponent( ac, -1, 0, 27 );
			ac = new AddonComponent( 1175 );
			ac.Hue = 1109;
			AddComponent( ac, -1, 1, 27 );
			ac = new AddonComponent( 1176 );
			ac.Hue = 1109;
			AddComponent( ac, -1, 2, 27 );
			ac = new AddonComponent( 1176 );
			ac.Hue = 1109;
			AddComponent( ac, 0, -4, 27 );
			ac = new AddonComponent( 1173 );
			ac.Hue = 1109;
			AddComponent( ac, 0, -3, 27 );
			ac = new AddonComponent( 1176 );
			ac.Hue = 1109;
			AddComponent( ac, 0, -2, 27 );
			ac = new AddonComponent( 1175 );
			ac.Hue = 1109;
			AddComponent( ac, 0, -1, 27 );
			ac = new AddonComponent( 1176 );
			ac.Hue = 1109;
			AddComponent( ac, 0, 0, 27 );
			ac = new AddonComponent( 1176 );
			ac.Hue = 1109;
			AddComponent( ac, 0, 1, 27 );
			ac = new AddonComponent( 1173 );
			ac.Hue = 1109;
			AddComponent( ac, 0, 2, 27 );
			ac = new AddonComponent( 1175 );
			ac.Hue = 1109;
			AddComponent( ac, 1, -4, 27 );
			ac = new AddonComponent( 1175 );
			ac.Hue = 1109;
			AddComponent( ac, 1, -3, 27 );
			ac = new AddonComponent( 1173 );
			ac.Hue = 1109;
			AddComponent( ac, 1, -2, 27 );
			ac = new AddonComponent( 1174 );
			ac.Hue = 1109;
			AddComponent( ac, 1, -1, 27 );
			ac = new AddonComponent( 1174 );
			ac.Hue = 1109;
			AddComponent( ac, 1, 0, 27 );
			ac = new AddonComponent( 1176 );
			ac.Hue = 1109;
			AddComponent( ac, 1, 1, 27 );
			ac = new AddonComponent( 1176 );
			ac.Hue = 1109;
			AddComponent( ac, 1, 2, 27 );
			ac = new AddonComponent( 1174 );
			ac.Hue = 1109;
			AddComponent( ac, 2, -4, 27 );
			ac = new AddonComponent( 1173 );
			ac.Hue = 1109;
			AddComponent( ac, 2, -3, 27 );
			ac = new AddonComponent( 1173 );
			ac.Hue = 1109;
			AddComponent( ac, 2, -2, 27 );
			ac = new AddonComponent( 1175 );
			ac.Hue = 1109;
			AddComponent( ac, 2, -1, 27 );
			ac = new AddonComponent( 1174 );
			ac.Hue = 1109;
			AddComponent( ac, 2, 0, 27 );
			ac = new AddonComponent( 1176 );
			ac.Hue = 1109;
			AddComponent( ac, 2, 1, 27 );
			ac = new AddonComponent( 1175 );
			ac.Hue = 1109;
			AddComponent( ac, 2, 2, 27 );
			ac = new AddonComponent( 1176 );
			ac.Hue = 1109;
			AddComponent( ac, 3, -4, 27 );
			ac = new AddonComponent( 1174 );
			ac.Hue = 1109;
			AddComponent( ac, 3, -3, 27 );
			ac = new AddonComponent( 1174 );
			ac.Hue = 1109;
			AddComponent( ac, 3, -2, 27 );
			ac = new AddonComponent( 1174 );
			ac.Hue = 1109;
			AddComponent( ac, 3, -1, 27 );
			ac = new AddonComponent( 1174 );
			ac.Hue = 1109;
			AddComponent( ac, 3, 0, 27 );
			ac = new AddonComponent( 1176 );
			ac.Hue = 1109;
			AddComponent( ac, 3, 1, 27 );
			ac = new AddonComponent( 1173 );
			ac.Hue = 1109;
			AddComponent( ac, 3, 2, 27 );
			ac = new AddonComponent( 1174 );
			ac.Hue = 1109;
			AddComponent( ac, 4, -4, 27 );
			ac = new AddonComponent( 1174 );
			ac.Hue = 1109;
			AddComponent( ac, 4, -3, 27 );
			ac = new AddonComponent( 1176 );
			ac.Hue = 1109;
			AddComponent( ac, 4, -2, 27 );
			ac = new AddonComponent( 1173 );
			ac.Hue = 1109;
			AddComponent( ac, 4, -1, 27 );
			ac = new AddonComponent( 1174 );
			ac.Hue = 1109;
			AddComponent( ac, 4, 0, 27 );
			ac = new AddonComponent( 1173 );
			ac.Hue = 1109;
			AddComponent( ac, 4, 1, 27 );
			ac = new AddonComponent( 1173 );
			ac.Hue = 1109;
			AddComponent( ac, 4, 2, 27 );
			ac = new AddonComponent( 1174 );
			AddComponent( ac, 5, -4, 27 );
			ac = new AddonComponent( 1176 );
			AddComponent( ac, 5, -3, 27 );
			ac = new AddonComponent( 1174 );
			AddComponent( ac, 5, -2, 27 );
			ac = new AddonComponent( 1174 );
			AddComponent( ac, 5, -1, 27 );
			ac = new AddonComponent( 1176 );
			AddComponent( ac, 5, 0, 27 );
			ac = new AddonComponent( 1175 );
			ac.Hue = 1109;
			AddComponent( ac, 5, 1, 27 );
			ac = new AddonComponent( 1175 );
			ac.Hue = 1109;
			AddComponent( ac, 5, 2, 27 );
			ac = new AddonComponent( 361 );
			ac.Hue = 1109;
			AddComponent( ac, 5, -4, 27 );
			ac = new AddonComponent( 361 );
			ac.Hue = 1109;
			AddComponent( ac, 5, -3, 27 );
			ac = new AddonComponent( 361 );
			ac.Hue = 1109;
			AddComponent( ac, 5, -2, 27 );
			ac = new AddonComponent( 361 );
			ac.Hue = 1109;
			AddComponent( ac, 5, -1, 27 );
			ac = new AddonComponent( 361 );
			ac.Hue = 1109;
			AddComponent( ac, 5, 0, 27 );
			ac = new AddonComponent( 361 );
			ac.Hue = 1109;
			AddComponent( ac, 5, 1, 27 );
			ac = new AddonComponent( 361 );
			ac.Hue = 1109;
			AddComponent( ac, 5, 2, 27 );
			ac = new AddonComponent( 99 );
			ac.Hue = 1109;
			AddComponent( ac, -2, 4, 0 );
			ac = new AddonComponent( 99 );
			ac.Hue = 1109;
			AddComponent( ac, -1, 4, 0 );
			ac = new AddonComponent( 99 );
			ac.Hue = 1109;
			AddComponent( ac, 0, 4, 0 );
			ac = new AddonComponent( 99 );
			ac.Hue = 1109;
			AddComponent( ac, 1, 4, 0 );
			ac = new AddonComponent( 99 );
			ac.Hue = 1109;
			AddComponent( ac, 2, 4, 0 );
			ac = new AddonComponent( 99 );
			ac.Hue = 1109;
			AddComponent( ac, 3, 4, 0 );
			ac = new AddonComponent( 99 );
			ac.Hue = 1109;
			AddComponent( ac, 4, 4, 0 );
			ac = new AddonComponent( 1873 );
			ac.Hue = 1109;
			AddComponent( ac, -2, 5, 0 );
			ac = new AddonComponent( 1873 );
			ac.Hue = 1109;
			AddComponent( ac, -1, 5, 0 );
			ac = new AddonComponent( 1878 );
			ac.Hue = 1109;
			AddComponent( ac, 0, 5, 0 );
			ac = new AddonComponent( 100 );
			ac.Hue = 1109;
			AddComponent( ac, 5, 3, 0 );
			ac = new AddonComponent( 101 );
			ac.Hue = 1109;
			AddComponent( ac, 5, 4, 0 );
			ac = new AddonComponent( 1174 );
			ac.Hue = 1109;
			AddComponent( ac, -2, 3, 7 );
			ac = new AddonComponent( 1174 );
			ac.Hue = 1109;
			AddComponent( ac, -2, 4, 7 );
			ac = new AddonComponent( 1175 );
			AddComponent( ac, -1, 3, 7 );
			ac = new AddonComponent( 1174 );
			ac.Hue = 1109;
			AddComponent( ac, -1, 4, 7 );
			ac = new AddonComponent( 1176 );
			ac.Hue = 1109;
			AddComponent( ac, 0, 3, 7 );
			ac = new AddonComponent( 1173 );
			ac.Hue = 1109;
			AddComponent( ac, 0, 4, 7 );
			ac = new AddonComponent( 1174 );
			AddComponent( ac, 1, 3, 7 );
			ac = new AddonComponent( 1175 );
			AddComponent( ac, 1, 4, 7 );
			ac = new AddonComponent( 1173 );
			AddComponent( ac, 2, 3, 7 );
			ac = new AddonComponent( 1174 );
			AddComponent( ac, 2, 4, 7 );
			ac = new AddonComponent( 1176 );
			ac.Hue = 1109;
			AddComponent( ac, 3, 3, 7 );
			ac = new AddonComponent( 1174 );
			ac.Hue = 1109;
			AddComponent( ac, 3, 4, 7 );
			ac = new AddonComponent( 1176 );
			AddComponent( ac, 4, 3, 7 );
			ac = new AddonComponent( 1175 );
			AddComponent( ac, 4, 4, 7 );
			ac = new AddonComponent( 1175 );
			ac.Hue = 1109;
			AddComponent( ac, 5, 3, 7 );
			ac = new AddonComponent( 1173 );
			AddComponent( ac, 5, 4, 7 );
			ac = new AddonComponent( 352 );
			ac.Hue = 1109;
			AddComponent( ac, 0, 4, 7 );
			ac = new AddonComponent( 355 );
			ac.Light = LightType.ArchedWindowEast;
			ac.Hue = 1109;
			AddComponent( ac, 1, 4, 7 );
			ac = new AddonComponent( 352 );
			ac.Hue = 1109;
			AddComponent( ac, 2, 4, 7 );
			ac = new AddonComponent( 352 );
			ac.Hue = 1109;
			AddComponent( ac, 3, 4, 7 );
			ac = new AddonComponent( 355 );
			ac.Light = LightType.ArchedWindowEast;
			ac.Hue = 1109;
			AddComponent( ac, 4, 4, 7 );
			ac = new AddonComponent( 351 );
			ac.Hue = 1109;
			AddComponent( ac, 5, 3, 7 );
			ac = new AddonComponent( 350 );
			ac.Hue = 1109;
			AddComponent( ac, 5, 4, 7 );
			ac = new AddonComponent( 1173 );
			ac.Hue = 1109;
			AddComponent( ac, -2, 3, 27 );
			ac = new AddonComponent( 1174 );
			AddComponent( ac, -2, 4, 27 );
			ac = new AddonComponent( 1176 );
			ac.Hue = 1109;
			AddComponent( ac, -1, 3, 27 );
			ac = new AddonComponent( 1174 );
			AddComponent( ac, -1, 4, 27 );
			ac = new AddonComponent( 1174 );
			ac.Hue = 1109;
			AddComponent( ac, 0, 3, 27 );
			ac = new AddonComponent( 1173 );
			AddComponent( ac, 0, 4, 27 );
			ac = new AddonComponent( 1174 );
			ac.Hue = 1109;
			AddComponent( ac, 1, 3, 27 );
			ac = new AddonComponent( 1176 );
			AddComponent( ac, 1, 4, 27 );
			ac = new AddonComponent( 1175 );
			ac.Hue = 1109;
			AddComponent( ac, 2, 3, 27 );
			ac = new AddonComponent( 1174 );
			AddComponent( ac, 2, 4, 27 );
			ac = new AddonComponent( 1176 );
			ac.Hue = 1109;
			AddComponent( ac, 3, 3, 27 );
			ac = new AddonComponent( 1174 );
			AddComponent( ac, 3, 4, 27 );
			ac = new AddonComponent( 1176 );
			ac.Hue = 1109;
			AddComponent( ac, 4, 3, 27 );
			ac = new AddonComponent( 1174 );
			AddComponent( ac, 4, 4, 27 );
			ac = new AddonComponent( 1174 );
			AddComponent( ac, 5, 3, 27 );
			ac = new AddonComponent( 1176 );
			AddComponent( ac, 5, 4, 27 );
			ac = new AddonComponent( 362 );
			ac.Hue = 1109;
			AddComponent( ac, -2, 4, 27 );
			ac = new AddonComponent( 362 );
			ac.Hue = 1109;
			AddComponent( ac, -1, 4, 27 );
			ac = new AddonComponent( 362 );
			ac.Hue = 1109;
			AddComponent( ac, 0, 4, 27 );
			ac = new AddonComponent( 362 );
			ac.Hue = 1109;
			AddComponent( ac, 1, 4, 27 );
			ac = new AddonComponent( 362 );
			ac.Hue = 1109;
			AddComponent( ac, 2, 4, 27 );
			ac = new AddonComponent( 362 );
			ac.Hue = 1109;
			AddComponent( ac, 3, 4, 27 );
			ac = new AddonComponent( 362 );
			ac.Hue = 1109;
			AddComponent( ac, 4, 4, 27 );
			ac = new AddonComponent( 361 );
			ac.Hue = 1109;
			AddComponent( ac, 5, 3, 27 );
			ac = new AddonComponent( 360 );
			ac.Hue = 1109;
			AddComponent( ac, 5, 4, 27 );

		}

		public NecroCityHealerAddon( Serial serial ) : base( serial )
		{
		}

		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );
			writer.Write( 0 ); // Version
		}

		public override void Deserialize( GenericReader reader )
		{
			base.Deserialize( reader );
			int version = reader.ReadInt();
		}
	}

	
}
