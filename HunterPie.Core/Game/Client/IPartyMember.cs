﻿using HunterPie.Core.Game.Enums;
using System;

namespace HunterPie.Core.Game.Client
{
    public interface IPartyMember
    {

        public string Name { get; }
        public int Damage { get; }
        public Weapon Weapon { get; }
        public int Slot { get; }
        public bool IsMyself { get; }

        public event EventHandler<IPartyMember> OnDamageDealt;
        public event EventHandler<IPartyMember> OnWeaponChange;
    }
}
