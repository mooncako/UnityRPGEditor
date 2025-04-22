using UnityEngine;
using Sirenix.OdinInspector;

namespace UnityRPGEditor
{
    public abstract class ItemData : ScriptableObject
    {
        [field: SerializeField]
        public string Name { get; private set; }

        [field: SerializeField]
        public string Description { get; private set; }

        [field: SerializeField, PreviewField(Height = 50)]
        public Sprite Icon { get; private set; }

        [field: SerializeField, SuffixLabel("Gold", true)]
        public int Value { get; private set; }

        [field: SerializeField, SuffixLabel("kg", true)]
        public float Weight { get; private set; }

        [field: SerializeField]
        public ENItemRarity Rarity { get; private set; } = ENItemRarity.Common;
    }

    public enum ENItemRarity
    {
        Junk,
        Common,
        Uncommon,
        Magic,
        Rare,
        Epic,
        Legendary,
        Mythic
    }
}
