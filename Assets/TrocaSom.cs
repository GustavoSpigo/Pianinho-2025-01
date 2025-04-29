using UnityEngine;

public class TrocaSom : MonoBehaviour
{
    [SerializeField]
    private AudioClip som;

    [SerializeField]
    private AudioSource[] teclas;

    private void OnMouseUp()
    {
        foreach (AudioSource item in teclas)
        {
            item.clip = som;
        }
    }
}
