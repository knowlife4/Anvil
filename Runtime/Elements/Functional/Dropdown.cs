using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

namespace Anvil.Elements.Functional
{
    public class Dropdown<T> : Element<PopupField<T>>
    {
        public Dropdown(params T[] options) : this((IEnumerable<T>)options) { }

        public Dropdown(IEnumerable<T> options) => VisualElement = new("", new(options), 0);

        public T Selected => VisualElement.value;

        protected override PopupField<T> VisualElement { get; }
    }
}