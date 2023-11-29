using System.Collections;
using System.Collections.Generic;
using NaughtyAttributes;
using UnityEngine;

namespace learningAbstract
{
    public enum WeapType
    {
        MELEE,
        RANGE,
    }
    public class WeaponApply : WeaponBase
    {
        [SerializeField] private WeapType type;

        [SerializeField] private WeaponConfig weaponStat;
        private string PathConfig = "WeapConfig/";

        [Button]
        public void SetupWeap()
        {
            weaponStat = Resources.Load<WeaponConfig>($"{PathConfig}{type.ToString()}");
            SetupItem
            (
                weaponStat._baseDamage,
                weaponStat._piercingDamage,
                weaponStat._slashingDamage,
                weaponStat._bleedingDamage,
                weaponStat._weaponHP
            );
        }

        [Button]
        public override void Attack()
        {
            Debug.Log($"Attack Base: {_baseDamage}");
            Debug.Log($"Piercing Damage: {_piercingDamage}");
            Debug.Log($"Slashing Damage: {_slashingDamage}");
            Debug.Log($"Bleeding Damage: {_bleedingDamage}");
            Debug.Log($"Weapon Hp: {_weaponHP}");
        }
        // Update is called once per frame
        void Update()
        {

        }
    }
}
