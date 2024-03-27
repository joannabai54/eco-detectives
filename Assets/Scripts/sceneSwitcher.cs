using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sceneSwitcher : MonoBehaviour
{
    public static string previousScene;
    public sceneSwitcher cue;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void SwitchScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

    public void openJournal()
    {
        cue.SwitchScene("Journal");
    }

    public void openLandscape()
    {
        cue.SwitchScene("Landscape");
    }
}

