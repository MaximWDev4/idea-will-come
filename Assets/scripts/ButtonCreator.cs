using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonCreator : MonoBehaviour
{
    public Canvas canvas;
    public Font newFont;

    public void CreateButton(){
        GameObject newButton = new GameObject("New Button", typeof(Image), typeof(Button));
        newButton.transform.SetParent(canvas.transform);
        GameObject newText = new GameObject("New Text", typeof(Text));
        newText.transform.SetParent(newButton.transform);
        newText.GetComponent<Text>().text = "Заново";
        newText.GetComponent<Text>().font = newFont;
        RectTransform rt = newText.GetComponent<RectTransform>();
        rt.anchorMin = new Vector2(0, 0);
        rt.anchorMax = new Vector2(1, 1);
        rt.anchoredPosition = new Vector2(0, 0);
        rt.sizeDelta = new Vector2(0, 0);
        newButton.GetComponent<RectTransform>().anchoredPosition = new Vector2(0, -150);
        newText.GetComponent<Text>().color = new Color(0, 0, 0);
        newText.GetComponent<Text>().alignment = TextAnchor.MiddleCenter;
        newButton.GetComponent<Button>().onClick.AddListener(delegate { restart(); });
    }

    void restart(){
      Application.LoadLevel (Application.loadedLevel);
    }
}
