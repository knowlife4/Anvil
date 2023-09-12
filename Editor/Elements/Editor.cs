using Anvil.Elements;
using UnityEngine;
using UnityEngine.UIElements;

namespace Anvil.Editor.Elements
{
    public class Editor : Element<IMGUIContainer>
    {
        public Editor(UnityEngine.Object obj) => Obj = obj;

        Object Obj { get; }

        UnityEditor.Editor cachedEditor;
        UnityEditor.Editor CachedEditor
        {
            get
            {
                if(cachedEditor == null) UnityEditor.Editor.CreateCachedEditor(Obj, null, ref cachedEditor);
                return cachedEditor;
            }
        }

        protected override IMGUIContainer VisualElement => new(() => { if(cachedEditor != null) cachedEditor.OnInspectorGUI(); });
    }
}