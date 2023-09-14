using DG.Tweening;
using UnityEngine;

public class LoopingMovingSpinningFigure : FigureChanger
{
    [SerializeField] private float _speed = 3;

    private float _rotateAngle = 360;
    private float _scaleModifier = 1.2f;

    private void Start()
    {
        transform.DORotate(new Vector3(0, _rotateAngle, 0) * ActionScaleMultiplier, CycleTime, RotateMode.WorldAxisAdd).
            SetEase(Ease.Linear).SetLoops(-1, LoopType.Restart);

        transform.DOScale(_scaleModifier * ActionScaleMultiplier, CycleTime).
            SetEase(Ease.Linear).SetLoops(-1, LoopType.Yoyo);
    }

    private void Update()
    {
        transform.Translate(Vector3.forward * _speed * Time.deltaTime);
    }
}