using UnityEngine;
using UnityEditor;
using Marriuss.SmartLogger.Utils;

namespace Marriuss.SmartLogger.Editor
{
#if UNITY_EDITOR
    public class ColorsEditor : EditorWindow
    {
        Color _infoColor;
        Color _successColor;
        Color _warningColor;
        Color _errorColor;

        [MenuItem("Tools/SmartLogger/Colors Editor")]
        public static void ShowWindow()
        {
            GetWindow<ColorsEditor>("Color Editor");
        }

        private void OnEnable()
        {
            ColorsDefinition colorsDefinition = UserDataHandler.TryLoadUserColorsDefinition(out ColorsDefinition userColorsDefinition)
                ? userColorsDefinition
                : ColorsDefinition.DefaultColorsDefinition;

            _infoColor = colorsDefinition.InfoColor;
            _successColor = colorsDefinition.SuccessColor;
            _warningColor = colorsDefinition.WarningColor;
            _errorColor = colorsDefinition.ErrorColor;
        }

        void OnGUI()
        {
            _infoColor = EditorGUILayout.ColorField("Info Message Color", _infoColor);
            _successColor = EditorGUILayout.ColorField("Success Message Color", _successColor);
            _warningColor = EditorGUILayout.ColorField("Warning Message Color", _warningColor);
            _errorColor = EditorGUILayout.ColorField("Error Message Color", _errorColor);

            if (GUILayout.Button("Save"))
            {
                UserDataHandler.SaveUserData(new(_infoColor, _successColor, _warningColor, _errorColor));
            }
        }
    }
#endif
}
