using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class SceneChange : MonoBehaviour
{
    public void GoPlay()
    {
        SceneManager.LoadScene("Stage01");
    }
}
