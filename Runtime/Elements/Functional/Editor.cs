using UnityEngine.UIElements;

namespace Anvil.Elements.Functional
{
    public class Editor : Element<IMGUIContainer>
    {
        public Editor(UnityEngine.Object obj)
        {
            UnityEditor.Editor editor = UnityEditor.Editor.CreateEditor(obj);

            VisualElement = new(() => { editor.OnInspectorGUI(); });
        }

        protected override IMGUIContainer VisualElement { get; }
    }
}