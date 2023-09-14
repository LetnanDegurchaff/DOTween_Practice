using DG.Tweening;
using UnityEngine;

public class ScalingCapsule : FigureChanger
{
    private float _scaleModifier = 1.2f;

    private void Start()
    {
        transform.DOScale(_scaleModifier, CycleTime).
            SetEase(Ease.Linear).
            SetLoops(-1, LoopType.Yoyo);
    }
}