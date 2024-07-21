using UnityEngine;

public class RingDestroy : MonoBehaviour
{
    Transform Player;
    float radius = 2;
    float Force = 150;

    void Start()
    {
        Player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    // Update is called once per frame
    void Update()
    {
        if (Player.position.y < transform.position.y)
        {
            DestroyPieace();
        }
    }

    private void DestroyPieace()
    {
        Collider[] Pieace = Physics.OverlapSphere(transform.position, radius);

        foreach (var col in Pieace)
        {
            Rigidbody body = col.gameObject.GetComponent<Rigidbody>();

            if (body != null && col.tag == "Piece" || body != null && col.tag == "Red")
            {
                body.isKinematic = false;
                body.AddExplosionForce(Force,col.transform.position,5);
            }
        }
        Destroy(gameObject,1.5f);
    }
}
