using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Text))]
public class ChangingText : FigureChanger
{
    private Text _text;

    private void Awake()
    {
        _text = GetComponent<Text>();
    }

    private void Start()
    {
        Sequence sequence = DOTween.Sequence();

        sequence.Append(
            _text.DOText(
                _text.text.ToUpper(), CycleTime).SetEase(Ease.Linear));

        sequence.Append(
            _text.DOText(
                InvertText(_text.text).ToUpper(), CycleTime).SetRelative().SetEase(Ease.Linear));

        sequence.Append(
            _text.DOText(
                _text.text, CycleTime, true, ScrambleMode.All).SetEase(Ease.Linear));

        sequence.SetLoops(-1, LoopType.Restart);
    }

    private string InvertText(string text)
    {
        string newText = string.Empty;

        foreach (char symbol in text)
            newText = symbol + newText;

        return newText;
    }
}