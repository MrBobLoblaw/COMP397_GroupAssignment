using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    [Header("Sounds")]
    AudioSource m_AudioSource;
    public AudioClip[] sfxClips;

    // Start is called before the first frame update
    void Start()
    {
        m_AudioSource = GetComponent<AudioSource>();
        //DontDestroyOnLoad(m_AudioSource);
    }



    public void PLAY_SOUND_ONCE(int element)
    {

        if (m_AudioSource != null && sfxClips != null)
        {
            m_AudioSource.PlayOneShot(sfxClips[element]);
        }
        else
        {
            Debug.Log("AudioSource or sfxClips are null");
        }
    }
}
