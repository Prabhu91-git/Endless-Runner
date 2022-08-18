using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Artifact_Manager : MonoBehaviour
{
  
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
            Destroy(gameObject);
            
        }
        Score_checker.instance.score_update();
     
    }



}
