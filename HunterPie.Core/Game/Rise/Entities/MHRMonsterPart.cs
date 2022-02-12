﻿using HunterPie.Core.Domain.Interfaces;
using HunterPie.Core.Extensions;
using HunterPie.Core.Game.Environment;
using HunterPie.Core.Game.Rise.Definitions;
using System;

namespace HunterPie.Core.Game.Rise.Entities
{
    public class MHRMonsterPart : IMonsterPart, IEventDispatcher, IUpdatable<MHRPartStructure>
    {
        private float _health;
        private float _flinch;

        public string Id { get; }

        public float Health
        {
            get => _health;
            private set
            {
                if (value != _health)
                {
                    _health = value;
                    this.Dispatch(OnHealthUpdate, this);
                }
            }
        }

        public float MaxHealth { get; private set; }

        public float Flinch 
        { 
            get => _flinch; 
            private set
            {
                if (value != _flinch)
                {
                    _flinch = value;
                    this.Dispatch(OnFlinchUpdate, this);
                }
            }    
        }

        public float MaxFlinch { get; private set; }

        public float Tenderize => 0;
        public float MaxTenderize => 0;


        public event EventHandler<IMonsterPart> OnHealthUpdate;
        public event EventHandler<IMonsterPart> OnBreakCountUpdate;
        public event EventHandler<IMonsterPart> OnTenderizeUpdate;
        public event EventHandler<IMonsterPart> OnFlinchUpdate;

        public MHRMonsterPart(string id)
        {
            Id = id;
        }

        void IUpdatable<MHRPartStructure>.Update(MHRPartStructure data)
        {
            MaxHealth = data.MaxHealth;
            Health = data.Health;
            MaxFlinch = data.MaxFlinch;
            Flinch = data.Flinch;

        }
    }
}
