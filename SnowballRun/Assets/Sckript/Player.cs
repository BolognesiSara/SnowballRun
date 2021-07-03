using UnityEngine;

public class Player : MonoBehaviour
{

    [SerializeField] private float jumpStrenght = 3;
    [SerializeField] private float speedMove = 2;


    void Update()
    {

        if ( Input.GetKey(KeyCode.RightArrow) )
        {
            transform.position += Vector3.right * speedMove * Time.deltaTime;
        }

        if ( Input.GetKey(KeyCode.LeftArrow) )
        {
            transform.position += Vector3.left * speedMove * Time.deltaTime;
        }
           
        if ( Input.GetKey(KeyCode.Space) )
        {
            transform.position += Vector3.up * jumpStrenght * Time.deltaTime;
        }
           
        if ( Input.GetKey(KeyCode.LeftAlt) )
        {
            transform.position += Vector3.down * jumpStrenght * Time.deltaTime;
        }

    }

}
