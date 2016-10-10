using UnityEngine;


public class Seek : MonoBehaviour
{
    // Use this for initialization
    private void Start()
    {
        b = GetComponent<MonoBoid>().boid;

        

        //take this out
        CameraLookAt.Register(b);
    }
    
    private Vector3 SteeringVelocity;
    private Vector3 DesiredVelocity;

    private void FixedUpdate()
    {


        DesiredVelocity = Vector3.Normalize(target.position - b.Position);

        SteeringVelocity = seekFactor * Vector3.ClampMagnitude(DesiredVelocity - b.Velocity, maxForce) / b.Mass;        

        b.UpdateVelocity(Vector3.ClampMagnitude(SteeringVelocity, b.MaxSpeed));


        if (dv) Debug.DrawLine(b.Position, (b.Position + DesiredVelocity) * 2.0f, Color.green);
        if (steer) Debug.DrawLine(b.Position, (b.Position + SteeringVelocity) * 2.0f, Color.red);


    }

    [SerializeField]
    private Boid b;
    public Transform target;
    public bool dv = false;
    public bool steer = false;
    public float maxForce = 1.0f;
    [Range(1.0f,5.0f)]
    public float seekFactor = 1.0f;




}
