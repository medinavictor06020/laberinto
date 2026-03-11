using UnityEngine;
using UnityEngine.SceneManagement;


public class DeathZone : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Ball"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}


