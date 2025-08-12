using UnityEngine;
using System.Runtime.CompilerServices;
using System.IO;
using Marriuss.SmartLogger.Utils;

namespace Marriuss.SmartLogger.API
{
    public static class Log
    {
        public static void Info(string message, [CallerFilePath] string filePath = "", [CallerMemberName] string callerName = "") =>
            LogMessage(message, filePath, callerName, GlobalColorsDefinition.InfoColor);

        public static void Success(string message, [CallerFilePath] string filePath = "", [CallerMemberName] string callerName = "") =>
            LogMessage(message, filePath, callerName, GlobalColorsDefinition.SuccessColor);

        public static void Warning(string message, [CallerFilePath] string filePath = "", [CallerMemberName] string callerName = "") =>
            LogMessage(message, filePath, callerName, GlobalColorsDefinition.WarningColor);

        public static void Error(string message, [CallerFilePath] string filePath = "", [CallerMemberName] string callerName = "") =>
            LogMessage(message, filePath, callerName, GlobalColorsDefinition.ErrorColor);

        private static void LogMessage(string message, string filePath, string callerName, Color color)
        {
#if UNITY_EDITOR || ENABLE_LOGGER
            string fileName = Path.GetFileName(filePath);

#if UNITY_EDITOR
            message = LoggerUtils.ApplyColor(message, color);
#endif

            Debug.Log($"[{fileName}: {callerName}] {message}");
#endif
        }
    }
}
