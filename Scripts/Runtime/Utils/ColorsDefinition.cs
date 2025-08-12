using System;
using UnityEngine;

namespace Marriuss.SmartLogger.Utils
{
    [Serializable]
    public struct ColorsDefinition
    {
        public readonly static ColorsDefinition DefaultColorsDefinition = new(Color.white, Color.green, Color.yellow, Color.red);

        [SerializeField] private Color _infoColor;
        [SerializeField] private Color _successColor;
        [SerializeField] private Color _warningColor;
        [SerializeField] private Color _errorColor;

        public readonly Color InfoColor => _infoColor;
        public readonly Color SuccessColor => _successColor;
        public readonly Color WarningColor => _warningColor;
        public readonly Color ErrorColor => _errorColor;

        public ColorsDefinition(Color infoColor, Color successColor, Color warningColor, Color errorColor)
        {
            _infoColor = infoColor;
            _successColor = successColor;
            _warningColor = warningColor;
            _errorColor = errorColor;
        }
    }
}
