using Anvil.Elements;
using UnityEditor;
using UnityEngine.UIElements;

namespace Anvil.Editor.Interfaces
{
    public abstract class WindowInterface : EditorWindow, IInterface
    {
        public void CreateGUI()
        {
            VisualElement root = Root.GetVisualElement();
            root.style.flexGrow = 1;
            rootVisualElement.style.flexGrow = 1;
            rootVisualElement.Add(root);
        }

        public abstract Element Root { get; }
    }
}