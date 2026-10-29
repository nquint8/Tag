using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class PlayerMovement : MonoBehaviour
{

    public InputAction Move;
    private Rigidbody rb;
    private Vector2 MovementInfo;
    public float speed = 5f;
    public TextMeshProUGUI Text;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Move.Enable();
        rb = GetComponent<Rigidbody>();
    }

    void ReadInput(InputAction Info)
    {
        MovementInfo = Info.ReadValue<Vector2>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        ReadInput(Move);
        Vector3 movement = new Vector3(MovementInfo.x, 0f, MovementInfo.y) * speed;
        rb.MovePosition(rb.position+movement * Time.fixedDeltaTime);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Enemy"))
        {
            Destroy(gameObject);
            Text.text = "You Lose";
        }
        if (collision.gameObject.CompareTag("Winpad"))
        {
            Destroy(gameObject);
            Text.text = "You Win!!!";
        }
    }
}
