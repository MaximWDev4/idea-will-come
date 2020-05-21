using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoadingProgressBar : MonoBehaviour
{
        
    public Slider slider;

    private void Update() {
        slider.value = Loader.GetLoadingProgress();
    }
}
