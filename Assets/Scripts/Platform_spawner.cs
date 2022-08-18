using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform_spawner : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject platfrom;
    Vector3 spawn_pos;
    GameObject temp;

    public static Platform_spawner instance;
    private void Awake()
    {
        instance = this;
    }
    void Start()
    {
        for (int i = 0; i < 20; i++)
        {
            spawn_platform();
        }
    }

    // Update is called once per frame
    void Update()
    {
       
    }

   public  void spawn_platform() 
    {
        temp = Instantiate(platfrom,spawn_pos,Quaternion.identity);
        spawn_pos = temp.transform.GetChild(1).transform.position;
    }

}


