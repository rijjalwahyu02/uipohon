using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Weapon : MonoBehaviour
{
   
    public void WeaponScene(){
        SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex + 5);
    }

    public void Back(){
        SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex - 5);
    }
}
