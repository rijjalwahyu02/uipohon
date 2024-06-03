using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class MusicControler : MonoBehaviour
{
    public static MusicControler Instance{ get; set; }

    public AudioSource audioDefault;
    public bool[] isMusicStop;
    public bool isStop;
    
    private void Awake()
    {
        DontDestroyOnLoad(gameObject);

        if (Instance == null)
        {
            Instance = this;
        }
        else 
        {
            Destroy(gameObject);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (isStop == false)
        {
            PauseMusic();
        }
        else //true
        {
            ContinueMusic();
        }
        
    }
    void PauseMusic()
    {
        for (int i = 0; i < isMusicStop.Length; i++)
        {
            if(isMusicStop[i] == true && SceneManager.GetActiveScene().buildIndex == i)
            {
                audioDefault.Pause();
                isStop = true;
                Debug.Log("pause musik");
                break;

            }  

        }
    }
        void ContinueMusic()
        {
            for (int i = 0; i < isMusicStop.Length; i++)
            {
            if(isMusicStop[i] == false && SceneManager.GetActiveScene().buildIndex == i)
            {
                audioDefault.Play();
                isStop = false;
                Debug.Log("continue musik");
                break;

            }  

            }
        }      
}

