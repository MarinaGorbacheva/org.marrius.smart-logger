using UnityEngine;
using UnityEditor;

namespace Marriuss.SmartLogger.Utils
{
    public class ColorsDefinitionUserData : ScriptableObject
    {
        [SerializeField, HideInInspector] private ColorsDefinition _colorsDefinition = ColorsDefinition.DefaultColorsDefinition;

        public ColorsDefinition ColorsDefinition => _colorsDefinition;

        internal void UpdateData(ColorsDefinition colorsDefinition)
        {
            _colorsDefinition = colorsDefinition;

#if UNITY_EDITOR
            EditorUtility.SetDirty(this);
            AssetDatabase.SaveAssets();
            AssetDatabase.Refresh();
#endif
        }
    }
}
