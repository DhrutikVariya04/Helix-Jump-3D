using UnityEngine;

public class Ringrotation : MonoBehaviour
{
    [SerializeField] int RotateSpeed;

    void Update()
    {
        RingModelRotation();
    }

    void RingModelRotation()
    {

        if (Input.GetMouseButton(0))
        {
            var Rot = Input.GetAxis("Mouse X")  * Time.deltaTime * RotateSpeed;

            transform.Rotate(0f, -Rot, 0f);
        }
    }
}
