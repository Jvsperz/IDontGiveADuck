using Unity.Cinemachine;
using UnityEngine;

public class CameraShake : MonoBehaviour
{
    public static CameraShake instance;
    private float Globalshakeforce = 1;
    private void Awake()
    {
        if (instance == null) ;
        instance = this;

    }

    public void Camerashake(CinemachineImpulseSource ImpulseSource)
    {
        ImpulseSource.GenerateImpulseWithForce(Globalshakeforce);
    }
}
