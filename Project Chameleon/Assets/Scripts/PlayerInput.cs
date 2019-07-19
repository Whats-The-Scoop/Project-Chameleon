using System.Collections;
using UnityEngine;

[RequireComponent (typeof (Player))]
public class PlayerInput : MonoBehaviour
{
    Player player;
    void Start()
    {
        player = GetComponent<Player>();
    }

    void Update()
    {
        Vector2 directionInput = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
       player.SetDirectionalImput(directionInput);

        if (Input.GetKeyDown (KeyCode.Space))
        {
            player.OnJumpInputDown();
        }
        if (Input.GetKeyUp (KeyCode.Space))
        {
            player.OnJumpInputUp();
        }
    }
}
