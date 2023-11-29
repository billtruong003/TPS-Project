using System;
using NaughtyAttributes;
using UnityEngine;
namespace Weapons
{
    public class BaseWeap : MonoBehaviour
    {
        [SerializeField] private LevelLimit levelLimit;
        [SerializeField] private WeapType type;
        [SerializeField] private float attackDamange;
        [SerializeField] private float magicDamage;
        [SerializeField] private float hP;
        [SerializeField] private float critical;
        [SerializeField] private float criticalDamage;
        [SerializeField] private bool rangeAttack;

        [Button]
        private void Init()
        {

        }
        public void InitWeap()
        {
            switch (type)
            {
                case (WeapType.ONEHSWORD):
                    SetupStatus(StatusWeap.SetOneHSword((int)levelLimit));

                    break;
            }

        }
        private void SetupStatus(StatusWeap statusWeap)
        {

        }
    }

}
