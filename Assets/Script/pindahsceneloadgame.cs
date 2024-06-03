using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class pindahsceneloadgame : MonoBehaviour
{
   
    public void PindahScene(){
        SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex + 3);
    }

    public void Back(){
        SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex - 3);
    }
}
