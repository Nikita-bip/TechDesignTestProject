using UnityEngine;

public class ImageClickVFX : MonoBehaviour
{
    [SerializeField] private ParticleSystem _vfx; 

    void OnMouseDown()
    {
        PlayVFX();
    }

    private void PlayVFX()
    {
        if (_vfx != null)
        {
            _vfx.Play();
        }
    }
}
