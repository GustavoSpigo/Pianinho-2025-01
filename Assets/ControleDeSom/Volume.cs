using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class Volume : MonoBehaviour
{
    [SerializeField]
    string volumeName;
    [SerializeField]
    AudioMixer audioMixer;
    [SerializeField]
    Slider volumeSlider;

    private void Start()
    {
        volumeSlider.value = PlayerPrefs.GetFloat(volumeName, 0);     
    }

    public void AlteraVolume()
    {
        audioMixer.SetFloat(volumeName, volumeSlider.value);
        PlayerPrefs.SetFloat(volumeName, volumeSlider.value);
    }
}
