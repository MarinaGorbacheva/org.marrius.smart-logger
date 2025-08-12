using UnityEngine;

namespace Marriuss.SmartLogger.Utils
{
    public static class GlobalColorsDefinition
    {
        public static Color InfoColor { get; private set; }
        public static Color SuccessColor { get; private set; }
        public static Color WarningColor { get; private set; }
        public static Color ErrorColor { get; private set; }

        static GlobalColorsDefinition()
        {
            ColorsDefinition colorsDefinition = UserDataHandler.TryLoadUserColorsDefinition(out ColorsDefinition userColorsDefinition)
                ? userColorsDefinition
                : ColorsDefinition.DefaultColorsDefinition;

            InfoColor = colorsDefinition.InfoColor;
            SuccessColor = colorsDefinition.SuccessColor;
            WarningColor = colorsDefinition.WarningColor;
            ErrorColor = colorsDefinition.ErrorColor;
        }
    }
}
