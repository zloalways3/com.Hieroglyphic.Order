using System.Threading.Tasks;
using Cysharp.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;
using ZeroSDK.UIBuilder.Core.UIElements;

namespace _project.Scripts
{
    public sealed class BackgroundScreen : thygtfrdsd
    {
        [SerializeField] private Image blur;

        public async UniTask rthjhgfghn(float duration = 0.08f)
        {
            await hjytrtghm(1f, duration);
        }

        public async UniTask rtyujkkmnhgf(float duration = 0.08f)
        {
            await hjytrtghm(0f, duration);
        }

        private async UniTask hjytrtghm(float targetAlpha, float duration)
        {
            float startAlpha = blur.color.a;
            float elapsedTime = 0f;

            while (elapsedTime < duration)
            {
                elapsedTime += Time.deltaTime;
                float newAlpha = Mathf.Lerp(startAlpha, targetAlpha, elapsedTime / duration);
                blur.color = new Color(blur.color.r, blur.color.g, blur.color.b, newAlpha);
                await Task.Yield();
            }

            blur.color = new Color(blur.color.r, blur.color.g, blur.color.b, targetAlpha);
        }
    }
}