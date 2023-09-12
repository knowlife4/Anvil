using System.Collections;
using System.Collections.Generic;
using Anvil.Styling;
using UnityEngine.UIElements;

namespace Anvil.Elements
{
    public class Element : Element<VisualElement>
    {
        public Element(params Style[] styles) => Style(styles);

        protected override VisualElement VisualElement { get; } = new();
    }

    public abstract class Element<TVisualElement> : Node where TVisualElement : VisualElement
    {
        public Node Style(params IOption[] styleOptions)
        {
            Style style = new();

            foreach (IOption option in styleOptions)
            {
                style.Add(option);
            }

            return Style(style);
        }

        public Node Style(params Style[] styles)
        {
            foreach (Style style in styles)
            {
                style.Apply(VisualElement);
            }

            return this;
        }

        public Element<TVisualElement> Event<T>(EventCallback<T> callback, bool trickleDown = false) where T : EventBase<T>, new()
        {
            VisualElement.RegisterCallback<T>(callback, trickleDown ? TrickleDown.TrickleDown : TrickleDown.NoTrickleDown);
            return this;
        }

        public T Get<T>(out T node) where T : Node
        {
            node = this as T;
            return node;
        }
        
        public override VisualElement GetVisualElement() => VisualElement;

        public override void Add(Node element)
        {
            Children.Add(element);
            VisualElement.Add(element.GetVisualElement());
        }

        protected abstract TVisualElement VisualElement { get; }
    }

    public abstract class Node : IEnumerable<Node>
    {
        internal Node() { }

        public abstract VisualElement GetVisualElement();

        protected List<Node> Children { get; } = new();

        public virtual void Add(Node element) => Children.Add(element);

        public IEnumerator<Node> GetEnumerator() => Children.GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}