using DG.Tweening;
using UnityEngine;

[RequireComponent(typeof(SpriteRenderer))]
public class RecoloringFigure : FigureChanger
{
    [SerializeField] private Color _color;

    private SpriteRenderer _renderer;

    private void Awake()
    {
        _renderer = GetComponent<SpriteRenderer>();
    }

    private void Start()
    {
        _renderer.DOColor(_color, CycleTime).
            SetEase(Ease.Linear).SetLoops(-1, LoopType.Yoyo);
    }
}