using UnityEngine;

public class BotaoLoop : MonoBehaviour
{
    [SerializeField]
    private AudioSource[] OutrosBotoes;

    private AudioSource m_AudioSource;
    private Animator m_Animator;
    void Start()
    {
        m_AudioSource = GetComponent<AudioSource>();
        m_Animator = GetComponent<Animator>();
    }

    private void OnMouseUp()
    {
        if (m_AudioSource.isPlaying)
        {
            m_AudioSource.Stop();
            return;
        }
        foreach (AudioSource CadaBotao in OutrosBotoes)
        {
            CadaBotao.Stop();
        }
        m_AudioSource.Play();
    }
    private void Update()
    {
        m_Animator.SetBool("tocando", m_AudioSource.isPlaying);
    }
}
