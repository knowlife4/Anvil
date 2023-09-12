using System;
using UnityEngine;
using UnityEditor;

namespace Anvil.Editor.Interfaces
{
    public abstract class Popup : WindowInterface
    {
        protected static void Open<T>(Vector2? windowSize = null) where T : WindowInterface
        {
            T window = CreateInstance<T>();

            Vector2 size = windowSize ?? new(300, 180);
            
            Vector2 position = new((Screen.currentResolution.width - size.x) / 2, (Screen.currentResolution.height - size.y) / 2);
            window.position = new Rect(position, size);

            window.ShowPopup();
        }

        void OnLostFocus() => Close();
    }
}