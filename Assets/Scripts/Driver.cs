using UnityEngine;

public class Driver : MonoBehaviour
{
    [SerializeField]float steerSpeed = 200;
    [SerializeField]float moveSpeed = 10;
    [SerializeField]float slowSpeed= 5;
    [SerializeField]float boostSpeed=30;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    public void Update()
    {
        float steerAmount=Input.GetAxis("Horizontal")* steerSpeed * Time.deltaTime;
        float moveSpeedF = Input.GetAxis("Vertical")* moveSpeed * Time.deltaTime;
        
        transform.Rotate(0,0,-steerAmount);
        transform.Translate(0,moveSpeedF,0);
        
        
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag=="Boost")
        {
            moveSpeed=boostSpeed;
            
        }
   
    }
    void OnCollisionEnter2D(Collision2D other)
    {
       
            moveSpeed=slowSpeed;
        
    }
   
}
