using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainManager : MonoBehaviour
{
    
    // This allows to access MainManager object form any other script
    public static MainManager Instance;

    // Color selected
    public Color TeamColor;


    // Called when the object is created
    private void Awake() {

        if (Instance != null) {
            Destroy(gameObject);
            return;
        }

        Instance = this;
        DontDestroyOnLoad(gameObject);
    }

}
