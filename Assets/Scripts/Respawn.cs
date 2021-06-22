using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Respawn : MonoBehaviour
{

    public void LoadtheScene()
    {
        SceneManager.LoadScene(0);
    }
}
