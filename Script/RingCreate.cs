using UnityEngine;

public class RingCreate : MonoBehaviour
{
    [SerializeField] GameObject[] Ring;
    [SerializeField] GameObject LastRing;
    [SerializeField] int HelixLength;
    [SerializeField] float offset;

    void Start()
    {       

        for (int i = 0; i < HelixLength; i++)
        {
            var Value = Random.Range(0, Ring.Length);
            var ring = Instantiate(Ring[Value], transform);
            var Pos = ring.transform.position;
            Pos.y -= offset * i;
            ring.transform.position = Pos;

            var rotaion = Random.Range(0, 360);
            ring.transform.rotation = Quaternion.Euler(0, rotaion, 0);
        }

        GameObject p1 = Instantiate(LastRing,transform);
        var NewPos = p1.transform.position;
        NewPos.y -= offset * HelixLength;
        p1.transform.position = NewPos;

    }
}
