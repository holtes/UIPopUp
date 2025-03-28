using UnityEngine;
using UniRx;
using DG.Tweening;

namespace _Project.Develop.Runtime.Views.Animations
{
    public class StarAnim : MonoBehaviour
    {
        [SerializeField] private RectTransform _rect;
        [SerializeField] private float moveAmount = 10f;
        [SerializeField] private float duration = 0.5f;

        private void Start() => AnimateStar();

        private void AnimateStar()
        {
            var startPosition = _rect.anchoredPosition;

            Observable
                .Interval(System.TimeSpan.FromSeconds(duration))
                .Subscribe(_ =>
                {
                    var destination = startPosition +
                    new Vector2(Random.Range(-moveAmount, moveAmount), Random.Range(-moveAmount, moveAmount));
                    _rect.DOAnchorPos(destination, duration / 2)
                        .SetEase(Ease.InOutSine)
                        .SetLoops(2, LoopType.Yoyo);
                })
                .AddTo(this);
        }
    }
}

