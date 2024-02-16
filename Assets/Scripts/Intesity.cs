using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.Universal;

public class Intesity : MonoBehaviour
{
    public Light2D lampje;

    public void DoeLampjeFeller()
    {
        lampje.intensity = 10;
    }

    public void DoeLampjeDimme()
    {
        lampje.intensity = 1;
    }

    public void DoeLampjeIetsMee(float waarde)
    {
        lampje.intensity = waarde;
    }
}
