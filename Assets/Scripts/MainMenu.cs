using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenu : MonoBehaviour
{

    public Animator transitionsAnim;
    public string sceneName;

    // Update is called once per frame
    public void PlayGame()
    {
        StartCoroutine(LoadScene());
    }

    public void QuitGame()
    {
        Debug.Log("Quit");
        Application.Quit();
    }

    IEnumerator LoadScene()
    {
        transitionsAnim.SetTrigger("end");
        yield return new WaitForSeconds(1.5f);
        SceneManager.LoadScene(sceneName);


    }
}
