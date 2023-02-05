using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartParticles : MonoBehaviour
{
    public ParticleSystem blood;

    public void StartEffect()
    {
        blood.Play();
    }
}
