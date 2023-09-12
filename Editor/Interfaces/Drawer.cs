using Anvil.Elements;
using UnityEditor;
using UnityEngine.UIElements;

namespace Anvil.Editor.Interfaces
{
    public abstract class Drawer : PropertyDrawer, IInterface
    {
        protected SerializedProperty Property { get; private set; }

        public override VisualElement CreatePropertyGUI(SerializedProperty property)
        {
            Property = property;

            VisualElement root = Root.GetVisualElement();
            root.style.flexGrow = 1;

            return root;
        }

        public abstract Element Root { get; }
    }
}