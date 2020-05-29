using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using CodeMonkey.Utils;
using UnityEngine.SceneManagement;

public class ButtonCreator : MonoBehaviour
{
//    public void CreateButton(){
//        GameObject newButton = new GameObject("New Button", typeof(Image), typeof(Button));
//        newButton.transform.SetParent(canvas.transform);
//        GameObject newText = new GameObject("New Text", typeof(Text));
//        newText.transform.SetParent(newButton.transform);
//        newText.GetComponent<Text>().text = "Заново";
//        newText.GetComponent<Text>().font = newFont;
//       RectTransform rt = newText.GetComponent<RectTransform>();
//        rt.anchorMin = new Vector2(0, 0);
//        rt.anchorMax = new Vector2(1, 1);
//        rt.anchoredPosition = new Vector2(0, 0);
//        rt.sizeDelta = new Vector2(0, 0);
//        newButton.GetComponent<RectTransform>().anchoredPosition = new Vector2(0, -150);
//        newText.GetComponent<Text>().color = new Color(0, 0, 0);
//       newText.GetComponent<Text>().alignment = TextAnchor.MiddleCenter;
//        newButton.GetComponent<Button>().onClick.AddListener(delegate { restart(); });
//    }
   public int levelNom;
   public static bool gameIsPaused;
   public GameObject panel;
   private Loader.Scene[] scenes = {Loader.Scene.Level, Loader.Scene.Level1, Loader.Scene.Level2, Loader.Scene.Level3, Loader.Scene.Level4, Loader.Scene.Level5, Loader.Scene.Level6, Loader.Scene.Level7};

    private void Update() {
      if (Input.GetKeyDown(KeyCode.Escape)){
        if (gameIsPaused){
            unpause();
        } else {
            pause();
        }
      }
    }

    public void pause(){
      panel.SetActive(true);
      Time.timeScale = 0f;
      gameIsPaused = true;
    }

    public void unpause(){
      panel.SetActive(false);
      Time.timeScale = 1f;
      gameIsPaused = false;      
    }

    public void restart(){
      Time.timeScale = 1f;
      Application.LoadLevel(Application.loadedLevel);
    }
    public void loadNext( int levelNom ){
        Time.timeScale = 1f;
        Loader.Load(scenes[levelNom+1]);
    }
    public void Menu(){
        Time.timeScale = 1f;
        Loader.Load(Loader.Scene.LevelSelect);
    }
    public void MainMenu(){
        Time.timeScale = 1f;
        Loader.Load(Loader.Scene.Menu);
    }
    
}
