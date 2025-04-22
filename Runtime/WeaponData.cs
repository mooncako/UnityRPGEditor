using UnityEngine;

namespace UnityRPGEditor
{
    [CreateAssetMenu(menuName = "RPGEditor/New Weapon")]
    public class WeaponData : ItemData
    {
        [field: SerializeField]
        public int Damage { get; private set; } = 5;

        [field: SerializeField]
        public float AttackSpeed { get; private set; } = 1f;

        [field: SerializeField]
        public float Range { get; private set; } = 1.5f;

        [field: SerializeField]
        public int Durability { get; private set; } = 100;
    }

    public enum ENDamageType
    {
        Physical,
        Fire,
        Cold,
        Lightning,
        Necrotic,
        Void,
        True
    }
}
