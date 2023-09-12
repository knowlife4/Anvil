using Anvil.Elements;
using UnityEditor.UIElements;
using UnityEngine.UIElements;

namespace Anvil.Editor.Elements
{
    public class Editor : Element
    {
        public Editor(UnityEngine.Object obj)
        {
            UnityEditor.Editor editor = UnityEditor.Editor.CreateEditor(obj);
            VisualElement inspector = editor.CreateInspectorGUI();
            inspector.Bind(editor.serializedObject);

            VisualElement = inspector;
        }

        protected override VisualElement VisualElement { get; }
    }
}