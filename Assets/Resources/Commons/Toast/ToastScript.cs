using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;
using System;
using DG.Tweening;

public class Toast : MonoBehaviour
{
    // Use this for initialization
    void Start()
    {
    }

    public static GameObject show(string text)
    {
        GameObject prefab = Resources.Load("Commons/Toast/Toast") as GameObject;
        GameObject obj = MonoBehaviour.Instantiate(prefab, GameObject.Find("Canvas").transform);
        obj.transform.Find("Text").GetComponent<Text>().text = text;
        
        obj.GetComponent<RectTransform>().sizeDelta = new Vector2(text.Length * 35, 60);

        Sequence seq = DOTween.Sequence();
        seq.Append(obj.GetComponent<Image>().rectTransform.DOAnchorPos(new Vector2(0, 250), 1.0f))
           .Append(obj.GetComponent<Image>().rectTransform.DOAnchorPos(new Vector3(0, 250),0.7f)).SetLoops(0).Play().OnComplete(()=>
           {
               GameObject.Destroy(obj);
           });

        return obj;
    }
}