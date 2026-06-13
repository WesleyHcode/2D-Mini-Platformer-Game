using UnityEngine;

public class MovingPlatformV : MonoBehaviour
{
    public float speed = 2f;
    public float distance = 3f;

    public bool moveVertical = true;

    private Vector3 startPos;

    void Start()
    {
        startPos = transform.position;
    }

    void Update()
    {
        float movement =
            Mathf.Sin(Time.time * speed)
            * distance;

        if(moveVertical)
        {
            transform.position =
                startPos +
                new Vector3(0, movement, 0);
        }
        else
        {
            transform.position =
                startPos +
                new Vector3(movement, 0, 0);
        }
    }
}