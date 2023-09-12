using System;
using UnityEngine.UIElements;

namespace Anvil.Elements.Functional
{
    public class Custom : Element
    {
        public Custom(Func<VisualElement> function) => Function = function;

        Func<VisualElement> Function { get; }

        protected override VisualElement VisualElement => Function.Invoke();
    }
}