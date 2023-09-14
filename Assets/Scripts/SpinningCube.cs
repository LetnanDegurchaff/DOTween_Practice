using DG.Tweening;
using UnityEngine;

public class SpinningCube : FigureChanger
{
    private float _rotateAngle = 360;

    private void Start()
    {
        transform.DORotate(new Vector3(0, _rotateAngle, 0) * ActionScaleMultiplier, CycleTime, RotateMode.WorldAxisAdd).
            SetEase(Ease.Linear).
            SetLoops(-1, LoopType.Restart);
    }
}