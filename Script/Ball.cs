using UnityEngine;

public class Ball : MonoBehaviour
{
    Rigidbody body;
    public GameObject RestartCanvas,Image,CountineCanvas;

    void Start()
    {
        body = GetComponent<Rigidbody>();
    }

    private void OnCollisionEnter(Collision collision)
    {
       
        body.linearVelocity = Vector2.up * 5;

        // For Ball Splash :--
        var Splash = Instantiate(Image, collision.transform);

        var Newpos = transform.position;
        Newpos.y = collision.transform.position.y + 0.22f;

        Splash.transform.position = Newpos;

        Destroy(Splash,1.5f);

        if (collision.transform.tag == "Red")
        {
            RestartCanvas.SetActive(true);
            Time.timeScale = 0;
        }

        if(collision.transform.tag == "Finish")
        {
            CountineCanvas.SetActive(true);
            Time.timeScale = 0;
        }
    }
}
