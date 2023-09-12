using Anvil.Elements;
using UnityEngine.UIElements;

namespace Anvil.Editor.Elements
{
    public class Editor : Element<IMGUIContainer>
    {
        public Editor(UnityEngine.Object obj)
        {
            UnityEditor.Editor.CreateCachedEditor(obj, null, ref cachedEditor);

            VisualElement = new(() => { cachedEditor.OnInspectorGUI(); });
        }

        readonly UnityEditor.Editor cachedEditor;

        protected override IMGUIContainer VisualElement { get; }
    }
}