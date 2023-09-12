using Anvil.Elements;
using UnityEngine.UIElements;

namespace Anvil.Editor.Elements
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