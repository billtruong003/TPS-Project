using System.Collections;
using System.Collections.Generic;
using NaughtyAttributes;
using UnityEngine;

namespace learningAbstract
{
    public abstract class WeaponBase : MonoBehaviour
    {
        public float _baseDamage;
        public float _piercingDamage;
        public float _slashingDamage;
        public float _bleedingDamage;
        public float _weaponHP;

        public void SetupItem(float _baseDamage, float _piercingDamage, float _slashingDamage, float _bleedingDamage, float _weaponHP)
        {
            this._baseDamage = _baseDamage;
            this._piercingDamage = _piercingDamage;
            this._slashingDamage = _slashingDamage;
            this._bleedingDamage = _bleedingDamage;
            this._weaponHP = _weaponHP;
        }


        public virtual void Attack()
        {
            Debug.Log("Attack");
        }
    }
}
