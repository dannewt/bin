using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SineWave
{
    #region Fields

    //Parameters of Sine Wave Function
    float m_Amplitude = 1f;
    float m_Period = 1f;
    float m_PhaseShift = 0f;
    float m_VerticalShift = 0f;

    //Function Execution
    float totalTime = 0f;
    float startTime;
    bool started = false;

    //Function Value
    float value;

    #endregion

    #region Properties

    public float Value
    {
        get { return value; }
    }

    public float Amplitude
    {
        get { return m_Amplitude; }
    }

    public float Period
    {
        get { return m_Period; }
    }

    public float PhaseShift
    {
        get { return m_PhaseShift; }
    }

    public float VerticalShift
    {
        get { return m_VerticalShift; }
    }

    #endregion


    #region Methods
    /// <summary>
    /// calculate sin(t) at a given time since the
    /// start of the function
    /// </summary>
    public float Calculate(float time)
    {
        if (started)
        {
            value = m_Amplitude * Mathf.Sin(m_Period * (time + m_PhaseShift)) + m_VerticalShift;
        }

        return value;
    }

    /// <summary>
    /// Begin the computation of the sin wave
    /// </summary>
    public void Run()
    {
        started = true;
        totalTime = 0f;
        startTime = Time.time;
    }
    #endregion

    #region Constructors
    public SineWave(float amplitude, float period, float phaseShift, float verticalShift)
    {
        m_Amplitude = amplitude;
        m_Period = period;
        m_PhaseShift = phaseShift;
        m_VerticalShift = verticalShift;
    }

    public SineWave(float amplitude, float period)
    {
        m_Amplitude = amplitude;
        m_Period = period;
    }

    public SineWave(float amplitude)
    {
        m_Amplitude = amplitude;
    }

    public SineWave()
    {
        
    }

    #endregion
}
