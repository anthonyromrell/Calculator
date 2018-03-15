﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Operation : ScriptableObject
{
	public abstract void Operate(List<float> numbers);
}
