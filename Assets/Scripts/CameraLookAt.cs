using UnityEngine;
using System.Collections.Generic;

public class CameraLookAt : MonoBehaviour {
    
    // Use this for initialization
    public static List<Boid> boids = new List<Boid>();
    

	public static void Register(Boid s)
    {
        boids.Add(s);
    }
    // Update is called once per frame
    
	void Update ()
    {
        Vector3 center = Vector3.zero;
        foreach (Boid b in boids)
        {
            center += b.Position;
        }
        center /= boids.Count;
        transform.LookAt(center);
        
	}




    


}
