using DG.Tweening;
using UnityEngine;

public class MovingSphere : FigureChanger
{
    private void Start()
    {
        transform.DOMove(transform.position + Vector3.forward * ActionScaleMultiplier, CycleTime).
            SetEase(Ease.Linear).
            SetLoops(-1, LoopType.Yoyo);
    }
}