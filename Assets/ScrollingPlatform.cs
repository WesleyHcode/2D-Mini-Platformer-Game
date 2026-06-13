using UnityEngine;

public class ScrollingPlatform : MonoBehaviour
{
    public float speed = 2f;

    public float resetX = -12f;

    public float startX = 12f;

    void Update()
    {
        transform.Translate(
            Vector2.left *
            speed *
            Time.deltaTime);

        if(transform.position.x < resetX)
        {
            transform.position =
                new Vector3(
                    startX,
                    transform.position.y,
                    transform.position.z);
        }
    }
}