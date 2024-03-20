using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public abstract class  BaseItemState
{
   public abstract string NAME_STATE { get; }
   public abstract void EnterState(PlantStateManager plantStateManager);
   public abstract void UpdateState(PlantStateManager plantStateManager);
}
