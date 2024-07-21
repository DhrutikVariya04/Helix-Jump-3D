using UnityEngine;

public class Camera : MonoBehaviour
{
    public GameObject ball;
    float offset;
    Vector3 lastPosition;

    void Start()
    {
        offset = transform.position.y - ball.transform.position.y;
        lastPosition = ball.transform.position;
    }

    void Update()
    {
        CameraMovement();
    }

    void CameraMovement()
    {
        var CameraPos = transform.position;
        var BallPos = ball.transform.position;

        CameraPos.y =  Mathf.Min(BallPos.y + offset , lastPosition.y);

        lastPosition = CameraPos;

        transform.position = CameraPos;

    }
}
