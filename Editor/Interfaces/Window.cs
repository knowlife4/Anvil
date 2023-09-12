using UnityEngine;

namespace Anvil.Editor.Interfaces
{
    public abstract class Window : WindowInterface
    {
        protected static void Open<T>(string name = "") where T : WindowInterface
        {
            T window = GetWindow<T>();

            window.titleContent = new GUIContent(name);
        }
    }
}