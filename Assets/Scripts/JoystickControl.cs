using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class JoystickControl : MonoBehaviour, IPointerDownHandler, IPointerUpHandler, IDragHandler
{
    private Image outerImage;
    private Image centerImage;
    public float offset;
    public Vector2 InputDir{
        set; 
        get;
    }

    void Start()
    {
        //Debug.Log(transform.GetChild(0).GetComponent<Image>());
        outerImage = transform.GetChild(0).GetComponent<Image>();
        centerImage = transform.GetChild(1).GetComponent<Image>();
        InputDir = Vector2.zero;
    }


    public void OnDrag(PointerEventData eventData)
    {
        Vector2 pos = Vector2.zero;
        float outerImageSizeX = outerImage.rectTransform.sizeDelta.x;
        float outerImageSizeY = outerImage.rectTransform.sizeDelta.y;
        if(RectTransformUtility.ScreenPointToLocalPointInRectangle(outerImage.rectTransform, eventData.position, eventData.pressEventCamera, out pos))
        {
            pos.x /= outerImageSizeX;
            pos.y /= outerImageSizeY;
            InputDir = new Vector2(pos.x, pos.y);
            InputDir = InputDir.magnitude >1 ? InputDir.normalized : InputDir;
            centerImage.rectTransform.anchoredPosition = new Vector2(InputDir.x * (outerImageSizeX/offset), InputDir.y * (outerImageSizeY/offset));
            //Debug.Log(InputDir);
        }
    }


    public void OnPointerDown(PointerEventData eventData)
    {
        OnDrag(eventData);
    }


    public void OnPointerUp(PointerEventData eventData)
    {
        InputDir = Vector2.zero;
        centerImage.rectTransform.anchoredPosition = Vector2.zero;
    }
}
