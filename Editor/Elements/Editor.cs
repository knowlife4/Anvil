using Anvil.Elements;
using UnityEngine;
using UnityEngine.UIElements;

namespace Anvil.Editor.Elements
{
    public class Editor : Element<IMGUIContainer>
    {
        public Editor(UnityEngine.Object obj)
        {
            EmbeddedEditor = UnityEditor.Editor.CreateEditor(obj);
            VisualElement = new IMGUIContainer(() => { EmbeddedEditor.OnInspectorGUI(); });
        }

        UnityEditor.Editor EmbeddedEditor { get; }

        protected override IMGUIContainer VisualElement { get; }
    }
}