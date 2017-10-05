using System;
using System.Linq;
using System.Collections;
using System.Reflection;
using UnityEngine;
using System.Collections.Generic;

namespace Patterns.Observer
{
    public enum Message
    {
        // COMBAT ============================ //

        Combat_Index = 1,
        Combat_Hit,
        Combat_GotHit,
        Combat_EnergyChanged,
        Combat_EnergyBlockConsumed,
        Combat_BodyPartHealthChanged,
        Combat_BodyPartDestroyed,
        Combat_Punch,
        Combat_WeaponShoot,
        Combat_EnergyDanger,
        Combat_Struck,
        Combat_Death,

        // MOVEMENT ========================== //

        Movement_Index = 300,
        Movement_StepGrass,
        Movement_StepMetal,

        // SYSTEM ============================ //

        System_Index = 700,
        System_Pause,
        System_Unpause
    }
}