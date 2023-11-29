using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace learningAbstract
{
    [CreateAssetMenu(fileName = "RANGE", menuName = "WeaponConfig/RANGE")]
    public class RangeConfig : ScriptableObject
    {
        public float _baseDamage;
        public float _piercingDamage;
        public float _slashingDamage;
        public float _bleedingDamage;
        public float _weaponHP;
        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}