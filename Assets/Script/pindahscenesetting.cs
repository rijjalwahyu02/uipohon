using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class pindahscenesetting : MonoBehaviour
{
   
    public void PindahScene(){
        SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex + 2);
    }

    public void Back(){
        SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex - 2);
    }
}
