using UnityEngine;

public class Player_Control : MonoBehaviour
{
    public Rigidbody rb;
    public GameObject player;
    public float speed, hspeed, vspeed;
    float horizonatlmove, verticalmove;
    Vector3 Movefront, Moveside,Moveup,Scale_Mod,Scale_Normal;
 

    public static Player_Control instance;

    private void Awake()
    {
        instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {    
        Scale_Mod = new Vector3(0.2f,0.2f,0.2f);
        Scale_Normal = new Vector3(0.8f, 0.8f, 0.8f);
    }

    // Update is called once per frame
    void Update()
    {
       horizonatlmove  = Input.GetAxisRaw("Horizontal");
       verticalmove = Input.GetAxisRaw("Up");
       
        if (Input.GetKey(KeyCode.DownArrow))
        {
            player.transform.localScale = Scale_Mod;
        }

        else
        {
            player.transform.localScale = Scale_Normal;
        }

    }

    private void FixedUpdate()
    {
      
            Movefront = transform.forward * speed * Time.fixedDeltaTime;
            Moveside = transform.right * horizonatlmove * Time.fixedDeltaTime * hspeed;
            Moveup = transform.up * verticalmove * Time.fixedDeltaTime * vspeed;
            rb.MovePosition(rb.position + Movefront + Moveside + Moveup);
   
    }
}
