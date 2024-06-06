using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class DataManager : MonoBehaviour
{
    public static DataManager Instance;
    public string userName;

    private void Awake()
    {
        // start of new code
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }
        // end of new code

        Instance = this;
        DontDestroyOnLoad(gameObject);
    }
}
