using UnityEngine;

public class ImageClickAnimation : MonoBehaviour
{
    [SerializeField] private AudioClip _sound;
    [SerializeField] private Animator _animator;
    [SerializeField] private AudioSource _audioSource;

    void OnMouseDown()
    {
        PlayAnimation();
        PlaySound();
    }

    private void PlayAnimation()
    {
        if (_animator != null)
        {
            _animator.SetTrigger("Play");
        }
    }

    private void PlaySound()
    {
        if (_sound != null)
        {
            _audioSource.PlayOneShot(_sound);
        }
    }
}