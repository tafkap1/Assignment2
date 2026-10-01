using UnityEngine;

public class ExhibitTrigger : MonoBehaviour
{
    public GameObject infoPanel;

    private void OnTriggerEnter(Collider other)
    {
        infoPanel.SetActive(true);
    }

    private void OnTriggerExit(Collider other)
    {
        infoPanel.SetActive(false);
    }
}