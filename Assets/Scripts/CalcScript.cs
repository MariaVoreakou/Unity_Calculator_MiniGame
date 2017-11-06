using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CalcScript : MonoBehaviour {

    // public int[] randomArray;

    public List<string> rndNumbersArray;
    public int maxArrayLength = 8;
    


	// Use this for initialization
	void Start () {
        
    }
	// Update is called once per frame
	void Update () {
		
	}
    public void NormalCalculate()
    { 
        int result;
        int add = 0;
        int substract = 0;
        int multiply = 0;
        int divide = 0;
        for (int i = 0; i < maxArrayLength; i++){
            result= Random.Range(-100, max: 1000);
            rndNumbersArray.Add(result.ToString());
            add = int.Parse(rndNumbersArray[0]) + int.Parse(rndNumbersArray[1]);
            substract = int.Parse(rndNumbersArray[2]) - int.Parse(rndNumbersArray[3]);
            multiply = int.Parse(rndNumbersArray[4]) * int.Parse(rndNumbersArray[5]);
            divide = int.Parse(rndNumbersArray[6]) / int.Parse(rndNumbersArray[7]);
        }
        Debug.Log("Add "+ rndNumbersArray[0] + " + " + rndNumbersArray[1]+" = "+ add + "\n");
        Debug.Log("Substraction " + rndNumbersArray[2] + " + " + rndNumbersArray[3] + " = " + substract + "\n");
        Debug.Log("Multiply " + rndNumbersArray[4] + " + " + rndNumbersArray[4] + " = " + multiply + "\n");
        Debug.Log("Divide " + rndNumbersArray[6] + " + " + rndNumbersArray[7] + " = " + divide + "\n");

    }
    public void AbnormalCalculate()
    {
        int result;
        int fakeAdd = 0;
        int fakeSubstract = 0;
        int fakeMultiply = 0;
        int fakeDivide = 0;
        for (int i = 0; i < maxArrayLength; i++)
        {
            result = Random.Range(-100, max: 1000);
            rndNumbersArray.Add(result.ToString());
            fakeAdd = int.Parse(rndNumbersArray[0]) * int.Parse(rndNumbersArray[1]);
            fakeSubstract = int.Parse(rndNumbersArray[2]) - int.Parse(rndNumbersArray[3]);
            fakeMultiply = int.Parse(rndNumbersArray[4]) / int.Parse(rndNumbersArray[5]);
            fakeDivide = int.Parse(rndNumbersArray[6]) + int.Parse(rndNumbersArray[7]);
        }
        Debug.Log("(Fake) Add " + rndNumbersArray[0] + " + " + rndNumbersArray[1] + " = " + fakeAdd+ "\n");
        Debug.Log("(Fake) Substraction " + rndNumbersArray[2] + " + " + rndNumbersArray[3] + " = " + fakeSubstract + "\n");
        Debug.Log("(Fake) Multiply " + rndNumbersArray[4] + " + " + rndNumbersArray[4] + " = " + fakeMultiply + "\n");
        Debug.Log("(Fake) Divide " + rndNumbersArray[6] + " + " + rndNumbersArray[7] + " = " + fakeDivide + "\n");

    }

}
