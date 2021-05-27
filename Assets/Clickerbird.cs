using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;


public class Clickerbird : MonoBehaviour,IPointerClickHandler
{
    SpriteRenderer MainSpriteRenderer;
    [SerializeField] Text countText;
    [SerializeField] Sprite Piko2;
    int count=0;

    private void Start()
    {
        countText.text = "";
    }
    public void OnPointerClick(PointerEventData eventData)
    {
        count++;
        countText.text = count + "ぴこ！";

        if (count >= 15)
        {
            MainSpriteRenderer.sprite = Piko2;
        }
    }
}
