using UnityEngine;

public class MusicAudio : MonoBehaviour
{
    [SerializeField] AudioSource music;

    public void onMusic()
    {
        music.mute = false;
    }

    public void offMusic()
    {
        music.mute = true;
    }
}
