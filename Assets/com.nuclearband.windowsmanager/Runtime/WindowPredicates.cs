#nullable enable
using UnityEngine;

namespace NuclearBand
{
    public static class WindowPredicates
    {
        public static bool IsPortrait()
        {
#if UNITY_EDITOR
            return Screen.width < Screen.height;
#endif
#pragma warning disable CS0162
            return Screen.orientation == ScreenOrientation.Portrait;
#pragma warning restore CS0162
        }

        public static bool IsLandscape()
        {
#if UNITY_EDITOR
            return Screen.width >= Screen.height;
#endif
#pragma warning disable CS0162
            return Screen.orientation == ScreenOrientation.Landscape;
#pragma warning restore CS0162
        }

        public static bool IsLandscape43()
        {
            return Mathf.Approximately(Screen.width / (1.0f * Screen.height), 4.0f / 3.0f);
        }
    }
}
