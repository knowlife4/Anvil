using UnityEngine;

namespace Anvil.Styling.Gradients
{
    public abstract class LinearGradient : Gradient
    {
        protected LinearGradient(int detail, params GradientColorKey[] keys) : base(keys)
        {
            Detail = detail;
        }

        protected virtual int? ScaleX => null;

        protected virtual int? ScaleY => null;

        int Detail { get; }

        protected override Texture2D Generate(UnityEngine.Gradient gradient)
        {
            Texture2D texture = new(ScaleX ?? Detail, ScaleY ?? Detail, TextureFormat.ARGB32, false)
            {
                filterMode = FilterMode.Bilinear,
                wrapMode = TextureWrapMode.Clamp
            };

            float inv = 1f / (Detail - 1);

            for (int x = 0; x < Detail; x++)
            {
                for (int y = 0; y < Detail; y++)
                {
                    texture.SetPixel(x, y, GenerateLinear(inv, x, y, gradient));
                }
            }
            
            texture.Apply();

            return texture;
        }

        protected abstract Color GenerateLinear(float inv, int x, int y, UnityEngine.Gradient gradient);
    }
}