using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneButtonsChanger : MonoBehaviour
{
   public void Retry()
    {
        SceneManager.LoadScene("MainMenu", LoadSceneMode.Single);
    }

    public void StartB()
    {
        SceneManager.LoadScene("QuestionsScene");
    }
    public void Quit()
    {
	     Application.Quit();

    }


}
