using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ButtonTransition : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler, IPointerDownHandler, IPointerUpHandler, IPointerClickHandler
{
    public Color32 normalColor = Color.white;
    public Color32 hoverColor = Color.grey;
    public Color32 downColor = Color.white;

    private Image image = null;

    public void Awake()
    {
        image = GetComponent<Image>();
    }


    public void OnPointerClick(PointerEventData eventData)
    {
        image.color = hoverColor;
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        image.color = downColor;

    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        image.color = hoverColor;
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        image.color = normalColor;
    }

    public void OnPointerUp(PointerEventData eventData)
    {
       
    }

}
