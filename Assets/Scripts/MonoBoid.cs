using UnityEngine;

public class MonoBoid : MonoBehaviour
{
    [Range(1,1000)]
    public float mass;
    [Range(1,50)]
    public float max_speed;
    private Boid b;
    
    public Boid boid
    {
        get { return b; }
    }

    
    void Awake()
    {
       // max_speed = m_boid.MaxSpeed;
        mass = Random.Range(100, 500);
        //transform.localScale *= mass / 200;
        b = new Boid(mass);
        
        transform.position = new Vector3(Random.Range(0.0f, 10.0f), Random.Range(0.0f, 10.0f), 0);
        b.Position = transform.position;
         
        b.Velocity = transform.position.normalized;

    }
    void Update()
    {
        b.Mass = mass;
        b.MaxSpeed = max_speed;
    }


    void LateUpdate()
    { b.Position = b.Position + b.Velocity;
        transform.position = b.Position;
    }
}
