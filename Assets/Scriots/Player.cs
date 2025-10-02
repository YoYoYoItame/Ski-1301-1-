using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField]
     private Rigidbody rb;
    [SerializeField] 
    private float forcePower;
    [SerializeField] 
    private float xInput;

     [SerializeField] 
     private int score = 0;
     public int Score { get { return score; } set {  score = value; } }
    
    [SerializeField] 
     private int hp = 100;
     public int HP { get { return hp; } set {  hp = value; } }
    void Start()
    {
       rb = GetComponent<Rigidbody>(); 
    }

    // Update is called once per frame
    void Update()
    {
        MoveLeftorRight();
    }
    private void MoveLeftorRight()
    {
         xInput = Input.GetAxis("Horizontal");
         rb.AddForce(xInput * Vector3. right * forcePower);
    }
}
