using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public TMP_InputField userNameInput;
    public TextMeshProUGUI bestScore;

    private void Start()
    {
        DataManager.Instance.LoadBestScore();

        bestScore.text = "Best Score: " + DataManager.Instance.bestScore;
        userNameInput.onEndEdit.AddListener(delegate { UpdateText(); }) ;
    }

    // Start is called before the first frame update
    public void StartGame()
    {
        SceneManager.LoadScene(1);
    }

    public void ExitApplication()
    {
        #if UNITY_EDITOR
            EditorApplication.ExitPlaymode();
        #else
            Application.Quit(); // original code to quit Unity player
        #endif
    }

    void UpdateText()
    {
        if (userNameInput != null)
        {
            DataManager.Instance.userName = userNameInput.text;
        }
    }

}
