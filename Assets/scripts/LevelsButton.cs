using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CodeMonkey.Utils;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelsButton : MonoBehaviour {

   public int levelNom;
   private Loader.Scene[] scenes = {Loader.Scene.Level, Loader.Scene.Level1, Loader.Scene.Level2, Loader.Scene.Level3, Loader.Scene.Level4, Loader.Scene.Level5, Loader.Scene.Level6, Loader.Scene.Level7};
    public void Single() {
            Debug.Log("Click Main Menu");
            Loader.Load(Loader.Scene.LevelSelect);
    }

    public void Quit() {
        Application.Quit();
    }

    public void GoToLevel(){
        Loader.Load(scenes[levelNom]);
    }
}