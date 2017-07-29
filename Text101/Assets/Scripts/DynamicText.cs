using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DynamicText : MonoBehaviour 
{
    [SerializeField] Text m_textContainer;

    enum BhanuState
    {
        DoingNoting,
        Journey,
        UpgradeSkills,
        JobInField,
        GameSuccess
    };

    [SerializeField] BhanuState m_currentState;

	void Start() 
    {
        m_currentState = BhanuState.DoingNoting;
	}
	
	void Update() 
    {
        UpdateStates();
	}

    void DoingNothing()
    {
        m_textContainer.text = "Bhanu's Story\n\n" + "Press J to make me start my Journey";

        if(Input.GetKeyDown(KeyCode.J))
        {
            m_currentState = BhanuState.Journey;
        }
    }

    void JourneyState()
    {
        m_textContainer.text = "Hi, I am Bhanu and I arrived to UK in Feb 2007 and since then, it has been ultimate struggle until 2017 just to get my Indefinite Leave " + 
                               "to Remain Visa (ILR). I am now completely focussed to settle in life and give me and my family a real lifestlyle which will make me fully " + 
                               "satisfied in life and I can rest at peace and one day, Rest In Peace \n\n" + "Press U to make me upgrade my skills or R to return to " +  
                               "my previous state of doing nothing";

        if(Input.GetKeyDown(KeyCode.U))
        {
            m_currentState = BhanuState.UpgradeSkills;
        }

        else if(Input.GetKeyDown(KeyCode.R))
        {
            m_currentState = BhanuState.DoingNoting;
        }
    }

    void UpdateStates()
    {
        if(m_currentState == BhanuState.DoingNoting)
        {
            DoingNothing();
        }

        else if(m_currentState == BhanuState.Journey)
        {
            JourneyState();
        }

        else if(m_currentState == BhanuState.UpgradeSkills)
        {
            UpgradeSkills();
        }
    }

    void UpgradeSkills()
    {
        m_textContainer.text = "Man!!!! learning Programming is mind scrambler but since there is lot of money in the industry, I will do what it takes to become an excellent C# and/or " +
                               "C++ programmer and get a great job or even better, with the help of great Game engines like Unity3D with C# or Unreal with C++, make a great game and " + 
                               "make shit load of money so me and my family can have a great lifestyle\n\n" + "Press R to make me go back to my Journey State" ;

        if(Input.GetKeyDown(KeyCode.R))
        {
            m_currentState = BhanuState.Journey;
        }
    }
}
