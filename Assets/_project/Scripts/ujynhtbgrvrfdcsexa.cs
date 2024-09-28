using System;
using Cysharp.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;
using ZeroSDK.UIBuilder.Core.UIElements;

namespace _project.Scripts
{
    public sealed class ujynhtbgrvrfdcsexa : thygtfrdsd
    {
        [SerializeField] private Image icon;
        [SerializeField] private float rotSpeed;

        public async UniTask uyhtgrf(float nhgbfvdcs)
        {
        }

        private void Update()
        {
            icon.transform.eulerAngles = Vector3.forward * (Time.time * rotSpeed);
        }
    }
}