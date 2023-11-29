using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace learningAbstract
{
    [CreateAssetMenu(fileName = "WEAPON", menuName = "WeaponConfig/WEAPON")]
    public class WeaponConfig : ScriptableObject
    {
        public float _baseDamage;
        public float _piercingDamage;
        public float _slashingDamage;
        public float _bleedingDamage;
        public float _weaponHP;
        public (float, float, float, float, float) GetStat()
        {
            return (_baseDamage, _piercingDamage, _slashingDamage, _bleedingDamage, _weaponHP);
        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}