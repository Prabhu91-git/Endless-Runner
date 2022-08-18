using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform_Manager : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject[] obstacle;
    public GameObject artifacts;

    void Start()
    {
        spawn_obstacle();
        Spawn_Artifcats();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerExit(Collider other)
    {
        Platform_spawner.instance.spawn_platform();
        Destroy(gameObject, 2f);
    }


    public void spawn_obstacle()
    {
        int rand_obs = Random.Range(0, 2);
        int rand = Random.Range(2, 5);
        Transform spawnpos_obstacles = transform.GetChild(rand).transform;
        Instantiate(obstacle[rand_obs], spawnpos_obstacles.position,Quaternion.identity,transform);
    }

    public void Spawn_Artifcats() 
    {
        int rand = Random.Range(5,8);
        Transform spawnpos_artifacts = transform.GetChild(rand).transform;
        Instantiate(artifacts, spawnpos_artifacts.position, Quaternion.identity,transform);

        int rand2 = Random.Range(8,11);
        Transform spawnpos2_artifacts = transform.GetChild(rand2).transform;
        Instantiate(artifacts, spawnpos2_artifacts.position, Quaternion.identity, transform);
    }
}
