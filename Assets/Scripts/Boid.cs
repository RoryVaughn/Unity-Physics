using UnityEngine;
using System;
[Serializable]
public class Boid : ISteering
{
    public Boid(float mass)
    { 
        m_Position = Vector3.zero;
        m_CurrentVelocity = Vector3.zero; 
        
        m_mass = (mass == 0) ? 1 : mass;

    }
     
    [SerializeField]
    private Vector3 m_Position;
    [SerializeField]
    private Vector3 m_CurrentVelocity;
   
    [SerializeField]
    private float m_mass;
    [SerializeField]
    private float m_MaxSpeed;
    public void UpdateVelocity(Vector3 v)
    {

        lock (this)
        {
           Velocity += v;
        }
    }
    public Vector3 Velocity
    {
        get
        {
            return m_CurrentVelocity;
        }

        set
        {
            m_CurrentVelocity = value;
        }
    }
     

    public Vector3 Position
    {
        get
        {
            return m_Position;
        }

        set
        {
            m_Position = value;
        }
    }
 

    public float Mass
    {
        get
        {
            return m_mass;
        }

        set
        {
            m_mass = value;
        }
    }

    public float MaxSpeed
    {
        get
        {
            return m_MaxSpeed;
        }

        set
        {
            m_MaxSpeed = value;
        }
    }
}