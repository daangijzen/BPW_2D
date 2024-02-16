using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.Universal;

public class Intensity : MonoBehaviour
{
    public Light2D lampje;

    public void DoeLampjeFel()
    {
        lampje.intensity = 10;
    }

    public void DoeMinderFel()
    {
        lampje.intensity = 1;
    }

    public void DoeWaardeAnders(float waarde)
    {
        lampje.intensity = waarde;
    }
}
