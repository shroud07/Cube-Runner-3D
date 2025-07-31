using UnityEngine;

public class PlayerCollision : MonoBehaviour
{

    public PlayerScript ps;
    public Score score;
    public GameController controller;
    public AudioSource audioSource;

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Collectables")
        {
            audioSource.Play();
            Destroy(other.gameObject);
            score.addScore();
        }
    }

    private void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.tag == "Obstacles")
        {
            controller.gameOver();
            controller.stopBGM();
            ps.enabled = false;
        }
    }
}
