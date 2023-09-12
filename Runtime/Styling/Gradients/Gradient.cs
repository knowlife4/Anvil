using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace Anvil.Styling.Gradients
{
    public abstract class Gradient
    {
        protected Gradient(GradientColorKey[] keys)
        {
            InternalGradient = new UnityEngine.Gradient();

            GradientAlphaKey[] alphaKeys = keys.Select(key => new GradientAlphaKey(key.color.a, key.time)).ToArray();

            InternalGradient.SetKeys(keys, alphaKeys);
        }
        
        UnityEngine.Gradient InternalGradient { get; }

        protected abstract Texture2D Generate(UnityEngine.Gradient gradient);

        public Texture2D Texture => Generate(InternalGradient);
    }
}