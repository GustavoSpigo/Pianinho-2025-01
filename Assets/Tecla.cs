using UnityEngine;

public class Tecla : MonoBehaviour
{
    private AudioSource claudio;
    [SerializeField]
    private KeyCode telca;

    private void Start()
    {
        claudio = GetComponent<AudioSource>();
    }
    private void OnMouseDown()
    {
        claudio.Play();
    }

    private void Update()
    {
        if (Input.GetKeyDown(telca))
        {
            claudio.Play();
        }
    }

}
