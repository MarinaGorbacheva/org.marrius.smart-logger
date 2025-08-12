using System.IO;
using UnityEngine;
using UnityEditor;

namespace Marriuss.SmartLogger.Utils
{
    public static class UserDataHandler
    {
        private const string DirectoryName = "SmartLogger";
        private const string FileName = "ColorsDefinitionUserData";

        public static bool TryLoadUserColorsDefinition(out ColorsDefinition userColorsDefinition)
        {
            var userData = LoadUserData();

            if (userData != null)
            {
                userColorsDefinition = userData.ColorsDefinition;
                return true;
            }
            else
            {
                userColorsDefinition = new();
                return false;
            }
        }

        public static void SaveUserData(ColorsDefinition colorsDefinition)
        {
            string folderPath = Path.Combine("Assets", "Resources", DirectoryName);

#if UNITY_EDITOR
           var userData = LoadUserData();

            if (userData == null)
            {
                userData = ScriptableObject.CreateInstance<ColorsDefinitionUserData>();

                if (Directory.Exists(folderPath) == false)
                    Directory.CreateDirectory(folderPath);

                AssetDatabase.CreateAsset(userData, Path.Combine(folderPath, FileName + ".asset"));
                AssetDatabase.SaveAssets();
                AssetDatabase.Refresh();
            }

            userData.UpdateData(colorsDefinition);
#endif
        }

        private static ColorsDefinitionUserData LoadUserData() => Resources.Load<ColorsDefinitionUserData>(Path.Combine(DirectoryName, FileName));
    }
}
