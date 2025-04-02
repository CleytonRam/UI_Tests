using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using DG.Tweening;



public class ButtonScaler : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public float size = 1.2f;
    public float duration = 0.3f;

    private Vector3 _defaultScale;

    private Tween _currentTween;

    private void Awake()
    {
        _defaultScale = transform.localScale;
    }
    public void OnPointerEnter(PointerEventData eventData)
    {
        Debug.Log("Enter");
       // transform.localScale = Vector3.one * size;
        _currentTween = transform.DOScale(_defaultScale * size, duration);
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        Debug.Log("Exit");
        _currentTween.Kill();
        transform.localScale = _defaultScale;

    }
}
