using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mission : MonoBehaviour
{
   
    public void MissionScene(){
        SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex + 4);
    }

    public void Back(){
        SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex - 4);
    }
}
