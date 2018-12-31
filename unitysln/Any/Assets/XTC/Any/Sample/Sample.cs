using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using XTC.Types;

public class Sample : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Any any = new Any("sampale");
		compareTag(any);
		printValue(any);

		Debug.Log("----------------------------------");

		any.AsBool = true;
		compareTag(any);
		printValue(any);

		Debug.Log("----------------------------------");

		any.AsFloat = 3.6f;
		compareTag(any);
		printValue(any);
		
	}
	
	void compareTag(Any _any)
	{
		Debug.Log("is string: " + _any.IsString);
		Debug.Log("is int: " + _any.IsInt);
		Debug.Log("is long: " + _any.IsLong);
		Debug.Log("is float: " + _any.IsFloat);
		Debug.Log("is double: " + _any.IsDouble);
		Debug.Log("is bool: " + _any.IsBool);
	}

	void printValue(Any _any)
	{
		Debug.Log("as string: " + _any.AsString);
		Debug.Log("as int: " + _any.AsInt);
		Debug.Log("as long: " + _any.AsLong);
		Debug.Log("as float: " + _any.AsFloat);
		Debug.Log("as double: " + _any.AsDouble);
		Debug.Log("as bool: " + _any.AsBool);
	}
}
