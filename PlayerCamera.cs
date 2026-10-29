using UnityEngine;

public class PlayerCamera : MonoBehaviour
{
    public GameObject Player;
    private Vector3 offset;



    void Start()
    {
        if(Player != null)
        {
         offset  = Player.transform.position - transform.position;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
