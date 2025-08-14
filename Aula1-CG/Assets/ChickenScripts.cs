using UnityEngine;

public class ChickenScripts : MonoBehaviour
{
    public Rigidbody2D myRigidbody;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        gameObject.name = "Guy Linha";
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)==true)
        {
            myRigidbody.linearVelocity = Vector2.up*10;
        }
    }
}
