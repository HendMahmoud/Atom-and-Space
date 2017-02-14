using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlanetInfo : MonoBehaviour {
    float volume;
    float radius;
    float circumference;
    float mass;
    string surface;
    float averageTemperature;
    string positionFromSun;
    int orbitalPeriod;
    string dayHours;
    int numberOfMoons;
    float lightSpeed;
    float distanceFromSun;

   
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void setVolume(float _volume)
    {
        volume = _volume;
    }
    public float getVolume()
    {
        return volume;
    }
    public void setRadius(float _radius)
    {
        radius = _radius;
    }
    public float getRadius()
    {
        return radius;
    }
    public void setCircumference(float _circumference)
    {
        circumference = _circumference;
    }
    public float getCircumference()
    {
        return circumference;
    }
    public void setMass(float _mass)
    {
        mass = _mass;
    }
    public float getMass()
    {
        return mass;
    }
    public void setSurface(string _surface)
    {
        surface = _surface;
    }
    public string getSurface()
    {
        return surface;
    }
    public void setAverageTemperature(float _averageTemperature)
    {
        averageTemperature = _averageTemperature;
    }
    public float getAverageTemperature()
    {
        return averageTemperature;
    }
    public void setPositionFromSun(string _positionFromSun)
    {
        positionFromSun = _positionFromSun;
    }
    public string getPositionFromSun()
    {
        return positionFromSun;
    }
    public void setOrbitalPeriod(int _orbitalPeriod)
    {
        orbitalPeriod = _orbitalPeriod;
    }
    public int getOrbitalPeroid()
    {
        return orbitalPeriod;
    }
    public void setDayHours(string _dayHours)
    {
        dayHours = _dayHours;
    }
    public string getDayHours()
    {
        return dayHours;
    }
    public void setNumberOfMoons(int _numOfMoons)
    {
        numberOfMoons = _numOfMoons;
    }
    public int getNumberOfMoons()
    {
        return numberOfMoons;
    }
    public void setDistanceFromSun(float _distanceFromSun)
    {
        distanceFromSun = _distanceFromSun;
    }
    public float getDistanceFromSun()
    {
        return distanceFromSun;
    }
}
