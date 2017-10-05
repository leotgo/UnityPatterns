using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace Patterns.StateMachine
{
    public class State : MonoBehaviour
    {
        public Transition[] transitions;

        private void Awake()
        {
            transitions = GetComponents<Transition>();
        }

        public virtual void OnEnter() { }
        public virtual void OnStay() { }
        public virtual void OnExit() { }
    }
}
