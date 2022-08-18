using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Game_reset : MonoBehaviour
{
  //  public GameObject[] Scene_objects;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
       
            if (other.gameObject.tag == "Player")
            {                   
                SceneManager.LoadScene("Game_over");             
            }
        
    }

    public void Game_restart()
    {
        SceneManager.LoadScene("Main_Scene");
    }

    public void Quit_Game() 
    {
        Application.Quit();
    }
}
