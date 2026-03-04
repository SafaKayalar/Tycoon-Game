using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Item : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler, IDragHandler , IPointerDownHandler, IPointerUpHandler
{
    private RectTransform recTransform;
    private GameObject item;


    [Header ("Visuals")]
    [SerializeField] private TMP_Text priceText;
    [SerializeField] private Image itemImage;
    [SerializeField] private ItemData itemData;
    private BuySystem buySystem;

    [SerializeField] CanvasGroup magazaCanvasGroup;



    private void Awake()
    {
        recTransform = gameObject.GetComponent<RectTransform>();
        SetVisuals();
        buySystem = GameObject.Find("BuySystem").GetComponent<BuySystem>();

    }

    void SetVisuals()
    {
        itemImage.sprite = itemData.itemSprite;
        priceText.text = $"{itemData.price}";
        item = itemData.item;
    }

    void IPointerEnterHandler.OnPointerEnter(PointerEventData eventData)
    {
        recTransform.DOScale(Vector3.one * 1.1f, 0.1f);
    }

    void IPointerExitHandler.OnPointerExit(PointerEventData eventData)
    {
        recTransform.DOScale(Vector3.one, 0.1f);
    }



    void IPointerDownHandler.OnPointerDown(PointerEventData eventData)
    {
        item = Instantiate(item,recTransform.position,Quaternion.identity);
        magazaCanvasGroup.alpha = 0.0f;
    }

    void IDragHandler.OnDrag(PointerEventData eventData)
    {
        Vector3 worldPos = Camera.main.ScreenToWorldPoint(new Vector3(eventData.position.x, eventData.position.y, 10f));
        item.transform.position = worldPos;
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        magazaCanvasGroup.alpha = 1.0f;
    }

}
