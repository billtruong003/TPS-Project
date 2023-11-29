using UnityEngine;

namespace Weapons
{
    public class StatusWeap : MonoBehaviour
    {
        private static float attackDamage;
        private static float magicDamage;
        private static float hP;
        private static float critical;
        private static float criticalDamage;
        private static bool rangeAttack;
        private static int[] level = new int[10] { 20, 40, 60, 80, 100, 110, 120, 130, 140, 150 };
        private static int[] minDamage = new int[10];
        private static int[] maxDamages = new int[10];

        public static float ATK => attackDamage;
        public static float MATK => magicDamage;
        public static float HP => hP;
        public static float CRIT => critical;
        public static float CRITDMG => criticalDamage;
        public static bool RANGE => rangeAttack;

        public static void InitializeSwordStatusData()
        {
            minDamage = new int[10] { 300, 675, 1520, 3420, 7695, 17315, 38960, 87660, 197235, 443780 };
            maxDamages = new int[10] { 450, 1013, 2280, 5130, 11543, 25973, 58440, 131490, 295853, 665670 };
            rangeAttack = false;
        }

        public static StatusWeap SetOneHSword(int levelIndex)
        {
            StatusWeap sttWeap = new();
            if (levelIndex < 0 || levelIndex >= level.Length)
            {
                Debug.LogError("Invalid level index.");
                return null;
            }

            attackDamage = Random.Range(minDamage[levelIndex], maxDamages[levelIndex] + 1);

            if (levelIndex != 0)
            {
                int index = levelIndex - 1;
                magicDamage = Random.Range(minDamage[index], maxDamages[index] + 1);
            }
            else
            {
                magicDamage = Random.Range(minDamage[levelIndex], maxDamages[levelIndex] + 1);
            }
            return sttWeap;
        }
    }
}
