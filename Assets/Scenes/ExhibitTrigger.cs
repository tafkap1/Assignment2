using UnityEngine;

public class ExhibitTrigger : MonoBehaviour
{
    public GameObject infoPanel;
    public AudioSource exhibitAudio;

    private void Start()
    {
        infoPanel.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            infoPanel.SetActive(true);

            if (!exhibitAudio.isPlaying)
            {
                exhibitAudio.Play();
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            infoPanel.SetActive(false);
        }
    }
}