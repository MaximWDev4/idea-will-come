using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;

public class GraphicsController : MonoBehaviour
{
    public Dropdown dropdown; 
    // Start is called before the first frame update
    void Start()
    {
        dropdown.ClearOptions();
        dropdown.AddOptions(QualitySettings.names.ToList());
        dropdown.value = QualitySettings.GetQualityLevel();
    }

    // Update is called once per frame
    public void ChangeQuality(){
        QualitySettings.SetQualityLevel(dropdown.value);
    }
}
